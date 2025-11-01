namespace Libaray_Management_System
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            stdName = new GroupBox();
            stdN = new TextBox();
            groupBox2 = new GroupBox();
            stdS = new TextBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            stdDep = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            std_save = new Button();
            panel1.SuspendLayout();
            stdName.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1212, 137);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8F, FontStyle.Bold);
            label1.Location = new Point(503, 38);
            label1.Name = "label1";
            label1.Size = new Size(277, 59);
            label1.TabIndex = 0;
            label1.Text = "Return Book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(140, 171);
            label2.Name = "label2";
            label2.Size = new Size(128, 31);
            label2.TabIndex = 25;
            label2.Text = "Student ID";
            // 
            // stdName
            // 
            stdName.Controls.Add(stdN);
            stdName.Font = new Font("Segoe UI", 12F);
            stdName.Location = new Point(140, 215);
            stdName.Name = "stdName";
            stdName.Size = new Size(393, 76);
            stdName.TabIndex = 26;
            stdName.TabStop = false;
            // 
            // stdN
            // 
            stdN.BackColor = Color.FromArgb(64, 64, 64);
            stdN.BorderStyle = BorderStyle.None;
            stdN.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stdN.Location = new Point(6, 26);
            stdN.Name = "stdN";
            stdN.Size = new Size(354, 31);
            stdN.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(stdS);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(140, 366);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 78);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            // 
            // stdS
            // 
            stdS.BackColor = Color.FromArgb(64, 64, 64);
            stdS.BorderStyle = BorderStyle.None;
            stdS.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stdS.Location = new Point(6, 33);
            stdS.Name = "stdS";
            stdS.Size = new Size(354, 31);
            stdS.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(140, 313);
            label4.Name = "label4";
            label4.Size = new Size(139, 31);
            label4.TabIndex = 33;
            label4.Text = "Book Name";
            label4.Click += label4_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(stdDep);
            groupBox3.Font = new Font("Segoe UI", 12F);
            groupBox3.Location = new Point(140, 510);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(393, 77);
            groupBox3.TabIndex = 36;
            groupBox3.TabStop = false;
            // 
            // stdDep
            // 
            stdDep.BackColor = Color.FromArgb(64, 64, 64);
            stdDep.BorderStyle = BorderStyle.None;
            stdDep.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stdDep.Location = new Point(19, 33);
            stdDep.Name = "stdDep";
            stdDep.Size = new Size(354, 31);
            stdDep.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(140, 476);
            label5.Name = "label5";
            label5.Size = new Size(159, 31);
            label5.TabIndex = 35;
            label5.Text = "Author Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(619, 211);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 406);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // std_save
            // 
            std_save.BackColor = Color.Teal;
            std_save.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            std_save.Location = new Point(206, 622);
            std_save.Name = "std_save";
            std_save.Size = new Size(265, 61);
            std_save.TabIndex = 38;
            std_save.Text = "Return Book";
            std_save.UseVisualStyleBackColor = false;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(std_save);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox3);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(stdName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "UserControl2";
            Size = new Size(1050, 742);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            stdName.ResumeLayout(false);
            stdName.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private GroupBox stdName;
        private TextBox stdN;
        private GroupBox groupBox2;
        private TextBox stdS;
        private Label label4;
        private GroupBox groupBox3;
        private TextBox stdDep;
        private Label label5;
        private PictureBox pictureBox1;
        private Button std_save;
    }
}
