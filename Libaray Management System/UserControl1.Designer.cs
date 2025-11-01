namespace Libaray_Management_System
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            panel2 = new Panel();
            label1 = new Label();
            txtadmin_user = new TextBox();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            txtadmin_pass = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            button1 = new Button();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(427, 135);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(93, 40);
            label1.Name = "label1";
            label1.Size = new Size(278, 57);
            label1.TabIndex = 0;
            label1.Text = "Admin Login";
            // 
            // txtadmin_user
            // 
            txtadmin_user.Font = new Font("Microsoft Sans Serif", 25.25F);
            txtadmin_user.Location = new Point(87, 25);
            txtadmin_user.Name = "txtadmin_user";
            txtadmin_user.Size = new Size(236, 55);
            txtadmin_user.TabIndex = 2;
            txtadmin_user.TextChanged += textBox1_TextChanged;
            txtadmin_user.Leave += textBox1_Leave;
            txtadmin_user.MouseLeave += textBox1_MouseLeave;
            txtadmin_user.MouseHover += textBox1_MouseHover;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 192, 255);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(txtadmin_user);
            groupBox1.Font = new Font("Microsoft Sans Serif", 15.25F);
            groupBox1.Location = new Point(35, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 93);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(6, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 55);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(txtadmin_pass);
            groupBox2.Font = new Font("Microsoft Sans Serif", 15.25F);
            groupBox2.Location = new Point(35, 294);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(354, 94);
            groupBox2.TabIndex = 4;
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
            // txtadmin_pass
            // 
            txtadmin_pass.Font = new Font("Microsoft Sans Serif", 25.25F);
            txtadmin_pass.Location = new Point(87, 25);
            txtadmin_pass.Name = "txtadmin_pass";
            txtadmin_pass.PasswordChar = '*';
            txtadmin_pass.Size = new Size(236, 55);
            txtadmin_pass.TabIndex = 2;
            txtadmin_pass.MouseLeave += textBox2_MouseLeave;
            txtadmin_pass.MouseHover += textBox2_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(68, 422);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 5;
            label2.Text = "New Register";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(200, 422);
            label5.Name = "label5";
            label5.Size = new Size(17, 28);
            label5.TabIndex = 8;
            label5.Text = "|";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(233, 422);
            label3.Name = "label3";
            label3.Size = new Size(156, 28);
            label3.TabIndex = 9;
            label3.Text = "Forget Password";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(138, 475);
            button1.Name = "button1";
            button1.Size = new Size(145, 49);
            button1.TabIndex = 10;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 9F);
            ForeColor = SystemColors.ControlLightLight;
            Name = "UserControl1";
            Size = new Size(427, 527);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private TextBox txtadmin_user;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private TextBox txtadmin_pass;
        private Label label2;
        private Label label5;
        private Label label3;
        private Button button1;
    }
}
