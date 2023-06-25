using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            emailtxt.Clear();
            passtext.Clear();
            MessageBox.Show("Email and Password has been cleared!!!", "Succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if(emailtxt.Text == "Xojiakbar" && passtext.Text == "12345")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email or Password has been invalid!", "False", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void emailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_Load(object sender, EventArgs e)
        {

        }
    }
}
