using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class DeleteUserControl : UserControl
    {
        public DeleteUserControl()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        private void delu_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DeleteUserControl_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Goldmaster\source\repos\Apteka\WindowsFormsApp3\Database3.mdf;Integrated Security=True");
            
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new SqlCommand(@"DELETE [Admin] where Id=@Id", connection);
            command.Parameters.AddWithValue("@Id", int.Parse(delu.Text));
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Deleting has been finished!", "Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            delu.Clear();
        }
    }
}
