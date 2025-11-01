using System;
using System.Drawing;
using System.Windows.Forms;

namespace Libaray_Management_System
{
    public partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            btn_admin = new Button();
            label2 = new Label();
            button3 = new Button();
            userControl11 = new UserControl1();
            us_std1 = new Us_std();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.Location = new Point(921, 120);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 0;
            button1.Text = "Admin";
            button1.UseVisualStyleBackColor = false;
            // 
            // btn_admin
            // 
            btn_admin.BackColor = Color.SlateBlue;
            btn_admin.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_admin.Location = new Point(1108, 83);
            btn_admin.Name = "btn_admin";
            btn_admin.Size = new Size(170, 67);
            btn_admin.TabIndex = 1;
            btn_admin.Text = "Admin";
            btn_admin.UseVisualStyleBackColor = false;
            btn_admin.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 36.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(234, -4);
            label2.Name = "label2";
            label2.Size = new Size(858, 82);
            label2.TabIndex = 3;
            label2.Text = "Library Management System";
            label2.Click += label2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SlateBlue;
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(182, 81);
            button3.Name = "button3";
            button3.Size = new Size(170, 69);
            button3.TabIndex = 4;
            button3.Text = "Student";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // userControl11
            // 
            userControl11.BackColor = Color.Transparent;
            userControl11.BackgroundImage = (Image)resources.GetObject("userControl11.BackgroundImage");
            userControl11.BackgroundImageLayout = ImageLayout.Stretch;
            userControl11.Font = new Font("Segoe UI", 9F);
            userControl11.ForeColor = SystemColors.ControlLightLight;
            userControl11.Location = new Point(973, 172);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(428, 532);
            userControl11.TabIndex = 5;
            userControl11.Load += userControl11_Load_2;
            // 
            // us_std1
            // 
            us_std1.BackColor = Color.FromArgb(255, 192, 128);
            us_std1.Location = new Point(37, 172);
            us_std1.Name = "us_std1";
            us_std1.Size = new Size(428, 532);
            us_std1.TabIndex = 6;
            us_std1.Load += us_std1_Load;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(1370, 12);
            button2.Name = "button2";
            button2.Size = new Size(62, 53);
            button2.TabIndex = 7;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1501, 739);
            Controls.Add(button2);
            Controls.Add(us_std1);
            Controls.Add(userControl11);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(btn_admin);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btn_admin;
        private Label label2;
        private Button button3;
        private UserControl1 userControl11;
        private Us_std us_std1;
        private Button button2;
    }
}
