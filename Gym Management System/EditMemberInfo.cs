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
using static System.Windows.Forms.AxHost;

namespace Gym_Management_System
{
    public partial class EditMemberInfo : Form
    {
        private int _memberId;
        public EditMemberInfo(int memberId)
        {
            InitializeComponent();
            _memberId = memberId;
            LoadMemberData();
        }

        private void fnametxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadMemberData()
        {
            string connectionString = "Data Source=DESKTOP-JES4066\\SQLEXPRESS; Initial Catalog=GYM; Integrated Security=True;";
            string query = "SELECT MID, Firstname, Lastname, Gender,Birthdate, Mobile, Email, JoinDate, Gymtime, Membershipduration " +
                           "FROM NewMember WHERE MID = @MID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@MID", _memberId);

                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {

                        MIDlbl.Text = reader["MID"].ToString();
                        
                        genderlbl.Text = reader["Gender"].ToString();
                        bdaylbl.Text = Convert.ToDateTime(reader["Birthdate"]).ToShortDateString();
                        
                        joindatelbl.Text = Convert.ToDateTime(reader["JoinDate"]).ToShortDateString();
                        
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-JES4066\\SQLEXPRESS; Initial Catalog=GYM; Integrated Security=True;"))
                {
                    con.Open();

                    string updateQuery = "UPDATE NewMember SET Firstname = @Firstname, Lastname = @Lastname, Gender = @Gender, Birthdate = @Birthdate, Mobile = @Mobile, Email = @Email, JoinDate = @JoinDate, GymTime = @GymTime, MembershipDuration = @MembershipDuration, Username = @Username, pssword = @pssword WHERE MID = @MID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@MID", _memberId);
                        cmd.Parameters.AddWithValue("@Firstname", fnametxt.Text);
                        cmd.Parameters.AddWithValue("@Lastname", lnametxt.Text);
                        cmd.Parameters.AddWithValue("@Gender", genderlbl.Text);
                        cmd.Parameters.AddWithValue("@Birthdate", bdaylbl.Text);
                        cmd.Parameters.AddWithValue("@Mobile", Mobilenumtxt.Text);
                        cmd.Parameters.AddWithValue("@Email", email.Text);
                        cmd.Parameters.AddWithValue("@JoinDate", joindatelbl.Text);
                        cmd.Parameters.AddWithValue("@GymTime", gymtime.Text);
                        cmd.Parameters.AddWithValue("@MembershipDuration", subduration.Text);
                        cmd.Parameters.AddWithValue("@Username", Usertxt.Text.Trim());

                        cmd.Parameters.AddWithValue("@pssword", passwordtxt.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data saved successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void Donebtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-JES4066\\SQLEXPRESS; Initial Catalog=GYM; Integrated Security=True;"))
                {
                    con.Open();
                    string updateQuery = "UPDATE NewMember SET Firstname = @Firstname, Lastname = @Lastname, Gender = @Gender, Birthdate = @Birthdate, Mobile = @Mobile, Email = @Email, JoinDate = @JoinDate, GymTime = @GymTime, MembershipDuration = @MembershipDuration, Username = @Username, pssword = @pssword WHERE MID = @MID";
                    SqlCommand cmd = new SqlCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@MID", _memberId);
                    cmd.Parameters.AddWithValue("@Firstname", fnametxt.Text);
                    cmd.Parameters.AddWithValue("@Lastname", lnametxt.Text);
                    cmd.Parameters.AddWithValue("@Gender", genderlbl.Text);
                    cmd.Parameters.AddWithValue("@Birthdate", bdaylbl.Text);
                    cmd.Parameters.AddWithValue("@Mobile", Mobilenumtxt.Text);
                    cmd.Parameters.AddWithValue("@Email", email.Text);
                    cmd.Parameters.AddWithValue("@JoinDate", joindatelbl.Text);
                    cmd.Parameters.AddWithValue("@GymTime", gymtime.Text);
                    cmd.Parameters.AddWithValue("@MembershipDuration", subduration.Text);
                    cmd.Parameters.AddWithValue("@Username", Usertxt.Text);
                    cmd.Parameters.AddWithValue("@pssword", passwordtxt.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Changes saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                MemberUI memberForm = new MemberUI(_memberId);
                memberForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backtohome2_Click(object sender, EventArgs e)
        {
            MemberUI gymform = new MemberUI(_memberId);
            gymform.Show();
        }
    }

}


