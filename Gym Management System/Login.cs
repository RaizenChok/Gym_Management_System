using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private bool isValid()
        {
            if (Usertxt.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter valid user name", "error");
                return false;
            }
            else if (passwordtxt.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter valid password", "error");
                return false;
            }
            return true;
        }
        
        private void btwNewmem_Click_1(object sender, EventArgs e)
        {
            Login2 lg2 = new Login2();
            lg2.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Usertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exiting... Confirm", "LOG OUT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
               
            }
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                passwordtxt.UseSystemPasswordChar = true;
            else
                passwordtxt.UseSystemPasswordChar = false;
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                if (Usertxt.Text == "Admin" && passwordtxt.Text == "Admin")
                {
                    Form1 fm = new Form1();
                    fm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Incorrect User or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void rgisterbtn_Click(object sender, EventArgs e)
        {
            NewMember gymform = new NewMember(); 
            gymform.Show();
            this.Close();
        }

        private void Adminbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
