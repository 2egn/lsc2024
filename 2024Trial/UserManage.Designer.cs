namespace _2024Trial
{
    partial class UserManage
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            accountEditStrip = new ToolStripMenuItem();
            accountDeleteStrip = new ToolStripMenuItem();
            lockButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(291, 20);
            label1.Name = "label1";
            label1.Size = new Size(161, 37);
            label1.TabIndex = 0;
            label1.Text = "사용자 관리";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 78);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.Size = new Size(731, 268);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.MouseDown += dataGridView1_MouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { accountEditStrip, accountDeleteStrip });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(127, 48);
            // 
            // accountEditStrip
            // 
            accountEditStrip.Name = "accountEditStrip";
            accountEditStrip.Size = new Size(126, 22);
            accountEditStrip.Text = "계정 수정";
            accountEditStrip.Click += accountEditStrip_Click;
            // 
            // accountDeleteStrip
            // 
            accountDeleteStrip.Name = "accountDeleteStrip";
            accountDeleteStrip.Size = new Size(126, 22);
            accountDeleteStrip.Text = "계정 삭제";
            accountDeleteStrip.Click += accountDeleteStrip_Click;
            // 
            // lockButton
            // 
            lockButton.BackColor = Color.FromArgb(255, 128, 0);
            lockButton.Location = new Point(628, 352);
            lockButton.Name = "lockButton";
            lockButton.Size = new Size(115, 45);
            lockButton.TabIndex = 2;
            lockButton.Text = "계정 잠금";
            lockButton.UseVisualStyleBackColor = false;
            lockButton.Click += lockButton_Click;
            // 
            // UserManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 409);
            Controls.Add(lockButton);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "UserManage";
            Text = "사용자 관리";
            FormClosing += UserManage_FormClosing;
            Load += UserManage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button lockButton;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem accountEditStrip;
        private ToolStripMenuItem accountDeleteStrip;
    }
}