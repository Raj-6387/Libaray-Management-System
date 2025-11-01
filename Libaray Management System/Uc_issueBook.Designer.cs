namespace Libaray_Management_System
{
    partial class Uc_issueBook
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
            panel1 = new Panel();
            label1 = new Label();
            std_save = new Button();
            groupBox4 = new GroupBox();
            stdContent = new TextBox();
            groupBox3 = new GroupBox();
            stdDep = new TextBox();
            groupBox2 = new GroupBox();
            stdS = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            stdId = new TextBox();
            label3 = new Label();
            stdName = new GroupBox();
            stdN = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            stdName.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1212, 137);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8F, FontStyle.Bold);
            label1.Location = new Point(501, 35);
            label1.Name = "label1";
            label1.Size = new Size(242, 59);
            label1.TabIndex = 0;
            label1.Text = "Issue Book";
            // 
            // std_save
            // 
            std_save.BackColor = Color.Teal;
            std_save.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            std_save.Location = new Point(561, 634);
            std_save.Name = "std_save";
            std_save.Size = new Size(265, 61);
            std_save.TabIndex = 23;
            std_save.Text = "Issue Book";
            std_save.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(stdContent);
            groupBox4.Font = new Font("Segoe UI", 12F);
            groupBox4.Location = new Point(504, 538);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(393, 75);
            groupBox4.TabIndex = 22;
            groupBox4.TabStop = false;
            // 
            // stdContent
            // 
            stdContent.BackColor = Color.FromArgb(64, 64, 64);
            stdContent.BorderStyle = BorderStyle.None;
            stdContent.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stdContent.Location = new Point(19, 33);
            stdContent.Name = "stdContent";
            stdContent.Size = new Size(354, 31);
            stdContent.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(stdDep);
            groupBox3.Font = new Font("Segoe UI", 12F);
            groupBox3.Location = new Point(504, 442);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(393, 77);
            groupBox3.TabIndex = 21;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(stdS);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(504, 344);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 78);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            // 
            // stdS
            // 
            stdS.BackColor = Color.FromArgb(64, 64, 64);
            stdS.BorderStyle = BorderStyle.None;
            stdS.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stdS.Location = new Point(19, 33);
            stdS.Name = "stdS";
            stdS.Size = new Size(354, 31);
            stdS.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(317, 556);
            label6.Name = "label6";
            label6.Size = new Size(123, 31);
            label6.TabIndex = 19;
            label6.Text = "Issue Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(317, 462);
            label5.Name = "label5";
            label5.Size = new Size(159, 31);
            label5.TabIndex = 18;
            label5.Text = "Author Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(317, 367);
            label4.Name = "label4";
            label4.Size = new Size(139, 31);
            label4.TabIndex = 17;
            label4.Text = "Book Name";
            label4.Click += label4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(stdId);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(504, 252);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(393, 76);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // stdId
            // 
            stdId.BackColor = Color.FromArgb(64, 64, 64);
            stdId.BorderStyle = BorderStyle.None;
            stdId.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stdId.Location = new Point(19, 33);
            stdId.Name = "stdId";
            stdId.Size = new Size(354, 31);
            stdId.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(317, 276);
            label3.Name = "label3";
            label3.Size = new Size(128, 31);
            label3.TabIndex = 15;
            label3.Text = "Student ID";
            // 
            // stdName
            // 
            stdName.Controls.Add(stdN);
            stdName.Font = new Font("Segoe UI", 12F);
            stdName.Location = new Point(504, 156);
            stdName.Name = "stdName";
            stdName.Size = new Size(393, 76);
            stdName.TabIndex = 14;
            stdName.TabStop = false;
            // 
            // stdN
            // 
            stdN.BackColor = Color.FromArgb(64, 64, 64);
            stdN.BorderStyle = BorderStyle.None;
            stdN.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stdN.Location = new Point(19, 26);
            stdN.Name = "stdN";
            stdN.Size = new Size(354, 31);
            stdN.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(317, 182);
            label2.Name = "label2";
            label2.Size = new Size(167, 31);
            label2.TabIndex = 13;
            label2.Text = "Student Name";
            // 
            // Uc_issueBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(std_save);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(stdName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Uc_issueBook";
            Size = new Size(1215, 709);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            stdName.ResumeLayout(false);
            stdName.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button std_save;
        private GroupBox groupBox4;
        private TextBox stdContent;
        private GroupBox groupBox3;
        private TextBox stdDep;
        private GroupBox groupBox2;
        private TextBox stdS;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox stdId;
        private Label label3;
        private GroupBox stdName;
        private TextBox stdN;
        private Label label2;
    }
}
