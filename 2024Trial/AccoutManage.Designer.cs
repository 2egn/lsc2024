namespace _2024Trial
{
    partial class AccoutManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccoutManage));
            MainPicBox = new PictureBox();
            label1 = new Label();
            IDBox = new TextBox();
            NameBox = new TextBox();
            label2 = new Label();
            NickNameBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            DateBox = new DateTimePicker();
            SaveButton = new Button();
            dataGridView1 = new DataGridView();
            MainPicButton = new Button();
            AddButton = new Button();
            DeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)MainPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // MainPicBox
            // 
            MainPicBox.Image = (Image)resources.GetObject("MainPicBox.Image");
            MainPicBox.Location = new Point(12, 12);
            MainPicBox.Name = "MainPicBox";
            MainPicBox.Size = new Size(185, 171);
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
            // IDBox
            // 
            IDBox.Location = new Point(12, 210);
            IDBox.Name = "IDBox";
            IDBox.ReadOnly = true;
            IDBox.Size = new Size(185, 23);
            IDBox.TabIndex = 2;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(12, 261);
            NameBox.Name = "NameBox";
            NameBox.ReadOnly = true;
            NameBox.Size = new Size(185, 23);
            NameBox.TabIndex = 4;
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
            // NickNameBox
            // 
            NickNameBox.Location = new Point(12, 313);
            NickNameBox.Name = "NickNameBox";
            NickNameBox.ReadOnly = true;
            NickNameBox.Size = new Size(185, 23);
            NickNameBox.TabIndex = 6;
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
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(214, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(313, 375);
            dataGridView1.TabIndex = 10;
            // 
            // MainPicButton
            // 
            MainPicButton.BackColor = Color.SkyBlue;
            MainPicButton.Location = new Point(214, 393);
            MainPicButton.Name = "MainPicButton";
            MainPicButton.Size = new Size(98, 38);
            MainPicButton.TabIndex = 11;
            MainPicButton.Text = "대표사진 지정";
            MainPicButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.SkyBlue;
            AddButton.Location = new Point(318, 393);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(98, 38);
            AddButton.TabIndex = 12;
            AddButton.Text = "추가";
            AddButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.Red;
            DeleteButton.Location = new Point(421, 393);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(98, 38);
            DeleteButton.TabIndex = 13;
            DeleteButton.Text = "삭제";
            DeleteButton.UseVisualStyleBackColor = false;
            // 
            // AccoutManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 452);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(MainPicButton);
            Controls.Add(dataGridView1);
            Controls.Add(SaveButton);
            Controls.Add(DateBox);
            Controls.Add(label4);
            Controls.Add(NickNameBox);
            Controls.Add(label3);
            Controls.Add(NameBox);
            Controls.Add(label2);
            Controls.Add(IDBox);
            Controls.Add(label1);
            Controls.Add(MainPicBox);
            Name = "AccoutManage";
            Text = "계정 관리";
            ((System.ComponentModel.ISupportInitialize)MainPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox MainPicBox;
        private Label label1;
        private TextBox IDBox;
        private TextBox NameBox;
        private Label label2;
        private TextBox NickNameBox;
        private Label label3;
        private Label label4;
        private DateTimePicker DateBox;
        private Button SaveButton;
        private DataGridView dataGridView1;
        private Button MainPicButton;
        private Button AddButton;
        private Button DeleteButton;
    }
}