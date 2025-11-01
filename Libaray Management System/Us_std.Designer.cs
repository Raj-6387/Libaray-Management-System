namespace Libaray_Management_System
{
    partial class Us_std
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Us_std));
            panel2 = new Panel();
            label1 = new Label();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            txtstd_pass = new TextBox();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            txtstd_user = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            button1 = new Button();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(447, 135);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(127, 25);
            label1.Name = "label1";
            label1.Size = new Size(301, 57);
            label1.TabIndex = 0;
            label1.Text = "Student Login";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(txtstd_pass);
            groupBox2.Font = new Font("Microsoft Sans Serif", 15.25F);
            groupBox2.Location = new Point(22, 303);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(354, 100);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 55);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txtstd_pass
            // 
            txtstd_pass.Font = new Font("Microsoft Sans Serif", 25.25F);
            txtstd_pass.Location = new Point(87, 25);
            txtstd_pass.Name = "txtstd_pass";
            txtstd_pass.PasswordChar = '*';
            txtstd_pass.Size = new Size(236, 55);
            txtstd_pass.TabIndex = 2;
            txtstd_pass.MouseLeave += textBox2_MouseLeave;
            txtstd_pass.MouseHover += textBox2_MouseHover;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 192, 255);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(txtstd_user);
            groupBox1.Font = new Font("Microsoft Sans Serif", 15.25F);
            groupBox1.Location = new Point(22, 171);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 100);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(0, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 55);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // txtstd_user
            // 
            txtstd_user.Font = new Font("Microsoft Sans Serif", 25.25F);
            txtstd_user.Location = new Point(87, 25);
            txtstd_user.Name = "txtstd_user";
            txtstd_user.Size = new Size(236, 55);
            txtstd_user.TabIndex = 2;
            txtstd_user.TextChanged += textBox1_TextChanged;
            txtstd_user.MouseLeave += textBox1_MouseLeave;
            txtstd_user.MouseHover += textBox1_MouseHover;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(220, 419);
            label3.Name = "label3";
            label3.Size = new Size(156, 28);
            label3.TabIndex = 12;
            label3.Text = "Forget Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(177, 419);
            label5.Name = "label5";
            label5.Size = new Size(17, 28);
            label5.TabIndex = 11;
            label5.Text = "|";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(22, 419);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 10;
            label2.Text = "New Register";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(100, 464);
            button1.Name = "button1";
            button1.Size = new Size(201, 63);
            button1.TabIndex = 13;
            button1.Text = " Login ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Us_std
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Name = "Us_std";
            Size = new Size(447, 541);
            Load += Us_std_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private TextBox txtstd_pass;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private TextBox txtstd_user;
        private Label label3;
        private Label label5;
        private Label label2;
        private Button button1;
    }
}
