namespace _2024Trial
{
    partial class AccountEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountEdit));
            label1 = new Label();
            userIDLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            NameTextBox = new TextBox();
            PWTextBox = new TextBox();
            PWCheckTextBox = new TextBox();
            NickNameTextBox = new TextBox();
            BirthDayBox = new DateTimePicker();
            SaveButton = new Button();
            CancelButton = new Button();
            NameWarning = new PictureBox();
            PWWarning = new PictureBox();
            PWCheckWarning = new PictureBox();
            NickNameWarning = new PictureBox();
            BirthDayWarning = new PictureBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)NameWarning).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PWWarning).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PWCheckWarning).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NickNameWarning).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BirthDayWarning).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(113, 58);
            label1.Name = "label1";
            label1.Size = new Size(134, 37);
            label1.TabIndex = 0;
            label1.Text = "계정 수정";
            // 
            // userIDLabel
            // 
            userIDLabel.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            userIDLabel.Location = new Point(43, 21);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new Size(300, 37);
            userIDLabel.TabIndex = 1;
            userIDLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 134);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "이름";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 161);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 188);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 4;
            label4.Text = "Password 확인";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 215);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 5;
            label5.Text = "닉네임";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 242);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 6;
            label6.Text = "생년월일";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(113, 131);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(189, 23);
            NameTextBox.TabIndex = 7;
            // 
            // PWTextBox
            // 
            PWTextBox.Location = new Point(113, 158);
            PWTextBox.Name = "PWTextBox";
            PWTextBox.Size = new Size(189, 23);
            PWTextBox.TabIndex = 8;
            // 
            // PWCheckTextBox
            // 
            PWCheckTextBox.Location = new Point(113, 185);
            PWCheckTextBox.Name = "PWCheckTextBox";
            PWCheckTextBox.Size = new Size(189, 23);
            PWCheckTextBox.TabIndex = 9;
            // 
            // NickNameTextBox
            // 
            NickNameTextBox.Location = new Point(113, 212);
            NickNameTextBox.Name = "NickNameTextBox";
            NickNameTextBox.Size = new Size(189, 23);
            NickNameTextBox.TabIndex = 10;
            // 
            // BirthDayBox
            // 
            BirthDayBox.Location = new Point(113, 241);
            BirthDayBox.Name = "BirthDayBox";
            BirthDayBox.Size = new Size(189, 23);
            BirthDayBox.TabIndex = 11;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Cyan;
            SaveButton.Location = new Point(76, 284);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(86, 42);
            SaveButton.TabIndex = 12;
            SaveButton.Text = "저장";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.IndianRed;
            CancelButton.Location = new Point(216, 284);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(86, 42);
            CancelButton.TabIndex = 13;
            CancelButton.Text = "취소";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // NameWarning
            // 
            NameWarning.Image = (Image)resources.GetObject("NameWarning.Image");
            NameWarning.Location = new Point(308, 134);
            NameWarning.Name = "NameWarning";
            NameWarning.Size = new Size(18, 15);
            NameWarning.TabIndex = 14;
            NameWarning.TabStop = false;
            NameWarning.Visible = false;
            NameWarning.MouseHover += NameWarning_MouseHover_1;
            // 
            // PWWarning
            // 
            PWWarning.Image = (Image)resources.GetObject("PWWarning.Image");
            PWWarning.Location = new Point(308, 158);
            PWWarning.Name = "PWWarning";
            PWWarning.Size = new Size(18, 15);
            PWWarning.TabIndex = 15;
            PWWarning.TabStop = false;
            PWWarning.Visible = false;
            PWWarning.MouseHover += NameWarning_MouseHover_1;
            // 
            // PWCheckWarning
            // 
            PWCheckWarning.Image = (Image)resources.GetObject("PWCheckWarning.Image");
            PWCheckWarning.Location = new Point(308, 188);
            PWCheckWarning.Name = "PWCheckWarning";
            PWCheckWarning.Size = new Size(18, 15);
            PWCheckWarning.TabIndex = 16;
            PWCheckWarning.TabStop = false;
            PWCheckWarning.Visible = false;
            PWCheckWarning.MouseHover += NameWarning_MouseHover_1;
            // 
            // NickNameWarning
            // 
            NickNameWarning.Image = (Image)resources.GetObject("NickNameWarning.Image");
            NickNameWarning.Location = new Point(308, 215);
            NickNameWarning.Name = "NickNameWarning";
            NickNameWarning.Size = new Size(18, 15);
            NickNameWarning.TabIndex = 17;
            NickNameWarning.TabStop = false;
            NickNameWarning.Visible = false;
            NickNameWarning.MouseHover += NameWarning_MouseHover_1;
            // 
            // BirthDayWarning
            // 
            BirthDayWarning.Image = (Image)resources.GetObject("BirthDayWarning.Image");
            BirthDayWarning.Location = new Point(308, 242);
            BirthDayWarning.Name = "BirthDayWarning";
            BirthDayWarning.Size = new Size(18, 15);
            BirthDayWarning.TabIndex = 18;
            BirthDayWarning.TabStop = false;
            BirthDayWarning.Visible = false;
            BirthDayWarning.MouseHover += NameWarning_MouseHover_1;
            // 
            // AccountEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 345);
            Controls.Add(BirthDayWarning);
            Controls.Add(NickNameWarning);
            Controls.Add(PWCheckWarning);
            Controls.Add(PWWarning);
            Controls.Add(NameWarning);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(BirthDayBox);
            Controls.Add(NickNameTextBox);
            Controls.Add(PWCheckTextBox);
            Controls.Add(PWTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(userIDLabel);
            Controls.Add(label1);
            Name = "AccountEdit";
            Text = "계정 수정";
            ((System.ComponentModel.ISupportInitialize)NameWarning).EndInit();
            ((System.ComponentModel.ISupportInitialize)PWWarning).EndInit();
            ((System.ComponentModel.ISupportInitialize)PWCheckWarning).EndInit();
            ((System.ComponentModel.ISupportInitialize)NickNameWarning).EndInit();
            ((System.ComponentModel.ISupportInitialize)BirthDayWarning).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label userIDLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox NameTextBox;
        private TextBox PWTextBox;
        private TextBox PWCheckTextBox;
        private TextBox NickNameTextBox;
        private DateTimePicker BirthDayBox;
        private Button SaveButton;
        private Button CancelButton;
        private PictureBox NameWarning;
        private PictureBox PWWarning;
        private PictureBox PWCheckWarning;
        private PictureBox NickNameWarning;
        private PictureBox BirthDayWarning;
        private ToolTip toolTip1;
    }
}