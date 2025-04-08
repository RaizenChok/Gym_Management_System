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

namespace Gym_Management_System
{
    public partial class VMember : Form
    {
        public VMember()
        {
            InitializeComponent();
        }

        private void searchbttn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-JES4066\\SQLEXPRESS; Initial Catalog=GYM; Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"
                SELECT * FROM NewMember 
                WHERE Firstname LIKE @search 
                   OR Lastname LIKE @search 
                   OR CAST(MID AS NVARCHAR) LIKE @search
                   OR CONCAT(Firstname, ' ', Lastname) LIKE @search"; // Full name search

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + searchTxt.Text.Trim() + "%"); // Allows partial/full matches

                        SqlDataAdapter DA = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        DA.Fill(dt);

                        grid1.DataSource = dt; // Display results
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }








        private void VMember_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JES4066\\SQLEXPRESS; Initial Catalog=GYM; Integrated Security=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewMember";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            int a = 10;

            grid1.DataSource = DS.Tables[0];
        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backtohome2_Click(object sender, EventArgs e)
        {
            Form1 gymform = new Form1();
            gymform.Show();
            Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
