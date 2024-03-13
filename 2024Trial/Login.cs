using System.Data.SqlClient;

namespace _2024Trial
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }

        static string server = "127.0.0.1";
        static string database = "UserManagementDB";
        static string userid = "sa";
        static string userpw = "test1234";
        string connectString = $"Server={server};Database={database};Uid={userid};Pwd={userpw};";


        private void LoginButton_Click(object sender, EventArgs e)
        {
            var inputId = IDBox.Text.ToString();
            var inputPw = PWBox.Text.ToString();
            bool AccountExistance = false;
            bool isPasswordCorrect = false;
            var usernickname = "";
            bool isAdmin = false;
            int IDX = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    AccountExistance = new SqlCommand($"SELECT * FROM dbo.[User] WHERE [uid]='{inputId}'", conn).ExecuteReader().Read();
                    conn.Close();
                    conn.Open();
                    SqlDataReader dr = new SqlCommand($"SELECT userName, isAdmin, idx FROM dbo.[User] WHERE [uid]='{inputId}'", conn).ExecuteReader();
                    if (dr.Read())
                    {
                        usernickname = dr.GetString(0);
                        isAdmin = dr.GetBoolean(1);
                        IDX = dr.GetInt32(2);

                        isPasswordCorrect = true;
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (String.IsNullOrEmpty(inputId) || String.IsNullOrEmpty(inputPw))
            {
                MessageBox.Show("빈칸이 존재합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!AccountExistance)
            {
                MessageBox.Show("존재하지 않는 회원입니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!isPasswordCorrect)
            {
                MessageBox.Show("비밀번호가 올바르지 않습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (isAdmin)
                {//관리자로 로그인시
                    MessageBox.Show($"{usernickname} 관리자님 환영합니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Visible = false;
                    UserManage usermanage = new(this);
                    usermanage.Show();

                }
                else
                {//회원으로 로그인시
                    MessageBox.Show($"{usernickname} 회원님 환영합니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Visible = false;
                    AccountManage accountmanage = new(this, IDX);
                    accountmanage.Show();
                }
                //ID 저장
                if (SaveIDCheckBox.Checked)
                {
                    Properties.Settings.Default.ID = inputId;
                    Properties.Settings.Default.Save();
                }

            }

        }

        //회원가입 링크
        private void RegiRedirectLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register(this);
            register.Show();
            this.Visible = false;
        }



        private void Login_Load(object sender, EventArgs e)
        {//id저장기능
            if (!string.IsNullOrEmpty(Properties.Settings.Default.ID))
            {
                IDBox.Text = Properties.Settings.Default.ID;
                SaveIDCheckBox.Checked = true;
            }
        }

        private void Login_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                IDBox.Text = null;
                PWBox.Text = null;
            }
            else
            {
                if (!string.IsNullOrEmpty(Properties.Settings.Default.ID))
                {
                    IDBox.Text = Properties.Settings.Default.ID;
                    SaveIDCheckBox.Checked = true;
                }
            }
        }
    }
}
