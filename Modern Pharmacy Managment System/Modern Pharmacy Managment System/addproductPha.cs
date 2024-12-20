using System;
using Modern_Pharmacy_Managment_System.Database;
using Modern_Pharmacy_Managment_System.Classes;
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
    public partial class addproductPha : Form
    {
        const string connectionString = @"Data Source=DESKTOP-ES6IRGF\MSSQLSERVER01;Initial Catalog=PMSnew;Integrated Security=True";
        public addproductPha()
        {
            InitializeComponent();
            ShowDataOnGrid();
            prdtview.CellClick += prdtview_CellClick;
            


        }
        private void ShowDataOnGrid()
        {
            try
            {
                
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string selectQuery = "SELECT * FROM InventoryTbl";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // Bind the DataTable to the DataGridView
                        prdtview.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void prdtview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = prdtview.Rows[e.RowIndex];

                // Retrieve the data from the selected row
                string productId = row.Cells["PId"].Value.ToString();
                string productName = row.Cells["PName"].Value.ToString();
                string companyName = row.Cells["PCompanyName"].Value.ToString();
                string genericName = row.Cells["PGeneric"].Value.ToString();
                string stock = row.Cells["PStock"].Value.ToString();
                string buyingPrice = row.Cells["PBuyingPrice"].Value.ToString();
                string sellingPrice = row.Cells["PSellingPrice"].Value.ToString();

                // Display the data in TextBoxes or other controls
                invprdIdplace.Text = productId;
                invPdrNameplace.Text = productName;
                invCompanyplace.Text = companyName;
                invGenericplace.Text = genericName;
                invStockplace.Text = stock;
                invSellingplace.Text = sellingPrice;
                invBuyingplace.Text = buyingPrice;
            }
        }

        private void ClearTextBoxes()
        {
            invprdIdplace.Clear();
            invPdrNameplace.Clear();
            invCompanyplace.Clear();
            invGenericplace.Clear();
            invStockplace.Clear();
            invSellingplace.Clear();
            invBuyingplace.Clear();
        }
        private void ShowDataOnGrid(string searchTerm = "")
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string selectQuery = "SELECT * FROM InventoryTbl";
                    // Add WHERE clause to filter results if search term is provided
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        selectQuery += " WHERE PId LIKE @SearchTerm OR PName LIKE @SearchTerm OR PCompanyName LIKE @SearchTerm OR PGeneric LIKE @SearchTerm";
                    }

                    using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                    {
                        // Add parameter for search term
                        if (!string.IsNullOrEmpty(searchTerm))
                        {
                            cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // Bind the DataTable to the DataGridView
                        prdtview.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void searchPrdt_TextChanged(object sender, EventArgs e)
        {
            /*string searchTerm = searchPrdt.Text.Trim();
            ShowDataOnGrid(searchTerm);*/
            string searchTerm = searchPrdt.Text.Trim();
            ShowDataOnGrid(searchTerm);

        }

        private void invAddbtn_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (invprdIdplace.Text == "" || invPdrNameplace.Text == "" || invCompanyplace.Text == "" || invGenericplace.Text == "" || invStockplace.Text == "" || invSellingplace.Text == "" || invBuyingplace.Text == "")
                {
                    MessageBox.Show("Empty field", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (decimal.Parse(invBuyingplace.Text.Trim()) > decimal.Parse(invSellingplace.Text.Trim()))
                {
                    MessageBox.Show("Buying price cannot be greater than selling price", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string checkProdName = "SELECT * FROM InventoryTbl WHERE PName = @PName";

                        using (SqlCommand checkPName = new SqlCommand(checkProdName, con))
                        {
                            checkPName.Parameters.AddWithValue("@PName", invPdrNameplace.Text.Trim());

                            SqlDataAdapter adp = new SqlDataAdapter(checkPName);
                            DataTable table = new DataTable();
                            adp.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(invPdrNameplace.Text.Trim() + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO InventoryTbl (PId, PName, PCompanyName, PGeneric, PStock, PBuyingPrice, PSellingPrice) VALUES (@PId, @PName, @PCompanyName, @PGeneric, @PStock, @PBuyingPrice, @PSellingPrice)";
                                using (SqlCommand cmd = new SqlCommand(insertData, con))
                                {
                                    cmd.Parameters.AddWithValue("@PId", invprdIdplace.Text.Trim());
                                    cmd.Parameters.AddWithValue("@PName", invPdrNameplace.Text.Trim());
                                    cmd.Parameters.AddWithValue("@PCompanyName", invCompanyplace.Text.Trim());
                                    cmd.Parameters.AddWithValue("@PGeneric", invGenericplace.Text.Trim());
                                    cmd.Parameters.AddWithValue("@PStock", invStockplace.Text.Trim());
                                    cmd.Parameters.AddWithValue("@PBuyingPrice", invBuyingplace.Text.Trim());
                                    cmd.Parameters.AddWithValue("@PSellingPrice", invSellingplace.Text.Trim());
                                    cmd.ExecuteNonQuery();
                                    //ClearF();
                                    ShowDataOnGrid();

                                    MessageBox.Show("Added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void invUpdatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (invprdIdplace.Text == "")
                {
                    MessageBox.Show("Please select a product to update", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string updateQuery = @"UPDATE InventoryTbl 
                                   SET PName = @PName, 
                                       PCompanyName = @PCompanyName, 
                                       PGeneric = @PGeneric, 
                                       PStock = @PStock, 
                                       PBuyingPrice = @PBuyingPrice, 
                                       PSellingPrice = @PSellingPrice 
                                   WHERE PId = @PId";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@PId", invprdIdplace.Text.Trim());
                        cmd.Parameters.AddWithValue("@PName", invPdrNameplace.Text.Trim());
                        cmd.Parameters.AddWithValue("@PCompanyName", invCompanyplace.Text.Trim());
                        cmd.Parameters.AddWithValue("@PGeneric", invGenericplace.Text.Trim());
                        cmd.Parameters.AddWithValue("@PStock", invStockplace.Text.Trim());
                        cmd.Parameters.AddWithValue("@PBuyingPrice", invBuyingplace.Text.Trim());
                        cmd.Parameters.AddWithValue("@PSellingPrice", invSellingplace.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Refresh the DataGridView after update
                            ShowDataOnGrid();
                        }
                        else
                        {
                            MessageBox.Show("No records updated", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void invDeletebtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (invprdIdplace.Text == "")
                {
                    MessageBox.Show("Please select a product to delete", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string deleteQuery = "DELETE FROM InventoryTbl WHERE PId = @PId";

                        using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@PId", invprdIdplace.Text.Trim());

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Product deleted successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Refresh the DataGridView after deletion
                                ShowDataOnGrid();
                                // Clear the TextBoxes after deletion
                                ClearTextBoxes();
                            }
                            else
                            {
                                MessageBox.Show("No records deleted", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void invClearbtn_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        
    }
}
