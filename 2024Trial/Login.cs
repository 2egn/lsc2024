using System.Data.SqlClient;

namespace _2024Trial
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Form2 form2 = new Form2();
            form2.Show();
        }

        static string server = "127.0.0.1";
        static string database = "UserManagementDB";
        static string userid = "sa";
        static string userpw = "test1234";
        string connectString = $"Server={server};Database={database};Uid={userid};Pwd={userpw};";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var inputId = IDBox.Text.ToString();
            var inputPw = PWBox.Text.ToString();
            bool AccountExistance = false;
            bool isPasswordCorrect = false;
            var usernickname = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    AccountExistance = new SqlCommand($"SELECT * FROM dbo.[User] WHERE [uid]='{inputId}'",conn).ExecuteReader().Read();
                    conn.Close();
                    conn.Open();
                    SqlDataReader dr = new SqlCommand($"SELECT userName FROM dbo.[User] WHERE [uid]='{inputId}' AND [pwd] = '{inputPw}'", conn).ExecuteReader();
                    if (dr.Read())
                    {
                        usernickname = dr.GetString(0);
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
                MessageBox.Show($"{usernickname} ȸ���� ȯ���մϴ�.", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
