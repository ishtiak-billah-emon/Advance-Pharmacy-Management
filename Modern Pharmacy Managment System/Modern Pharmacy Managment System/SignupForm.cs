using Modern_Pharmacy_Managment_System.Database;
using Modern_Pharmacy_Managment_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Modern_Pharmacy_Managment_System
{
    public partial class SignupForm : Form
    {
        Functions con;
        public SignupForm()
        {
            InitializeComponent();
            con = new Functions();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {               
                InsertCustomerData();
            }
        }

        private bool ValidateInput()
        {
            // Check if name, phone, password, and re-entered password are not empty
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtPass.Text) ||
                string.IsNullOrWhiteSpace(txtRePass.Text))
            {
                
                warningMessage.Show("Please provide all the information.");        
                return false;
            }

            // Check if the phone number is 11 digits and starts with '01'
            if (txtPhone.Text.Length != 11 || !txtPhone.Text.StartsWith("01"))
            {              
                errorMessage.Show("Invalid Phone Number!");
                
                return false;
            }


            // Check if all digits in the phone number are between 0 and 9
            foreach (char digit in txtPhone.Text)
            {
                if (!char.IsDigit(digit) || digit < '0' || digit > '9')
                {                   
                    errorMessage.Show("Invalid Phone Number!");
                    return false;
                }
            }

            // Check if the password and re-entered password match
            if (txtPass.Text != txtRePass.Text)
            {            
                errorMessage.Show("Passwords did not match.");
                return false;
            }

            if (Customer.CheckPhoneNumberExists(txtPhone.Text))
            {
                errorMessage.Show("Phone Number already exists!");
                return false;
            }

            return true;
        }

        private void InsertCustomerData()
        {
            try
            {
                // Initialize cpoints to 0
                int cpoints = 0;

                // Prepare the INSERT query
                string insertQuery = "INSERT INTO tbCustomer (cname, cphone, cpassword, cpoints) VALUES (@cname, @cphone, @cpassword, @cpoints)";

                // Create SqlCommand object and add parameters
                SqlCommand Cmd = new SqlCommand(insertQuery);
                Cmd.Parameters.AddWithValue("@cname", txtName.Text);
                Cmd.Parameters.AddWithValue("@cphone", txtPhone.Text);
                Cmd.Parameters.AddWithValue("@cpassword", txtPass.Text);
                Cmd.Parameters.AddWithValue("@cpoints", cpoints);

                // Execute the insert query using Functions class
                int rowsAffected = con.insertData(Cmd);

                if (rowsAffected > 0)
                {
                    // MessageBox.Show("Signup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageDialog.Show("Signup successful!");
                    txtName.Clear();
                    txtPhone.Clear();
                    txtPass.Clear();
                    txtRePass.Clear();
                }
                else
                {
                    errorMessage.Show("Signup failed. Please try again.");
                    //MessageBox.Show("Signup failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkShowPassword.Checked)
            {
                txtPass.PasswordChar = '\0'; 
                txtRePass.PasswordChar = '\0'; 
            }
            else
            {
                txtPass.PasswordChar = '●'; 
                txtRePass.PasswordChar = '●'; 
            }
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}

   
