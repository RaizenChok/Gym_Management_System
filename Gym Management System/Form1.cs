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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void newMemberMenustrip_Click(object sender, EventArgs e)
        {
             Payment gymform = new Payment();
            gymform.Show();
            Visible = false;
        }

        private void memlistStripMenuItem_Click(object sender, EventArgs e)
        {
            VMember gymform = new VMember();
            gymform.Show();
            Visible = false;
        }

        
        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendance gymform = new Attendance();
            gymform.Show();
            Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       
           

        private void notificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notification gymform = new Notification();
            gymform.Show();
            Visible = false;
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        
            {
                if (MessageBox.Show("Are you sure you want to log out? Confirm", "LOG OUT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    this.Close();
                    Login lg = new Login();
                    lg.Show();
                }
            }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
