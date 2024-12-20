using System;
using System.Data;
using System.Windows.Forms;

namespace Modern_Pharmacy_Managment_System
{
    public partial class AdminForgotPass : Form
    {
        Functions Con; 

        public AdminForgotPass()
        {
            InitializeComponent();
            Con = new Functions(); 
        }

        private void ClearFields()
        {
           CurrentPasswordTxt.Text = "";
            NewPasswordTxt.Text = "";
            ConfirmNewPasswordTxt.Text = "";
           
        }


        private void UpdatePasswordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string currentPassword = CurrentPasswordTxt.Text;
                string newPassword = NewPasswordTxt.Text;
                string confirmNewPassword = ConfirmNewPasswordTxt.Text;


                if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmNewPassword))
                {
                    MessageBox.Show("Please fill all the fields.");
                    return;
                }
               
                if (newPassword != confirmNewPassword)
                {
                    MessageBox.Show("New password and confirm new password do not match.");
                    return;
                }

                
                string adminIdQuery = "SELECT AdminId FROM AdminTbl WHERE AdminPassword = '{0}'";
                adminIdQuery = string.Format(adminIdQuery, currentPassword);
                DataTable adminIdDt = Con.GetData(adminIdQuery);

               
                if (adminIdDt.Rows.Count > 0)
                {
                    int adminId = Convert.ToInt32(adminIdDt.Rows[0]["AdminId"]);

                  
                    string updatePasswordQuery = "UPDATE AdminTbl SET AdminPassword = '{0}' WHERE AdminId = {1}";
                    updatePasswordQuery = string.Format(updatePasswordQuery, newPassword, adminId);
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

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
