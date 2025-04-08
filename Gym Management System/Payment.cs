using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Gym_Management_System
{
    public partial class Payment : Form
    {
        private const decimal InitialAmount = 20000m; // Default initial amount

        public Payment()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JES4066\\SQLEXPRESS; Initial Catalog=GYM; Integrated Security=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewMember where MID = " + memberIdTextbox.Text + "";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Continue_Click(object sender, EventArgs e)
        {
            string memberId = memberIdTextbox.Text.Trim();
            string memberName = nameTextbox.Text.Trim();
            decimal paymentAmount;

            if (string.IsNullOrEmpty(memberId) || string.IsNullOrEmpty(memberName))
            {
                MessageBox.Show("Please enter both Member ID and Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(paymentTextbox.Text.Trim(), out paymentAmount) || paymentAmount <= 0)
            {
                MessageBox.Show("Please enter a valid payment amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-JES4066\\SQLEXPRESS; Initial Catalog=GYM; Integrated Security=True;"))
            {
                try
                {
                    con.Open();

                    // Check if the Member exists
                    string query = "SELECT COUNT(*) FROM NewMember WHERE MID = @MID AND Firstname + ' ' + Lastname = @FullName";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MID", memberId);
                        cmd.Parameters.AddWithValue("@FullName", memberName);

                        int count = (int)cmd.ExecuteScalar();
                        if (count == 0)
                        {
                            MessageBox.Show("Member ID and Name do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Compute Remaining Balance
                    decimal remainingBalance = InitialAmount - paymentAmount;

                    // Update Payment Record
                    string insertQuery = "INSERT INTO Payments (MID, MemberName, AmountPaid, RemainingBalance, PaymentDate) VALUES (@MID, @MemberName, @AmountPaid, @RemainingBalance, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@MID", memberId);
                        cmd.Parameters.AddWithValue("@MemberName", memberName);
                        cmd.Parameters.AddWithValue("@AmountPaid", paymentAmount);
                        cmd.Parameters.AddWithValue("@RemainingBalance", remainingBalance);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Payment successful!\nRemaining Balance: {remainingBalance:C}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear Input Fields
                    paymentTextbox.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }





        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void backtohome2_Click(object sender, EventArgs e)
        {
            Offers gymform = new Offers();
            gymform.Show();
            Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void subduration_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roundedPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            memberIdTextbox.Clear();
            nameTextbox.Clear();
            paymentTextbox.Clear();
            subduration.ResetText();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}



