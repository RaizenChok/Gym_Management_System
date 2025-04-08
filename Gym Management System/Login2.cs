using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ZXing;

namespace Gym_Management_System
{
    public partial class Login2 : Form
    {
        private SqlConnection con = new SqlConnection();

        public Login2()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-JES4066\SQLEXPRESS; Initial Catalog=GYM; Integrated Security=True;";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


       

        private bool isValid()
        {
            if (Usertxt2.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter valid user name", "Error");
                return false;
            }
            else if (passwordtxt2.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter valid password", "Error");
                return false;
            }
            return true;
        }
      
        private void Login2_Load(object sender, EventArgs e)
        {

        }

        private void backtohome2_Click(object sender, EventArgs e)
        {
            NewMember gymform = new NewMember();
            gymform.Show();
            Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                passwordtxt2.UseSystemPasswordChar = false;
            else
                passwordtxt2.UseSystemPasswordChar = true;
        }

        private void Usertxt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginbtn2_Click_1(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlCommand cmd;
                SqlDataReader rd;

                try
                {

                    con.Open();

                    string query = "SELECT * FROM NewMember WHERE Username = @Username AND pssword = @pssword";
                    cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Username", Usertxt2.Text.Trim());

                    cmd.Parameters.AddWithValue("@pssword", passwordtxt2.Text.Trim());





                    rd = cmd.ExecuteReader();


                    if (rd.Read())
                    {
                        MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                        int memberId = Convert.ToInt32(rd["MID"]);
                        Session.LoggedInMemberId = memberId;   

                        MemberUI gymform = new MemberUI(memberId);
                        gymform.Show();
                    }

                    else
                    {
                        MessageBox.Show("Invalid Username or Password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }
    }
}
