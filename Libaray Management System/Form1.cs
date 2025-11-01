using System;
using System.Windows.Forms;

namespace Libaray_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            us_std1.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            us_std1.Show();
            us_std1.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label clicked!");
        }

        private void userControl11_Load_2(object sender, EventArgs e)
        {
        }

        private void us_std1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
