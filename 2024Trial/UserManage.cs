﻿using System;
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

        public UserManage()
        {
            InitializeComponent();
        }
        static string server = "127.0.0.1";
        static string database = "UserManagementDB";
        static string userid = "sa";
        static string userpw = "test1234";
        string connectString = $"Server={server};Database={database};Uid={userid};Pwd={userpw};";
        private void UserManage_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
        }
        static List<bool> adminList = new();
        static List<bool> lockList = new();
        static int selectedRow = -1;
        private void refreshDataGridView()
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
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.SkyBlue;
                }
                else if (lockList[i])
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = SystemColors.Control;
                }
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
            //왼쪽위 공백 누르면(row : -1) 에러 터져서 대비책
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
        private void dataGridVIewReset()
        {//데이터그리드 초기화
            selectedRow = 0;
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();

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
        {
            //잠금버튼
            if (selectedRow < 0)
            {
                MessageBox.Show("사용자를 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (adminList[selectedRow])
            {
                MessageBox.Show("관리자는 잠금할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!lockList[selectedRow])
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    new SqlCommand($"UPDATE dbo.[User] SET isLock = 1 WHERE idx={dataGridView1.Rows[selectedRow].Cells[0].Value}", conn).ExecuteNonQuery();
                }

                MessageBox.Show("계정 잠금이 완료됐습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
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
        {
            if(e.Button == MouseButtons.Right)
            {

            }
        }
    }
}
