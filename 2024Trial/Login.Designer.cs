namespace _2024Trial
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            IDBox = new TextBox();
            PWBox = new TextBox();
            label3 = new Label();
            SaveIDCheckBox = new CheckBox();
            LoginButton = new Button();
            ExitButton = new Button();
            RegiRedirectLink = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(95, 25);
            label1.Name = "label1";
            label1.Size = new Size(191, 32);
            label1.TabIndex = 0;
            label1.Text = "HELLO, WORLD";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 106);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "ID : ";
            // 
            // IDBox
            // 
            IDBox.Location = new Point(95, 103);
            IDBox.Name = "IDBox";
            IDBox.Size = new Size(205, 23);
            IDBox.TabIndex = 2;
            IDBox.TextChanged += IDBox_TextChanged;
            // 
            // PWBox
            // 
            PWBox.Location = new Point(95, 143);
            PWBox.Name = "PWBox";
            PWBox.PasswordChar = '●';
            PWBox.Size = new Size(205, 23);
            PWBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 146);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "PW : ";
            // 
            // SaveIDCheckBox
            // 
            SaveIDCheckBox.AutoSize = true;
            SaveIDCheckBox.Location = new Point(216, 181);
            SaveIDCheckBox.Name = "SaveIDCheckBox";
            SaveIDCheckBox.Size = new Size(90, 19);
            SaveIDCheckBox.TabIndex = 5;
            SaveIDCheckBox.Text = "아이디 저장";
            SaveIDCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Cyan;
            LoginButton.Location = new Point(59, 217);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(110, 41);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "로그인";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Firebrick;
            ExitButton.Location = new Point(196, 217);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(110, 41);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "종료";
            ExitButton.UseVisualStyleBackColor = false;
            // 
            // RegiRedirectLink
            // 
            RegiRedirectLink.AutoSize = true;
            RegiRedirectLink.Location = new Point(118, 289);
            RegiRedirectLink.Name = "RegiRedirectLink";
            RegiRedirectLink.Size = new Size(141, 15);
            RegiRedirectLink.TabIndex = 8;
            RegiRedirectLink.TabStop = true;
            RegiRedirectLink.Text = "아직 회원이 아니신가요?";
            RegiRedirectLink.LinkClicked += RegiRedirectLink_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 333);
            Controls.Add(RegiRedirectLink);
            Controls.Add(ExitButton);
            Controls.Add(LoginButton);
            Controls.Add(SaveIDCheckBox);
            Controls.Add(PWBox);
            Controls.Add(label3);
            Controls.Add(IDBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "로그인";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox IDBox;
        private TextBox PWBox;
        private Label label3;
        private CheckBox SaveIDCheckBox;
        private Button LoginButton;
        private Button ExitButton;
        private LinkLabel RegiRedirectLink;
    }
}
