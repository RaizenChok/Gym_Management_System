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
    public partial class MemberUI : Form
    {
        private int memberId;

        public MemberUI(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
            LoadMemberDetails();
        }

        private void LoadMemberDetails()
        {
            string connectionString = "Data Source=DESKTOP-JES4066\\SQLEXPRESS; Initial Catalog=GYM; Integrated Security=True;";
            string query = "SELECT MID, Firstname, Lastname, Gender,Birthdate, Mobile, Email, JoinDate, Gymtime, Membershipduration,Username, pssword " +
                           "FROM NewMember WHERE MID = @MID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@MID", memberId);

                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {

                        MIDlbl.Text = reader["MID"].ToString();
                        Fnamelbl.Text = reader["Firstname"].ToString();
                        Lnamelbl.Text = reader["Lastname"].ToString();
                        genderlbl.Text = reader["Gender"].ToString();
                        bdaylbl.Text = Convert.ToDateTime(reader["Birthdate"]).ToShortDateString();
                        mobilelbl.Text = reader["Mobile"].ToString();
                        emaillbl.Text = reader["Email"].ToString();
                        joindlbl.Text = Convert.ToDateTime(reader["JoinDate"]).ToShortDateString();
                        gymtimelbl.Text = reader["Gymtime"].ToString();
                        membershiplbl.Text = reader["Membershipduration"].ToString();
                        usernamelbl.Text = reader["Username"].ToString();
                        passwordlbl.Text = reader["pssword"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No member found with the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void MemberUI_Load(object sender, EventArgs e)
        {

        }

        private void Logoutmembtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logging Out, Confirm?", "LOG OUT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
               
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
        }

        internal void SetUserData(string fname, string email, string mobile)
        {
            throw new NotImplementedException();
        }

        private void Fnamelbl_Click(object sender, EventArgs e)
        {

        }

        private void Lnamelbl_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void mobilelbl_Click(object sender, EventArgs e)
        {

        }

        private void bdaylbl_Click(object sender, EventArgs e)
        {

        }

        private void genderlbl_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Attendance gymform = new Attendance();
            gymform = new Attendance();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login2 lg2 = new Login2();
            lg2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int memberId = Session.LoggedInMemberId;
            EditMemberInfo gymform = new EditMemberInfo(memberId);
            gymform.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void usernamelbl_Click(object sender, EventArgs e)
        {

        }
    }
  }
