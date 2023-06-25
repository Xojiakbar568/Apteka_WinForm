using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            DataUserControl user = new DataUserControl();
            UserControl1(user);
        }
        SqlDataAdapter adapter = new SqlDataAdapter();  
        SqlConnection connection = new SqlConnection();
        DataTable table = new DataTable();
        private void UserControl1(UserControl userControl) 
        {
            tableme.Controls.Clear();
            tableme.Controls.Add(userControl);
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            DataUserControl userf = new DataUserControl();
            UserControl1(userf);
        }

        private void tableme_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("I do this after!","Sorry about that!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Refresh(object sender, EventArgs e)
        {
            DataUserControl userc = new DataUserControl();
            UserControl1(userc);
        }

        private void Update(object sender, EventArgs e)
        {
            UpdateControl userc = new UpdateControl();
            UserControl1(userc);
        }

        private void Delete(object sender, EventArgs e)
        {
            DeleteUserControl deleteUser= new DeleteUserControl();
            UserControl1(deleteUser);

        }

        private void Add(object sender, EventArgs e)
        {
            UserControl1 user = new UserControl1();
            UserControl1(user);

        }

        private void Exit(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Show_Table(object sender, EventArgs e)
        {
            DataUserControl userc = new DataUserControl();
            UserControl1(userc);
        }
    }
}
