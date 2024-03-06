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
        Form parentform = null;
        public Register(Form parentForm)
        {
            InitializeComponent();
            parentform = parentForm;
        }

        string namewarnstring;
        string idwarnstring;
        string pwwarnstring;
        string pwconfirmwarnstring;
        string nickwarnstring;
        string birthdaywarnstring;


        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (nameValidCheck() & IDValidCheck() & PWValidCheck() & NickNameValidCheck() & DateCheck())
            {
                MessageBox.Show("회원가입이 완료됐습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    string formattedDate = BirthDayBox.Value.ToString("yyyy-MM-dd");
                    MessageBox.Show($"{BirthDayBox.Value.ToString()}");
                    conn.Open();
                    new SqlCommand($"INSERT INTO dbo.[User] VALUES('{NameBox.Text}', '{IDBox.Text}', '{PWBox.Text}', '{NicknameBox.Text}', '{formattedDate}' ,0,0)", conn).ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        private bool nameValidCheck()
        {
            if (String.IsNullOrEmpty(NameBox.Text))//공백체크
            {
                namewarnstring = "이름(는)은 필수로 입력하셔야 합니다";
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
            if (String.IsNullOrEmpty(IDBox.Text))//공백체크
            {
                idwarnstring = "ID(는)은 필수로 입력하셔야 합니다.";
                IDWarning.Visible = true;
                return false;
            }
            using (SqlConnection conn = new SqlConnection(connectString))//중복체크
            {
                conn.Open();
                if (new SqlCommand($"SELECT * FROM dbo.[User] WHERE [uid] = '{IDBox.Text}'", conn).ExecuteReader().Read())
                {
                    idwarnstring = "이 ID는 이미 사용 중입니다.";
                    IDWarning.Visible = true;
                    return false;
                }
            }
            return true;
        }
        private bool PWValidCheck()
        {
            if (PWBox.Text != PWConfirmBox.Text)
            {//불일치 체크
                //하나만 공백인 경우 대비
                pwwarnstring = String.IsNullOrEmpty(PWBox.Text) ? "Password(는)은 필수로 입력하셔야 합니다." : "Password와 Password 확인이 일치하지 않습니다.";
                pwconfirmwarnstring = String.IsNullOrEmpty(PWBox.Text) ? "Password 확인(는)은 필수로 입력하셔야 합니다." : "Password와 Password 확인이 일치하지 않습니다.";
                PWWarning.Visible = true;
                PWConfirmWarning.Visible = true;
                return false;
            }
            else if (String.IsNullOrEmpty(PWBox.Text))//둘 다 공백인 경우
            {
                pwwarnstring = "Password(는)은 필수로 입력하셔야 합니다.";
                pwconfirmwarnstring = "Password 확인(는)은 필수로 입력하셔야 합니다.";
                PWWarning.Visible = true;
                PWConfirmWarning.Visible = true;
                return false;
            }
            PWWarning.Visible = false;
            PWConfirmWarning.Visible = false;
            return true;

        }
        private bool NickNameValidCheck()
        {
            NicknameWarning.Visible = false;
            if (String.IsNullOrEmpty(NicknameBox.Text))//공백
            {
                nickwarnstring = "닉네임(는)은 필수로 입력하셔야 합니다.";
                NicknameWarning.Visible = true;
                return false;
            }
            using (SqlConnection conn = new SqlConnection(connectString))//닉중복체크
            {

                conn.Open();
                if (new SqlCommand($"SELECT * FROM dbo.[User] WHERE [nickName] = '{NicknameBox.Text}'", conn).ExecuteReader().Read())
                {
                    nickwarnstring = "이 닉네임은 이미 사용 중입니다.";
                    NicknameWarning.Visible = true;
                    return false;
                }
            }
            return true;
        }

        private bool DateCheck()
        {
            /* 생년월일 체크.
               오늘을 초과하는 날짜를 입력받으면 경고메세지.*/
            DateTime birthday = BirthDayBox.Value;
            DateTime currentday = DateTime.Now;

            if (birthday.CompareTo(currentday) > 0)
            {
                birthdaywarnstring = "생년월일은 오늘 날짜보다 클 수 없습니다.";
                BirthdayWarning.Visible = true;
                return false;
            }
            else
            {
                return true;
            }
        }

        private void NameWarning_MouseHover(object sender, EventArgs e)
        {//마우스 호버시에 툴팁보여주기
            this.toolTip1.SetToolTip(this.NameWarning, namewarnstring);
            this.toolTip1.SetToolTip(this.IDWarning, idwarnstring);
            this.toolTip1.SetToolTip(this.PWWarning, pwwarnstring);
            this.toolTip1.SetToolTip(this.PWConfirmWarning, pwconfirmwarnstring);
            this.toolTip1.SetToolTip(this.NicknameWarning, nickwarnstring);
            this.toolTip1.SetToolTip(this.BirthdayWarning, birthdaywarnstring);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            parentform.Visible = true;//need to be fixed
        }
    }
}
