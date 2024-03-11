using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2024Trial
{
    public partial class AccountManage : Form
    {
        static string server = "127.0.0.1";
        static string database = "UserManagementDB";
        static string userid = "sa";
        static string userpw = "test1234";
        string connectString = $"Server={server};Database={database};Uid={userid};Pwd={userpw};";
        object[] userData = new object[4];//{idx, userName, nickName, dob}
        int? IDX;
        int selectedRow = -1;
        Form parentForm;
        List<string> imageList = new();//{filename}
        List<int> addList = new();
        List<int> removeList = new();
        int PrevmainPicnum = -1;
        int mainPicnum = -1;


        public AccountManage(Form parentform, int idx)
        {
            parentForm = parentform;
            IDX = idx;
            InitializeComponent();

        }
        private void AccountManage_Load(object sender, EventArgs e)
        {
            //유저 데이터 가져오기
            using (SqlConnection conn = new(connectString))
            {
                conn.Open();
                SqlDataReader dr = new SqlCommand($"SELECT uid, userName, nickName, dob FROM dbo.[User] WHERE idx={IDX}", conn).ExecuteReader();
                while (dr.Read())
                {
                    dr.GetValues(userData);
                }
                conn.Close();
                //사진 데이터 가져오기
                conn.Open();
                dr = new SqlCommand($"SELECT photo, isRepresent FROM dbo.[Photo] WHERE uIdx={IDX}", conn).ExecuteReader();
                while (dr.Read())
                {
                    
                    byte[] imageByte = (byte[])dr.GetValue(0);

                    Image image;
                    using(MemoryStream ms = new MemoryStream(imageByte))
                    {
                        image = Image.FromStream(ms);
                    }
                    if ((bool)dr.GetValue(1) == true)
                    {
                        MainPicBox.Image = image;
                        PrevmainPicnum = imageList.Count;
                        mainPicnum = imageList.Count;
                    }
                    imageList.Add(Convert.ToBase64String(imageByte));
                    dataGridView1.Rows.Add(imageList.Count, image);          
                    
                }
            }
            IDBox.Text = userData[0].ToString();
            NameBox.Text = userData[1].ToString();
            NickNameBox.Text = userData[2].ToString();
            DateBox.Value = Convert.ToDateTime(userData[3]);
            dataGridView1.ClearSelection();
            //이미지 행 크기에 맞추기
            DataGridViewImageColumn imagecolumn = dataGridView1.Columns[1] as DataGridViewImageColumn;
            imagecolumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {//편집정보저장
            if (EmptyCheck() & RepepetiveCheck())
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    //이름,닉네임,생년월일 저장
                    conn.Open();
                    new SqlCommand($"UPDATE dbo.[User] SET userName = '{NameBox.Text}', nickName = '{NickNameBox.Text}', dob = '{DateBox.Value.ToString("yyyy-MM-dd")}' WHERE idx = {IDX}", conn).ExecuteNonQuery();
                    conn.Close();
                    //이미지 저장(varbinary)
                    conn.Open();
                    foreach (int num in addList)
                    {
                        string addquery = $"INSERT INTO dbo.[photo] VALUES ({IDX},@BinaryValue,0)";
                        byte[] data = File.ReadAllBytes(imageList[num]);
                        SqlCommand cmd = new SqlCommand(addquery, conn);
                        SqlParameter param = new SqlParameter("@BinaryValue", SqlDbType.VarBinary);
                        param.Value = data;
                        cmd.Parameters.Add(param);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    conn.Open();
                    if (mainPicnum != PrevmainPicnum)
                    {
                        new SqlCommand($"UPDATE dbo.[Photo] SET isRepresent=1 ", conn).ExecuteNonQuery();
                    }
                    conn.Close();
                }

            }
        }

  
        private bool EmptyCheck()
        {//공백체크
            if (string.IsNullOrEmpty(NameBox.Text) || string.IsNullOrEmpty(NickNameBox.Text))
            {
                MessageBox.Show("사용자 정보를 모두 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool RepepetiveCheck()
        {//중복체크
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                //존재하는 이름이면 false
                if (new SqlCommand($"SELECT * FROM dbo.[User] WHERE [nickName]='{NickNameBox.Text}'", conn).ExecuteReader().Read())
                {
                    MessageBox.Show("이 닉네임은 이미 사용중입니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void AccountManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Visible = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {//사진 열기창
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "Image Files (*.png, *.jpg)|*.png;*.jpg";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {//사진 추가시
            foreach (string filename in openFileDialog1.FileNames)
            {
                imageList.Add(filename);
                Image image = Image.FromFile(filename);
                dataGridView1.Rows.Add(imageList.Count, image);
                addList.Add(imageList.Count - 1);
            }
            dataGridView1.ClearSelection();
        }


        private void MainPicButton_Click(object sender, EventArgs e)
        {
            if (selectedRow == -1)
            {
                MessageBox.Show("사진을 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int selectedPicID = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells[0].Value) - 1;
                Image image = Image.FromFile(imageList[selectedPicID]);
                MainPicBox.Image = image;
                mainPicnum = selectedPicID; 
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) selectedRow = e.RowIndex;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedRow == -1)
            {
                MessageBox.Show("삭제할 사진을 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (selectedRow-1==mainPicnum)
            {
                MessageBox.Show("대표 사진은 삭제할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }
    }
}
