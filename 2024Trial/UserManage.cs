using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _2024Trial
{
    public partial class UserManage : Form
    {
        Form? ParentForm = null;
        public UserManage(Form parentform)
        {
            InitializeComponent();
            ParentForm = parentform;
        }
        static string server = "127.0.0.1";
        static string database = "UserManagementDB";
        static string userid = "sa";
        static string userpw = "test1234";
        string connectString = $"Server={server};Database={database};Uid={userid};Pwd={userpw};";
        private void UserManage_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
            selectedRow = -1;
            dataGridView1.ClearSelection();
        }
        static List<bool> adminList = new();
        static List<bool> lockList = new();
        static int selectedRow = -1;
        public void refreshDataGridView()
        {
            dataGridView1.DataSource = null;
            SqlDataReader admin_lock_reader = null;
            adminList = new();
            lockList = new();


            using (SqlConnection conn = new SqlConnection(connectString))
            {
                //사용자 관리 datagridview에 들어가는 값을 넣기
                conn.Open();
                string sql = "SELECT idx as No, userName as 이름, uid as ID, nickName as 닉네임, dob as 생년월일 FROM dbo.[User] ORDER BY idx";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds, "std");
                        dataGridView1.DataSource = ds.Tables["std"];

                        if (dataGridView1.Columns.Contains("dob"))
                        {
                            dataGridView1.Columns["dob"].DefaultCellStyle.Format = "yy년 MM월 dd일";
                        }
                    }
                }
                conn.Close();

                //isAdmin, isLock 정보 가져오기
                conn.Open();
                admin_lock_reader = new SqlCommand("SELECT isAdmin, isLock FROM dbo.[User] ORDER BY idx", conn).ExecuteReader();
                while (admin_lock_reader.Read())
                {
                    adminList.Add(Convert.ToBoolean(admin_lock_reader["isAdmin"]));
                    lockList.Add(Convert.ToBoolean(admin_lock_reader["isLock"]));
                }
            }

            DataGridViewTextBoxColumn ageColumn = new();
            ageColumn.HeaderText = "(만)나이";
            ageColumn.Name = "agecolumn";
            dataGridView1.Columns.Add(ageColumn);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                //(만)나이 열 만들기

                DateTime birthdate;
                birthdate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value);
                DateTime currentdate = DateTime.Now;
                int age = currentdate.Year - birthdate.Year;
                if (currentdate.Month < birthdate.Month || (currentdate.Month == birthdate.Month && currentdate.Day < birthdate.Day))
                {
                    age--;
                }
                dataGridView1.Rows[i].Cells[5].Value = age + "세";
                //isAdmin, isLock 뒷배경 바꾸기
                if (adminList[i])
                {//어드민인 경우
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.SkyBlue;
                }
                else if (lockList[i])
                {//잠긴 계정인 경우
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                else
                {//기본인 경우
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = SystemColors.Control;
                }
            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {//정렬하면 만 나이 열이 사라져서 정렬막아둠
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            if (selectedRow >= 0)
            {
                if (lockList[selectedRow])
                {
                    lockButton.Text = "잠금 해제";
                }
                else
                {
                    lockButton.Text = "계정 잠금";
                }
            }

        }

        //셀 클릭따라 잠금텍스트 변경
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                if (lockList[selectedRow])
                {
                    lockButton.Text = "잠금 해제";
                }
                else
                {
                    lockButton.Text = "계정 잠금";
                }
            }

        }
        public void dataGridVIewReset()
        {//데이터그리드 초기화
            selectedRow = 0;
            dataGridView1.Columns.Clear();

            if (selectedRow >= 0)
            {
                if (lockList[selectedRow])
                {
                    lockButton.Text = "잠금 해제";
                }
                else
                {
                    lockButton.Text = "계정 잠금";
                }
            }
        }
        private void lockButton_Click(object sender, EventArgs e)
        {//잠금버튼
            if (selectedRow < 0)
            {//미선택
                MessageBox.Show("사용자를 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (adminList[selectedRow])
            {//관리자 선택
                MessageBox.Show("관리자는 잠금할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!lockList[selectedRow])
            {//성공적 잠금
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    new SqlCommand($"UPDATE dbo.[User] SET isLock = 1 WHERE idx={dataGridView1.Rows[selectedRow].Cells[0].Value}", conn).ExecuteNonQuery();
                }

                MessageBox.Show("계정 잠금이 완료됐습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {//성공적 잠금해제
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    new SqlCommand($"UPDATE dbo.[User] SET isLock = 0 WHERE idx={dataGridView1.Rows[selectedRow].Cells[0].Value}", conn).ExecuteNonQuery();
                }
                MessageBox.Show("잠금 해제가 완료됐습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            dataGridVIewReset();
            refreshDataGridView();
        }


        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {//우클릭 메뉴
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition);
            }
        }
        private void accountEditStrip_Click(object sender, EventArgs e)
        {//계정수정
            if (adminList[selectedRow])
            {//관리자인 경우
                MessageBox.Show("관리자는 수정할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {//사용자인 경우
                int IDX = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells[0].Value);
                string UID = Convert.ToString(dataGridView1.Rows[selectedRow].Cells[2].Value);
                DateTime DATE = Convert.ToDateTime(dataGridView1.Rows[selectedRow].Cells[4].Value);
                AccountEdit accountedit = new(IDX,UID,DATE,this); ;
                this.Visible = false;
                accountedit.Show();
            }
        }
        private void accountDeleteStrip_Click(object sender, EventArgs e)
        {//계정삭제
            if (adminList[selectedRow])
            {
                MessageBox.Show("관리자를 삭제할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    new SqlCommand($"DELETE FROM dbo.[User] WHERE idx={dataGridView1.Rows[selectedRow].Cells[0].Value}", conn).ExecuteNonQuery();
                }
                dataGridVIewReset();
                refreshDataGridView();
                MessageBox.Show("계정 삭제가 완료됐습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UserManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentForm.Visible = true;
        }
    }
}
