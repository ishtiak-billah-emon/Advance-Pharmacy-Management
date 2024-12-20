using System;
using System.Data;
using System.Windows.Forms;

namespace Modern_Pharmacy_Managment_System
{
    public partial class CustomerSettings : Form
    {
        Functions Con;

        public CustomerSettings()
        {
            InitializeComponent();
            Con = new Functions();
        }

       

        private void UpdatePasswordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string currentPassword = CurrentPasswordTxt.Text;
                string newPassword = NewPasswordTxt.Text;
                string confirmNewPassword = ConfirmNewPasswordTxt.Text;

                // Check if new password and confirm new password match
                if (newPassword != confirmNewPassword)
                {
                    MessageBox.Show("New password and confirm new password do not match.");
                    return;
                }

                // Retrieve the customer ID based on the current password
                string customerIdQuery = "SELECT cID FROM tbCustomer WHERE cpassword = '{0}'";
                customerIdQuery = string.Format(customerIdQuery, currentPassword);
                DataTable customerIdDt = Con.GetData(customerIdQuery);

                // Check if customer exists and retrieve the customer ID
                if (customerIdDt.Rows.Count > 0)
                {
                    int customerId = Convert.ToInt32(customerIdDt.Rows[0]["cID"]);

                    // Update the customer's password
                    string updatePasswordQuery = "UPDATE tbCustomer SET cpassword = '{0}' WHERE cID = {1}";
                    updatePasswordQuery = string.Format(updatePasswordQuery, newPassword, customerId);
                    Con.SetData(updatePasswordQuery);

                    MessageBox.Show("Password updated successfully!");
                }
                else
                {
                    MessageBox.Show("Current password is incorrect.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating password: " + ex.Message);
            }

        }

        private void pictureBoxGif2_Click(object sender, EventArgs e)
        {

        }
    }
}
