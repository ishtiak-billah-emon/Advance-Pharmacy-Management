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
    public partial class RequestedMedicine : Form
    {
        public RequestedMedicine()
        {
            InitializeComponent();
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
                // Create a DataTable to store the retrieved data
                DataTable dataTable = new DataTable();

                // Connect to the database
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();

                    // Query to retrieve data from the MedicinRequestTbl table
                    string query = "SELECT CustomerName, CustomerPhone, MedicineName, MedicineQuantity FROM MedicineRequestTbl";

                    // Execute the query and fill the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        adapter.Fill(dataTable);
                    }

                    con.Close();
                }

                // Bind the DataTable to the DataGridView
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
                // Get the data from the text boxes
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

                    // Query to insert a new row into the InventoryTbl table
                    string insertQuery = @"INSERT INTO InventoryTbl (PId, PName, PCompanyName, PGeneric, PStock, PBuyingPrice, PSellingPrice) 
                                   VALUES (@Pid, @Name, @CompanyName, @Generic, @Stock, @BuyingPrice, @SellingPrice)";

                    // Create a SqlCommand object and add parameters for inserting into InventoryTbl
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@Pid", pid);
                        insertCmd.Parameters.AddWithValue("@Name", name);
                        insertCmd.Parameters.AddWithValue("@CompanyName", companyName);
                        insertCmd.Parameters.AddWithValue("@Generic", generic);
                        insertCmd.Parameters.AddWithValue("@Stock", stock);
                        insertCmd.Parameters.AddWithValue("@BuyingPrice", buyingPrice);
                        insertCmd.Parameters.AddWithValue("@SellingPrice", sellingPrice);

                        // Execute the insert query
                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Medicine added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Optionally, clear the text boxes after successful insertion
                            ClearTextBoxes();

                            // Insert into AccountTbl
                            string insertAccountQuery = @"INSERT INTO AccountTbl (Expense, Date) VALUES (@Expense, @Date)";
                            using (SqlCommand insertAccountCmd = new SqlCommand(insertAccountQuery, con))
                            {
                                insertAccountCmd.Parameters.AddWithValue("@Expense", totalPrice);
                                insertAccountCmd.Parameters.AddWithValue("@Date", DateTime.Now);

                                // Execute the insert query for AccountTbl
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
                // Check if a row is selected
                if (dgvRequestedMedicine.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dgvRequestedMedicine.SelectedRows[0];

                    // Extract the relevant data from the selected row
                    string customerName = selectedRow.Cells[0].Value.ToString();
                    string customerPhone = selectedRow.Cells[1].Value.ToString();
                    string medicineName = selectedRow.Cells[2].Value.ToString();
                    int medicineQuantity = Convert.ToInt32(selectedRow.Cells[3].Value);

                    // Connect to the database
                    using (var con = DatabaseConnection.databaseConnect())
                    {
                        con.Open();

                        // Query to delete the selected entry from MedicinRequestTbl
                        string query = "DELETE FROM MedicineRequestTbl WHERE CustomerName = @CustomerName AND CustomerPhone = @CustomerPhone " +
                                       "AND MedicineName = @MedicineName AND MedicineQuantity = @MedicineQuantity";

                        // Create a SqlCommand object and add parameters
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@CustomerName", customerName);
                            cmd.Parameters.AddWithValue("@CustomerPhone", customerPhone);
                            cmd.Parameters.AddWithValue("@MedicineName", medicineName);
                            cmd.Parameters.AddWithValue("@MedicineQuantity", medicineQuantity);

                            // Execute the query
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Entry removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Remove the selected row from the DataGridView
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
