namespace _2024Trial
{
    partial class Register
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            label1 = new Label();
            NameBox = new TextBox();
            label2 = new Label();
            IDBox = new TextBox();
            label3 = new Label();
            PWBox = new TextBox();
            label4 = new Label();
            PWConfirmBox = new TextBox();
            label5 = new Label();
            NicknameBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            BirthDayBox = new DateTimePicker();
            RegisterButton = new Button();
            ExitButton = new Button();
            NameWarning = new PictureBox();
            IDWarning = new PictureBox();
            PWWarning = new PictureBox();
            PWConfirmWarning = new PictureBox();
            NicknameWarning = new PictureBox();
            BirthdayWarning = new PictureBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)NameWarning).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IDWarning).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PWWarning).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PWConfirmWarning).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NicknameWarning).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BirthdayWarning).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(91, 38);
            label1.Name = "label1";
            label1.Size = new Size(191, 32);
            label1.TabIndex = 1;
            label1.Text = "HELLO, WORLD";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(123, 103);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(205, 23);
            NameBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 106);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 3;
            label2.Text = "이름 ";
            // 
            // IDBox
            // 
            IDBox.Location = new Point(123, 132);
            IDBox.Name = "IDBox";
            IDBox.Size = new Size(205, 23);
            IDBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 135);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 5;
            label3.Text = "ID";
            // 
            // PWBox
            // 
            PWBox.Location = new Point(123, 161);
            PWBox.Name = "PWBox";
            PWBox.PasswordChar = '●';
            PWBox.Size = new Size(205, 23);
            PWBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 164);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 7;
            label4.Text = "Password";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PWConfirmBox
            // 
            PWConfirmBox.Location = new Point(123, 190);
            PWConfirmBox.Name = "PWConfirmBox";
            PWConfirmBox.PasswordChar = '●';
            PWConfirmBox.Size = new Size(205, 23);
            PWConfirmBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 193);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 9;
            label5.Text = "Password 확인";
            // 
            // NicknameBox
            // 
            NicknameBox.Location = new Point(123, 219);
            NicknameBox.Name = "NicknameBox";
            NicknameBox.Size = new Size(205, 23);
            NicknameBox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 222);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 11;
            label6.Text = "닉네임";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 249);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 13;
            label7.Text = "생년월일";
            // 
            // BirthDayBox
            // 
            BirthDayBox.Location = new Point(123, 249);
            BirthDayBox.Name = "BirthDayBox";
            BirthDayBox.Size = new Size(205, 23);
            BirthDayBox.TabIndex = 14;
            BirthDayBox.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.Cyan;
            RegisterButton.Location = new Point(71, 313);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(110, 41);
            RegisterButton.TabIndex = 15;
            RegisterButton.Text = "회원가입";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += LoginButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Firebrick;
            ExitButton.Location = new Point(201, 313);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(110, 41);
            ExitButton.TabIndex = 16;
            ExitButton.Text = "취소";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // NameWarning
            // 
            NameWarning.BackColor = Color.Transparent;
            NameWarning.Image = (Image)resources.GetObject("NameWarning.Image");
            NameWarning.Location = new Point(334, 106);
            NameWarning.Name = "NameWarning";
            NameWarning.Size = new Size(24, 18);
            NameWarning.TabIndex = 17;
            NameWarning.TabStop = false;
            NameWarning.Visible = false;
            NameWarning.MouseHover += NameWarning_MouseHover;
            // 
            // IDWarning
            // 
            IDWarning.BackColor = Color.Transparent;
            IDWarning.Image = (Image)resources.GetObject("IDWarning.Image");
            IDWarning.Location = new Point(334, 135);
            IDWarning.Name = "IDWarning";
            IDWarning.Size = new Size(24, 18);
            IDWarning.TabIndex = 18;
            IDWarning.TabStop = false;
            IDWarning.Visible = false;
            IDWarning.MouseHover += NameWarning_MouseHover;
            // 
            // PWWarning
            // 
            PWWarning.BackColor = Color.Transparent;
            PWWarning.Image = (Image)resources.GetObject("PWWarning.Image");
            PWWarning.Location = new Point(334, 164);
            PWWarning.Name = "PWWarning";
            PWWarning.Size = new Size(24, 18);
            PWWarning.TabIndex = 19;
            PWWarning.TabStop = false;
            PWWarning.Visible = false;
            PWWarning.MouseHover += NameWarning_MouseHover;
            // 
            // PWConfirmWarning
            // 
            PWConfirmWarning.BackColor = Color.Transparent;
            PWConfirmWarning.Image = (Image)resources.GetObject("PWConfirmWarning.Image");
            PWConfirmWarning.Location = new Point(334, 193);
            PWConfirmWarning.Name = "PWConfirmWarning";
            PWConfirmWarning.Size = new Size(24, 18);
            PWConfirmWarning.TabIndex = 20;
            PWConfirmWarning.TabStop = false;
            PWConfirmWarning.Visible = false;
            PWConfirmWarning.MouseHover += NameWarning_MouseHover;
            // 
            // NicknameWarning
            // 
            NicknameWarning.BackColor = Color.Transparent;
            NicknameWarning.Image = (Image)resources.GetObject("NicknameWarning.Image");
            NicknameWarning.Location = new Point(334, 224);
            NicknameWarning.Name = "NicknameWarning";
            NicknameWarning.Size = new Size(24, 18);
            NicknameWarning.TabIndex = 21;
            NicknameWarning.TabStop = false;
            NicknameWarning.Visible = false;
            NicknameWarning.MouseHover += NameWarning_MouseHover;
            // 
            // BirthdayWarning
            // 
            BirthdayWarning.BackColor = Color.Transparent;
            BirthdayWarning.Image = (Image)resources.GetObject("BirthdayWarning.Image");
            BirthdayWarning.Location = new Point(334, 254);
            BirthdayWarning.Name = "BirthdayWarning";
            BirthdayWarning.Size = new Size(24, 18);
            BirthdayWarning.TabIndex = 22;
            BirthdayWarning.TabStop = false;
            BirthdayWarning.Visible = false;
            BirthdayWarning.MouseHover += NameWarning_MouseHover;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 450);
            Controls.Add(BirthdayWarning);
            Controls.Add(NicknameWarning);
            Controls.Add(PWConfirmWarning);
            Controls.Add(PWWarning);
            Controls.Add(IDWarning);
            Controls.Add(NameWarning);
            Controls.Add(ExitButton);
            Controls.Add(RegisterButton);
            Controls.Add(BirthDayBox);
            Controls.Add(label7);
            Controls.Add(NicknameBox);
            Controls.Add(label6);
            Controls.Add(PWConfirmBox);
            Controls.Add(label5);
            Controls.Add(PWBox);
            Controls.Add(label4);
            Controls.Add(IDBox);
            Controls.Add(label3);
            Controls.Add(NameBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "회원가입";
            ((System.ComponentModel.ISupportInitialize)NameWarning).EndInit();
            ((System.ComponentModel.ISupportInitialize)IDWarning).EndInit();
            ((System.ComponentModel.ISupportInitialize)PWWarning).EndInit();
            ((System.ComponentModel.ISupportInitialize)PWConfirmWarning).EndInit();
            ((System.ComponentModel.ISupportInitialize)NicknameWarning).EndInit();
            ((System.ComponentModel.ISupportInitialize)BirthdayWarning).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameBox;
        private Label label2;
        private TextBox IDBox;
        private Label label3;
        private TextBox PWBox;
        private Label label4;
        private TextBox PWConfirmBox;
        private Label label5;
        private TextBox NicknameBox;
        private Label label6;
        private Label label7;
        private DateTimePicker BirthDayBox;
        private Button RegisterButton;
        private Button ExitButton;
        private PictureBox NameWarning;
        private PictureBox IDWarning;
        private PictureBox PWWarning;
        private PictureBox PWConfirmWarning;
        private PictureBox NicknameWarning;
        private PictureBox BirthdayWarning;
        private ToolTip toolTip1;
    }
}