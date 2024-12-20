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
    public partial class StaffModule : Form
    {
        public StaffModule()
        {
            InitializeComponent();
        }

        private void StaffModule_Load(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked == false)
            {
                txtPass.UseSystemPasswordChar = true;
            }
            else
            {
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearForm(); // when clear button will be pressed the form will be cleared.
        }

        public void ClearForm() // to clear the data in the textbox
        {
            txtFullname.Clear();
            txtPass.Clear();
            txtPhone.Clear();
            txtUsername.Clear();
            txtUsername.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // staff management text in the heading
        }

        private void closePicture_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // USer Name Label
        }
    }
}
