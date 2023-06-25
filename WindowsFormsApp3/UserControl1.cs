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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();  
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        private void UserControl1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Goldmaster\source\repos\Apteka\WindowsFormsApp3\Database3.mdf;Integrated Security=True");
            Loaddata();
        }
        public void Loaddata()
        {
            string readquery = "SELECT * FROM [Admin]";
            adapter = new SqlDataAdapter(readquery, connection);
            table = new DataTable();
            adapter.Fill(table);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            nameb.Clear();
            priceb.Clear();
            locb.Clear();
            MessageBox.Show("Email and Password has been cleared!!!", "Succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (nameb.Text == "" && priceb.Text == "" && locb.Text == "")
            {
                MessageBox.Show("Please can you feel data", "Data error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    connection.Open();
                    string createquery = $"INSERT INTO [Admin] (Name, Price, Location) VALUES ('{nameb.Text}', '{priceb.Text}', '{locb.Text}')";
                    command = new SqlCommand(createquery, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    nameb.Clear();
                    priceb.Clear();
                    locb.Clear();
                    this.Hide();
                    MessageBox.Show("Saving succesfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
