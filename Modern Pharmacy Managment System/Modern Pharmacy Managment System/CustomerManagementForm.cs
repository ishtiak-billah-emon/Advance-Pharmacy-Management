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
    public partial class CustomerManagementForm : Form
    {
        public CustomerManagementForm()
        {
            InitializeComponent(); 
       
        }

        private void CustomerManagementForm_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            txtCuName.Clear();
            txtCPhone.Clear();
            txtPassword.Clear();
        }
    
        private void txtCuName_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                string phoneNumber = txtCPhone.Text.Trim();

                using(var con = DatabaseConnection.databaseConnect())
                {              
                    if (!Customer.IsValidPhoneNumber(phoneNumber))
                    {
                        errorMessage.Show("Invalid Phone Number");
                        return;
                    }

                    if (Customer.CheckPhoneNumberExists(txtCuName.Text))
                    {
                        errorMessage.Show("Phone Number already exists!");
                        return ;
                    }

                    // Continue saving if phone number is valid                   
                    SqlCommand cm = new SqlCommand();
                    cm = new SqlCommand("INSERT INTO tbCustomer(cname,cphone,cpassword,cpoints)VALUES(@cname, @cphone,@cpassword,@cpoints)", con);
                    cm.Parameters.AddWithValue("@cname", txtCuName.Text);
                    cm.Parameters.AddWithValue("@cphone", phoneNumber);
                    cm.Parameters.AddWithValue("@cpassword", txtPassword.Text);
                    cm.Parameters.AddWithValue("@cpoints", 0);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();                   
                    informationMessage.Show("Customer has been successfully saved!");
                    Clear();                 
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    string phoneNumber = txtCPhone.Text.Trim();
                    if (!Customer.IsValidPhoneNumber(phoneNumber))
                    {
                        return;
                    }

                    if (MessageBox.Show("Are you sure you want to update this Customer?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        /*  SqlCommand cm = new SqlCommand();
                          cm = new SqlCommand("UPDATE tbCustomer SET cname = @cname WHERE cid LIKE '" + lblCId.Text + "' ", con);
                          cm.Parameters.AddWithValue("@cname", txtCuName.Text);
                          cm.Parameters.AddWithValue("@cphone", txtCPhone.Text);
                          // cm.Parameters.AddWithValue("@cpassword", CustomerPassTxt.Text);
                          con.Open();
                          cm.ExecuteNonQuery();
                          con.Close();
                          // MessageBox.Show("Customer has been successfully updated!");
                          informationMessage.Show("Customer has been successfully updated!");
                          this.Dispose();*/

                        con.Open();
                        string query = "UPDATE tbCustomer SET cname = @cname WHERE cid = @cid";
                        SqlCommand cm = new SqlCommand(query, con);
                        cm.Parameters.AddWithValue("@cname", txtCuName.Text);
                        cm.Parameters.AddWithValue("@cid", lblCId.Text);

                        cm.ExecuteNonQuery();
                        con.Close();
                        informationMessage.Show("Customer has been successfully updated!");
                        this.Dispose();
                    }
                }             
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }
    }
}
