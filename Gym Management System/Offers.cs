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
    public partial class Offers : Form
    {
        public Offers()
        {
            InitializeComponent();
        }



        private void Savebutton_Click(object sender, EventArgs e)
        {
            Payment gymform = new Payment();
            gymform.Show();
            Visible = false;
        }

        private void backtohome2_Click(object sender, EventArgs e)
        {
            NewMember gymform = new NewMember();
            gymform.Show(); 
            Visible = false;
        }
    }
}
