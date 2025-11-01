namespace Libaray_Management_System
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            userControl21 = new UserControl2();
            uc_StatusCheck_cs1 = new Uc_StatusCheck_cs();
            uc_issueBook1 = new Uc_issueBook();
            uc_StdReg1 = new Uc_StdReg();
            label1 = new Label();
            panel2 = new Panel();
            Dashboard = new Label();
            button5 = new Button();
            btn_returnBook = new Button();
            btn_checkStatus = new Button();
            btn_issueBook = new Button();
            btn_stdReg = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(userControl21);
            panel1.Controls.Add(uc_StatusCheck_cs1);
            panel1.Controls.Add(uc_issueBook1);
            panel1.Controls.Add(uc_StdReg1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(228, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 775);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // userControl21
            // 
            userControl21.BackColor = Color.FromArgb(64, 64, 64);
            userControl21.Location = new Point(3, 3);
            userControl21.Name = "userControl21";
            userControl21.Size = new Size(1113, 775);
            userControl21.TabIndex = 4;
            // 
            // uc_StatusCheck_cs1
            // 
            uc_StatusCheck_cs1.BackColor = Color.FromArgb(64, 64, 64);
            uc_StatusCheck_cs1.Location = new Point(3, 3);
            uc_StatusCheck_cs1.Name = "uc_StatusCheck_cs1";
            uc_StatusCheck_cs1.Size = new Size(1113, 775);
            uc_StatusCheck_cs1.TabIndex = 3;
            // 
            // uc_issueBook1
            // 
            uc_issueBook1.BackColor = Color.FromArgb(64, 64, 64);
            uc_issueBook1.Location = new Point(0, 0);
            uc_issueBook1.Name = "uc_issueBook1";
            uc_issueBook1.Size = new Size(1113, 775);
            uc_issueBook1.TabIndex = 2;
            // 
            // uc_StdReg1
            // 
            uc_StdReg1.BackColor = Color.FromArgb(64, 64, 64);
            uc_StdReg1.Location = new Point(0, 0);
            uc_StdReg1.Name = "uc_StdReg1";
            uc_StdReg1.Size = new Size(1113, 775);
            uc_StdReg1.TabIndex = 1;
            uc_StdReg1.Load += uc_StdReg1_Load;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8F, FontStyle.Bold);
            label1.Location = new Point(226, 9);
            label1.Name = "label1";
            label1.Size = new Size(608, 59);
            label1.TabIndex = 0;
            label1.Text = "Libaray Management System";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(Dashboard);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(btn_returnBook);
            panel2.Controls.Add(btn_checkStatus);
            panel2.Controls.Add(btn_issueBook);
            panel2.Controls.Add(btn_stdReg);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 775);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // Dashboard
            // 
            Dashboard.AutoSize = true;
            Dashboard.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            Dashboard.Location = new Point(30, 213);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(160, 38);
            Dashboard.TabIndex = 7;
            Dashboard.Text = "DashBoard";
            // 
            // button5
            // 
            button5.BackColor = Color.Teal;
            button5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(30, 633);
            button5.Name = "button5";
            button5.Size = new Size(162, 64);
            button5.TabIndex = 6;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // btn_returnBook
            // 
            btn_returnBook.BackColor = Color.Teal;
            btn_returnBook.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_returnBook.ForeColor = SystemColors.ActiveCaptionText;
            btn_returnBook.Location = new Point(30, 541);
            btn_returnBook.Name = "btn_returnBook";
            btn_returnBook.Size = new Size(171, 64);
            btn_returnBook.TabIndex = 5;
            btn_returnBook.Text = "Returan Book";
            btn_returnBook.UseVisualStyleBackColor = false;
            btn_returnBook.Click += btn_returnBook_Click;
            // 
            // btn_checkStatus
            // 
            btn_checkStatus.BackColor = Color.Teal;
            btn_checkStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_checkStatus.ForeColor = SystemColors.ActiveCaptionText;
            btn_checkStatus.Location = new Point(30, 451);
            btn_checkStatus.Name = "btn_checkStatus";
            btn_checkStatus.Size = new Size(162, 64);
            btn_checkStatus.TabIndex = 4;
            btn_checkStatus.Text = "Check Status";
            btn_checkStatus.UseVisualStyleBackColor = false;
            btn_checkStatus.Click += btn_checkStatus_Click;
            // 
            // btn_issueBook
            // 
            btn_issueBook.BackColor = Color.Teal;
            btn_issueBook.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_issueBook.ForeColor = SystemColors.ActiveCaptionText;
            btn_issueBook.Location = new Point(30, 366);
            btn_issueBook.Name = "btn_issueBook";
            btn_issueBook.Size = new Size(162, 64);
            btn_issueBook.TabIndex = 3;
            btn_issueBook.Text = "Issue Book";
            btn_issueBook.UseVisualStyleBackColor = false;
            btn_issueBook.Click += btn_issueBook_Click;
            // 
            // btn_stdReg
            // 
            btn_stdReg.BackColor = Color.Teal;
            btn_stdReg.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_stdReg.ForeColor = SystemColors.ActiveCaptionText;
            btn_stdReg.Location = new Point(30, 275);
            btn_stdReg.Name = "btn_stdReg";
            btn_stdReg.Size = new Size(162, 64);
            btn_stdReg.TabIndex = 2;
            btn_stdReg.Text = "Student Reg";
            btn_stdReg.UseVisualStyleBackColor = false;
            btn_stdReg.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1343, 775);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_stdReg;
        private Label Dashboard;
        private Button button5;
        private Button btn_returnBook;
        private Button btn_checkStatus;
        private Button btn_issueBook;
        private Uc_StdReg uc_StdReg1;
        private UserControl2 userControl21;
        private Uc_StatusCheck_cs uc_StatusCheck_cs1;
        private Uc_issueBook uc_issueBook1;
    }
}