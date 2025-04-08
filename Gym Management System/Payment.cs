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
using System.Xml.Linq;
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
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Continue_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-JES4066\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True";

            // Get values from UI
            string memberId = memberIdTextbox.Text.Trim();
            string memberName = nameTextbox.Text.Trim();
            string amountPaidText = paymentTextbox.Text.Trim(); // Assuming this is the textbox where the user enters the payment amount
            decimal remainingBalance = 0; // Optional: you can calculate this if needed
            DateTime paymentDate = DateTime.Now;

            // Simple validation
            if (string.IsNullOrEmpty(memberId) || string.IsNullOrEmpty(memberName) || string.IsNullOrEmpty(amountPaidText))
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(memberId, out int parsedMID))
            {
                MessageBox.Show("Member ID must be a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(amountPaidText, out decimal amountPaid))
            {
                MessageBox.Show("Amount Paid must be a valid decimal value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO Payments (MID, MemberName, AmountPaid, RemainingBalance, PaymentDate)
                             VALUES (@MID, @MemberName, @AmountPaid, @RemainingBalance, @PaymentDate)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MID", parsedMID);
                        cmd.Parameters.AddWithValue("@MemberName", memberName);
                        cmd.Parameters.AddWithValue("@AmountPaid", amountPaid);
                        cmd.Parameters.AddWithValue("@RemainingBalance", remainingBalance);
                        cmd.Parameters.AddWithValue("@PaymentDate", paymentDate);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Payment successfully recorded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Optionally clear form
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Payment failed to record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            memberIdTextbox.Clear();
            nameTextbox.Clear();
            paymentTextbox.Clear();
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

        private void button1_Click(object sender, EventArgs e)
        {
            NewMember gymform = new NewMember();
            gymform.Show();
            this.Close();
        }
    }
}



