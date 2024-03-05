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
    public partial class Register : Form
    {
        static string server = "127.0.0.1";
        static string database = "UserManagementDB";
        static string userid = "sa";
        static string userpw = "test1234";
        string connectString = $"Server={server};Database={database};Uid={userid};Pwd={userpw};";
        public Register()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            nameValidCheck();
            IDValidCheck();
            PWValidCheck();
            NickNameValidCheck();
            DateCheck();
        }

        private bool nameValidCheck()
        {
            if (String.IsNullOrEmpty(NameBox.Text))
            {
                NameWarning.Visible = true;
                return false;
            }
            else
            {
                NameWarning.Visible = false;
                return true;
            }
        }
        private bool IDValidCheck()
        {
            IDWarning.Visible = false;
            if (String.IsNullOrEmpty(IDBox.Text))
            {
                IDWarning.Visible = true;
                return false;
            }
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                if(new SqlCommand($"SELECT * FROM dbo.[User] WHERE [uid] = '{IDBox.Text}'", conn).ExecuteReader().Read())//if id exists
                {
                    IDWarning.Visible = true;
                    return false;
                }
            }
            return true;
        }
        private bool PWValidCheck()
        {
            if (String.IsNullOrEmpty(PWBox.Text) || String.IsNullOrEmpty(PWConfirmBox.Text))
            {
                PWWarning.Visible = true;
                PWConfirmWarning.Visible = true;
                return false;
            }
            else if(PWBox.Text != PWConfirmBox.Text)
            {
                PWWarning.Visible = true;
                PWConfirmWarning.Visible = true;
                return false;
            }
            else
            {
                PWWarning.Visible = false;
                PWConfirmWarning.Visible = false;
                return true;
            }
        }
        private bool NickNameValidCheck()
        {
            NicknameWarning.Visible = false;
            if (String.IsNullOrEmpty(IDBox.Text))
            {
                NicknameWarning.Visible = true;
                return false;
            }
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                if (new SqlCommand($"SELECT * FROM dbo.[User] WHERE [nickName] = '{NicknameBox.Text}'", conn).ExecuteReader().Read())//if id exists
                {
                    NicknameWarning.Visible = true;
                    return false;
                }
            }
            return true;
        }

        private bool DateCheck()
        {
            DateTime birthday = BirthDayBox.Value;
            DateTime currentday = DateTime.Now;

            if (birthday.CompareTo(currentday) > 0)
            {
                BirthdayWarning.Visible = true;
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
