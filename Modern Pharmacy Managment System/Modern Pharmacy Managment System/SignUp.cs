using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Pharmacy_Managment_System
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }



        private void signupBtn_Click(object sender, EventArgs e)
        {

        }

        private void signupLoginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//Go back to login
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e) // Go back to login
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
