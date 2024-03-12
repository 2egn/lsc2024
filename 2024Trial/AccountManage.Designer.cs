namespace _2024Trial
{
    partial class AccountManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainPicBox = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DateBox = new DateTimePicker();
            SaveButton = new Button();
            dataGridView1 = new DataGridView();
            colnum = new DataGridViewTextBoxColumn();
            ColImg = new DataGridViewImageColumn();
            MainPicButton = new Button();
            AddButton = new Button();
            DeleteButton = new Button();
            IDBox = new TextBox();
            NameBox = new TextBox();
            NickNameBox = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)MainPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // MainPicBox
            // 
            MainPicBox.BorderStyle = BorderStyle.FixedSingle;
            MainPicBox.Location = new Point(12, 12);
            MainPicBox.Name = "MainPicBox";
            MainPicBox.Size = new Size(185, 153);
            MainPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            MainPicBox.TabIndex = 0;
            MainPicBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(12, 186);
            label1.Name = "label1";
            label1.Size = new Size(25, 21);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(12, 237);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 3;
            label2.Text = "사용자 이름";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label3.Location = new Point(12, 289);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 5;
            label3.Text = "닉네임";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label4.Location = new Point(12, 340);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 7;
            label4.Text = "생년월일";
            // 
            // DateBox
            // 
            DateBox.Location = new Point(12, 364);
            DateBox.Name = "DateBox";
            DateBox.Size = new Size(185, 23);
            DateBox.TabIndex = 8;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.SkyBlue;
            SaveButton.Location = new Point(12, 405);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(185, 38);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "저장";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colnum, ColImg });
            dataGridView1.Location = new Point(214, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 75;
            dataGridView1.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(337, 375);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // colnum
            // 
            colnum.HeaderText = "No";
            colnum.Name = "colnum";
            colnum.ReadOnly = true;
            colnum.SortMode = DataGridViewColumnSortMode.NotSortable;
            colnum.Width = 150;
            // 
            // ColImg
            // 
            ColImg.HeaderText = "이미지";
            ColImg.Name = "ColImg";
            ColImg.ReadOnly = true;
            ColImg.Resizable = DataGridViewTriState.True;
            ColImg.Width = 150;
            // 
            // MainPicButton
            // 
            MainPicButton.BackColor = Color.SkyBlue;
            MainPicButton.Location = new Point(214, 393);
            MainPicButton.Name = "MainPicButton";
            MainPicButton.Size = new Size(109, 38);
            MainPicButton.TabIndex = 11;
            MainPicButton.Text = "대표사진 지정";
            MainPicButton.UseVisualStyleBackColor = false;
            MainPicButton.Click += MainPicButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.SkyBlue;
            AddButton.Location = new Point(329, 393);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(108, 38);
            AddButton.TabIndex = 12;
            AddButton.Text = "추가";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.Red;
            DeleteButton.Location = new Point(443, 393);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(108, 38);
            DeleteButton.TabIndex = 13;
            DeleteButton.Text = "삭제";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // IDBox
            // 
            IDBox.Location = new Point(12, 210);
            IDBox.Name = "IDBox";
            IDBox.ReadOnly = true;
            IDBox.Size = new Size(185, 23);
            IDBox.TabIndex = 14;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(12, 263);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(185, 23);
            NameBox.TabIndex = 15;
            // 
            // NickNameBox
            // 
            NickNameBox.Location = new Point(12, 314);
            NickNameBox.Name = "NickNameBox";
            NickNameBox.Size = new Size(185, 23);
            NickNameBox.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // AccountManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 452);
            Controls.Add(NickNameBox);
            Controls.Add(NameBox);
            Controls.Add(IDBox);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(MainPicButton);
            Controls.Add(dataGridView1);
            Controls.Add(SaveButton);
            Controls.Add(DateBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MainPicBox);
            Name = "AccountManage";
            Text = "계정 관리";
            FormClosing += AccountManage_FormClosing;
            Load += AccountManage_Load;
            ((System.ComponentModel.ISupportInitialize)MainPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox MainPicBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker DateBox;
        private Button SaveButton;
        private DataGridView dataGridView1;
        private Button MainPicButton;
        private Button AddButton;
        private Button DeleteButton;
        private TextBox IDBox;
        private TextBox NameBox;
        private TextBox NickNameBox;
        private OpenFileDialog openFileDialog1;
        private DataGridViewTextBoxColumn colnum;
        private DataGridViewImageColumn ColImg;
    }
}