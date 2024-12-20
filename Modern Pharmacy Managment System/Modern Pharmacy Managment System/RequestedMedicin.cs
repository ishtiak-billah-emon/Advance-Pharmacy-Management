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
    public partial class RequestedMedicin : Form
    {
        public RequestedMedicin()
        {
            InitializeComponent();
            ShowRequestedMedicine();
        }

        private float calculateTotalPrice()
        {
            float totalPrice = 0.0f;
            if (!string.IsNullOrEmpty(txtUnit.Text) && !string.IsNullOrEmpty(txtBuyingPrice.Text))
            {
                int stockValue = int.Parse(txtUnit.Text);
                float unitPrice = float.Parse(txtBuyingPrice.Text);
                totalPrice = stockValue * unitPrice;
                txtTotalPrice.Text = totalPrice.ToString();
            }
            return totalPrice;
        }

        private void ClearTextBoxes()
        {
            txtId.Clear();
            txtName.Clear();
            txtSellingPrice.Clear();
            txtUnit.Clear();
            txtTotalPrice.Clear();
        }

        private void ShowRequestedMedicine()
        {
            try
            {
                
                DataTable dataTable = new DataTable();

                
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();

                    
                    string query = "SELECT CustomerName, CustomerPhone, MedicineName, MedicineQuantity FROM MedicineRequestTbl";

                   
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        adapter.Fill(dataTable);
                    }

                    con.Close();
                }

              
                dgvRequestedMedicine.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                
                int pid = Convert.ToInt32(txtId.Text);
                string name = txtName.Text;
                string companyName = txtCompanyName.Text;
                string generic = txtGeneric.Text;
                int stock = Convert.ToInt32(txtUnit.Text);
                float buyingPrice = Convert.ToSingle(txtBuyingPrice.Text);
                float sellingPrice = Convert.ToSingle(txtSellingPrice.Text);

                // Calculate total price
                float totalPrice = calculateTotalPrice();

                // Connect to the database
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();

                  
                    string insertQuery = @"INSERT INTO InventoryTbl (PId, PName, PCompanyName, PGeneric, PStock, PBuyingPrice, PSellingPrice) 
                                   VALUES (@Pid, @Name, @CompanyName, @Generic, @Stock, @BuyingPrice, @SellingPrice)";

                   
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@Pid", pid);
                        insertCmd.Parameters.AddWithValue("@Name", name);
                        insertCmd.Parameters.AddWithValue("@CompanyName", companyName);
                        insertCmd.Parameters.AddWithValue("@Generic", generic);
                        insertCmd.Parameters.AddWithValue("@Stock", stock);
                        insertCmd.Parameters.AddWithValue("@BuyingPrice", buyingPrice);
                        insertCmd.Parameters.AddWithValue("@SellingPrice", sellingPrice);

                        
                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Medicine added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                            ClearTextBoxes();

                            // Insert into AccountTbl
                            string insertAccountQuery = @"INSERT INTO AccountTbl (Expense, Date) VALUES (@Expense, @Date)";
                            using (SqlCommand insertAccountCmd = new SqlCommand(insertAccountQuery, con))
                            {
                                insertAccountCmd.Parameters.AddWithValue("@Expense", totalPrice);
                                insertAccountCmd.Parameters.AddWithValue("@Date", DateTime.Now);

                             
                                int rowsAffectedAccount = insertAccountCmd.ExecuteNonQuery();

                                if (rowsAffectedAccount <= 0)
                                {
                                    MessageBox.Show("Failed to insert expense into AccountTbl.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to add medicine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (dgvRequestedMedicine.SelectedRows.Count > 0)
                {
                 
                    DataGridViewRow selectedRow = dgvRequestedMedicine.SelectedRows[0];

                  
                    string customerName = selectedRow.Cells[0].Value.ToString();
                    string customerPhone = selectedRow.Cells[1].Value.ToString();
                    string medicineName = selectedRow.Cells[2].Value.ToString();
                    int medicineQuantity = Convert.ToInt32(selectedRow.Cells[3].Value);

                   
                    using (var con = DatabaseConnection.databaseConnect())
                    {
                        con.Open();

                       
                        string query = "DELETE FROM MedicineRequestTbl WHERE CustomerName = @CustomerName AND CustomerPhone = @CustomerPhone " +
                                       "AND MedicineName = @MedicineName AND MedicineQuantity = @MedicineQuantity";

                       
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@CustomerName", customerName);
                            cmd.Parameters.AddWithValue("@CustomerPhone", customerPhone);
                            cmd.Parameters.AddWithValue("@MedicineName", medicineName);
                            cmd.Parameters.AddWithValue("@MedicineQuantity", medicineQuantity);

                          
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Entry removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                              
                                dgvRequestedMedicine.Rows.Remove(selectedRow);
                            }
                            else
                            {
                                MessageBox.Show("Failed to remove entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            StaffDashboard staffDashboard = (StaffDashboard)this.ParentForm;
            staffDashboard.LoadBkashFormIntoMainPanel(new StaffInfoPanel());
            this.Hide();
        }
    }
}
