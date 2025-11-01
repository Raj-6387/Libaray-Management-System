using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libaray_Management_System
{
    public partial class Us_std : UserControl
    {
        public Us_std()
        {
            InitializeComponent();
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            if (txtstd_user.Text == "Username")
            {
                txtstd_user.Text = "";
                txtstd_user.ForeColor = Color.Silver;
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (txtstd_user.Text == "")
            {
                txtstd_user.Text = "Username";
                txtstd_user.ForeColor = Color.Silver;
            }
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            if (txtstd_pass.Text == "Password")
            {
                txtstd_pass.Text = "";
                txtstd_pass.ForeColor = Color.Silver;
            }
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            if (txtstd_user.Text == "")
            {
                txtstd_user.Text = "password";
                txtstd_user.ForeColor = Color.Silver;
            }
        }

        private void Us_std_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (txtstd_user.Text == "Student" && txtstd_pass.Text == "Student")
            {
                Form2 f = new Form2();
                f.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or  Password! \n Please Enter Correct Username and Password...");
            }
        }
    }
}
