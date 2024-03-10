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

namespace _2024Trial
{
    public partial class AccountEdit : Form
    {
        static string server = "127.0.0.1";
        static string database = "UserManagementDB";
        static string userid = "sa";
        static string userpw = "test1234";
        string connectString = $"Server={server};Database={database};Uid={userid};Pwd={userpw};";

        string UID = "";
        int IDX;
        UserManage ParentForm;
        public AccountEdit(int idx, string uid, DateTime date,UserManage parentForm)
        {
            InitializeComponent();
            userIDLabel.Text = uid;
            BirthDayBox.Value = date;
            ParentForm = parentForm;
            IDX = idx;
        }
        private string? namewarnstring;
        private string? pwwarnstring;
        private string? pwcheckstring;
        private string? nickwarnstring;
        private string? birthdaywarnstring;




        private bool nameValidCheck()
        {
            if (String.IsNullOrEmpty(NameTextBox.Text))//공백체크
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

        private bool PWValidCheck()
        {
            if (PWTextBox.Text != PWCheckTextBox.Text)
            {//불일치 체크
                //하나만 공백인 경우 대비
                pwwarnstring = String.IsNullOrEmpty(PWTextBox.Text) ? "Password(는)은 필수로 입력하셔야 합니다." : "Password와 Password 확인이 일치하지 않습니다.";
                pwcheckstring = String.IsNullOrEmpty(PWTextBox.Text) ? "Password 확인(는)은 필수로 입력하셔야 합니다." : "Password와 Password 확인이 일치하지 않습니다.";
                PWWarning.Visible = true;
                PWCheckWarning.Visible = true;
                return false;
            }
            else if (String.IsNullOrEmpty(PWTextBox.Text))//둘 다 공백인 경우
            {
                pwwarnstring = "Password(는)은 필수로 입력하셔야 합니다.";
                pwcheckstring = "Password 확인(는)은 필수로 입력하셔야 합니다.";
                PWWarning.Visible = true;
                PWCheckWarning.Visible = true;
                return false;
            }
            PWWarning.Visible = false;
            PWCheckWarning.Visible = false;
            return true;
        }
        private bool NickNameValidCheck()
        {
            NickNameWarning.Visible = false;
            if (String.IsNullOrEmpty(NickNameTextBox.Text))//공백
            {
                nickwarnstring = "닉네임(는)은 필수로 입력하셔야 합니다.";
                NickNameWarning.Visible = true;
                return false;
            }
            using (SqlConnection conn = new SqlConnection(connectString))//닉중복체크
            {

                conn.Open();
                if (new SqlCommand($"SELECT * FROM dbo.[User] WHERE [nickName] = '{NickNameTextBox.Text}'", conn).ExecuteReader().Read())
                {
                    nickwarnstring = "이 닉네임은 이미 사용 중입니다.";
                    NickNameWarning.Visible = true;
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
                BirthDayWarning.Visible = true;
                return false;
            }
            else
            {
                return true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (nameValidCheck() & PWValidCheck() & NickNameValidCheck() & DateCheck())
            {
                //계정정보 업데이트
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    new SqlCommand($"UPDATE dbo.[User] SET userName = '{NameTextBox.Text}', pwd = '{PWTextBox.Text}', nickName = '{NickNameTextBox.Text}', dob = '{BirthDayBox.Value.ToString("yyyy-MM-dd")}' WHERE idx = {IDX}",conn).ExecuteNonQuery();
                }
                MessageBox.Show("계정 수정이 완료되었습니다.");
                //데이터그리드뷰 새로고침
                ParentForm.dataGridVIewReset();
                ParentForm.refreshDataGridView();
                ParentForm.Visible = true;
                //현재 폼 종류
                this.Dispose();
            }
            else
            {
                MessageBox.Show("입력 형식이 올바르지 않습니다. 확인 후 다시 입력해주세요.","경고",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ParentForm.Visible = true;
        }

        private void NameWarning_MouseHover_1(object sender, EventArgs e)
        {//툴팁생성
            this.toolTip1.SetToolTip(this.NameWarning, namewarnstring);
            this.toolTip1.SetToolTip(this.PWWarning, pwwarnstring);
            this.toolTip1.SetToolTip(this.PWCheckWarning, pwcheckstring);
            this.toolTip1.SetToolTip(this.NickNameWarning, nickwarnstring);
            this.toolTip1.SetToolTip(this.BirthDayWarning, birthdaywarnstring);
        }
    }
}
