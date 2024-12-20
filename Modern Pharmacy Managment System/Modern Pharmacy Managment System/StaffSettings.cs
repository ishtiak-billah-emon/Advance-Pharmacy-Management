using System;
using System.Data;
using System.Windows.Forms;

namespace Modern_Pharmacy_Managment_System
{
    public partial class StaffSettings : Form
    {
        Functions Con;

        public StaffSettings()
        {
            InitializeComponent();
            Con = new Functions();
        }
       
        

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void StaffSettings_Load(object sender, EventArgs e)
        {

        }

        private void UpdatePasswordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int empId = Login.EmpId;
                string currentPassword = CurrentPasswordTxt.Text;
                string newPassword = NewPasswordTxt.Text;
                string confirmNewPassword = ConfirmNewPasswordTxt.Text;

                // Check if the new password and confirm password match
                if (newPassword != confirmNewPassword)
                {
                    MessageBox.Show("New password and confirm password do not match.");
                    return;
                }

                // Check if the current password matches the stored password for the employee
                string query = "SELECT EmpPass FROM EmployeeTbl WHERE EmpId = " + empId;
                DataTable dt = Con.GetData(query);
                if (dt.Rows.Count > 0)
                {
                    string storedPassword = dt.Rows[0]["EmpPass"].ToString();
                    if (storedPassword != currentPassword)
                    {
                        MessageBox.Show("Current password is incorrect.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Employee not found.");
                    return;
                }

                // Update the password in the database
                string updateQuery = "UPDATE EmployeeTbl SET EmpPass = '{0}' WHERE EmpId = {1}";
                updateQuery = string.Format(updateQuery, newPassword, empId);
                Con.SetData(updateQuery);

                MessageBox.Show("Password updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
