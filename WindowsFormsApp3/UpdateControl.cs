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
using System.Drawing.Text;
using System.CodeDom.Compiler;

namespace WindowsFormsApp3
{
    public partial class UpdateControl : UserControl
    {
        public UpdateControl()
        {
            InitializeComponent();
        }
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        DataTable table = new DataTable();

        private void UpdateControl_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Goldmaster\source\repos\Apteka\WindowsFormsApp3\Database3.mdf;Integrated Security=True");

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
            iid.Clear();
            nname.Clear();
            pprice.Clear();
            llocation.Clear();
            MessageBox.Show("Cleared!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

            connection.Open();
            command = new SqlCommand(@"UPDATE [Admin] set Name=@Name, Price=@Price, Location=@Location where Id=@Id", connection);

            command.Parameters.AddWithValue("@Id", iid.Text);
            command.Parameters.AddWithValue("@Name", nname.Text);
            command.Parameters.AddWithValue("@Price", pprice.Text);
            command.Parameters.AddWithValue("@Location", llocation.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Succesfuly update!", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            iid.Clear();
            nname.Clear();
            pprice.Clear();
            llocation.Clear();
        }
    }
}
