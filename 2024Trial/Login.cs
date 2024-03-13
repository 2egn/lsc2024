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
                MessageBox.Show("��ĭ�� �����մϴ�.", "���", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!AccountExistance)
            {
                MessageBox.Show("�������� �ʴ� ȸ���Դϴ�.", "���", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!isPasswordCorrect)
            {
                MessageBox.Show("��й�ȣ�� �ùٸ��� �ʽ��ϴ�.", "���", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (isAdmin)
                {//�����ڷ� �α��ν�
                    MessageBox.Show($"{usernickname} �����ڴ� ȯ���մϴ�.", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Visible = false;
                    UserManage usermanage = new(this);
                    usermanage.Show();

                }
                else
                {//ȸ������ �α��ν�
                    MessageBox.Show($"{usernickname} ȸ���� ȯ���մϴ�.", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Visible = false;
                    AccountManage accountmanage = new(this, IDX);
                    accountmanage.Show();
                }
                //ID ����
                if (SaveIDCheckBox.Checked)
                {
                    Properties.Settings.Default.ID = inputId;
                    Properties.Settings.Default.Save();
                }

            }

        }

        //ȸ������ ��ũ
        private void RegiRedirectLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register(this);
            register.Show();
            this.Visible = false;
        }



        private void Login_Load(object sender, EventArgs e)
        {//id������
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
