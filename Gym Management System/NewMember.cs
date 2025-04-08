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
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void fnametxt_TextChanged(object sender, EventArgs e)
        {

        }


        private void Savebutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JES4066\\SQLEXPRESS; Initial Catalog=GYM; Integrated Security=True;");
            con.Open();
            string insertQuery = "INSERT INTO NewMember VALUES (@Firstname, @Lastname, @Gender, @Birthdate,@Mobile, @Email, @JoinDate, @GymTime, @Membershipduration, @Username, @pssword)";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@Firstname", fnametxt.Text);
            cmd.Parameters.AddWithValue("@Lastname", lnametxt.Text);
            cmd.Parameters.AddWithValue("@Gender", genderCmb.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Birthdate", bdate.Value);
            cmd.Parameters.AddWithValue("@Mobile", Mobilenumtxt.Text);
            cmd.Parameters.AddWithValue("@Email", email.Text);
            cmd.Parameters.AddWithValue("@JoinDate", joindate.Text);
            cmd.Parameters.AddWithValue("@GymTime", gymtime.Text);
            cmd.Parameters.AddWithValue("@MembershipDuration", subduration.Text);
            cmd.Parameters.AddWithValue("@Username", Usertxt2.Text);
            cmd.Parameters.AddWithValue("@pssword", passwordtxt.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            fnametxt.Clear();
            lnametxt.Clear();
            genderCmb.ResetText();
            bdate.Value = DateTime.Now;  
            subduration.ResetText();
            subduration.ResetText();
        }

        private void joindate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Offers_Click_1(object sender, EventArgs e)
        {
            Offers gymform = new Offers();
            gymform.Show();
            Visible = false;
        }

        private void NewMember_Load(object sender, EventArgs e)
        {

        }

        private void gymtime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void el1_Click(object sender, EventArgs e)
        {

        }

        private void lnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void genderCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void genderlbl_Click(object sender, EventArgs e)
        {

        }

        private void mobilenolbl_Click(object sender, EventArgs e)
        {

        }

        private void Mobilenumtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pssword_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Usertxt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void usernamelbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void subduration_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exiting... Confirm", "EXIT?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();

            }
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            Login gymform = new Login();
            gymform.Show();
            this.Hide();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login2 lg2 = new Login2();
            lg2.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                passwordtxt.UseSystemPasswordChar = false;
            else
                passwordtxt.UseSystemPasswordChar = true;
        }

        private void roundedPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
