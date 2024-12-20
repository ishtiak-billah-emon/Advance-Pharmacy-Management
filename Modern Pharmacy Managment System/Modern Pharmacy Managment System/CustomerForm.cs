using Modern_Pharmacy_Managment_System.Database;
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
using System.Data;

namespace Modern_Pharmacy_Managment_System
{
   
    public partial class CustomerForm : Form
    {
       Functions Con;
        public CustomerForm()
        {
            InitializeComponent();
            Con = new Functions();
            showCustomerForm();
          
        }

        private void showCustomerForm()
        {
            string Query = "select cid, cname, cphone, cpoints from tbCustomer";
            dgvCustomer.DataSource = Con.GetData(Query);
        }

        string Key = "";


        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerManagementForm moduleForm = new CustomerManagementForm();
            moduleForm.btnSave.Enabled = true;
            moduleForm.btnUpdate.Enabled = false;
            moduleForm.btnUpdate.Visible = false;
            moduleForm.ShowDialog();

            showCustomerForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string remove = tbSearchBox.Text;

            
            string query = "DELETE FROM tbCustomer WHERE cname = @cname";

            using (var con = DatabaseConnection.databaseConnect())
            {
                try
                {
                    con.Open();

                    
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@cname", remove);

                       
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            
                            messageDialog.Show("Customer Removed!");
                        }
                        else
                        {                         
                            messageDialog.Show("Customer not found!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            tbSearchBox.Text = "";
            showCustomerForm();          
        }

        private void tbSearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbSearchBox.Text.Trim();
            string Query = "SELECT cid,cname, cphone, cpoints FROM tbCustomer WHERE cname LIKE '%" + searchText + "%'";
            dgvCustomer.DataSource = Con.GetData(Query);
            
        }

 
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dgvCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCustomer.SelectedRows[0];
                string customerName = selectedRow.Cells[1].Value.ToString();
                string customerPhone = selectedRow.Cells[2].Value.ToString();
          //      string customerPassword = selectedRow.Cells[3].Value.ToString();
                CustomerManagementForm cmf = new CustomerManagementForm();
                cmf.lblCId.Text = dgvCustomer.Rows[0].Cells[0].Value.ToString();
                cmf.txtCuName.Text = customerName;
                cmf.txtCPhone.Text = customerPhone;
                //cmf.txtPassword.Text = customerPassword;
                cmf.txtCPhone.ReadOnly = true;
                cmf.txtPassword.Visible = false;
                cmf.lblPassword.Visible = false;
                cmf.btnSave.Enabled = false;
                cmf.btnSave.Visible = false;
                cmf.btnUpdate.Enabled = true;
                cmf.ShowDialog();
          
                showCustomerForm();
            }
            else
            {
                warningMessage.Show("Please select a customer to update.");
            }

            tbSearchBox.Text = "";         
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvCustomer_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tbSearchBox.Text = dgvCustomer.SelectedRows[0].Cells[1].Value.ToString();
            Key = dgvCustomer.SelectedRows[0].Cells[1].Value.ToString();    
        }
    }
}
