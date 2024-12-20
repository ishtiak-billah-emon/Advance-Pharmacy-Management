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
    public partial class inventorydemo : UserControl
    {
        const string connectionString = @"Data Source=Akid\SQLEXPRESS;Initial Catalog=PMSnew;Integrated Security=True";
        public inventorydemo()
        {
            InitializeComponent();
            InitializeComponent();
            ShowDataOnGrid();
            prdctview.CellClick += prdctview_CellClick;
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
                        prdctview.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        prdctview.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void invcAddbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (invcprdIdplace.Text == "" || invPcdrNameplace.Text == "" || invcCompanyplace.Text == "" || invcGenericplace.Text == "" || invcStockplace.Text == "" || invcSellingplace.Text == "" || invcBuyingplace.Text == "")
                {
                    MessageBox.Show("Empty field", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string checkProdId = "SELECT * FROM InventoryTbl WHERE PId = @PId";

                        using (SqlCommand checkPID = new SqlCommand(checkProdId, con))
                        {
                            checkPID.Parameters.AddWithValue("@PId", invcprdIdplace.Text.Trim());

                            SqlDataAdapter adp = new SqlDataAdapter(checkPID);
                            DataTable table = new DataTable();
                            adp.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(invcprdIdplace.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO InventoryTbl (PId, PName, PCompanyName, PGeneric, PStock, PBuyingPrice, PSellingPrice) VALUES (@PId, @PName, @PCompanyName, @PGeneric, @PStock, @PBuyingPrice, @PSellingPrice)";
                                using (SqlCommand cmd = new SqlCommand(insertData, con))
                                {
                                    cmd.Parameters.AddWithValue("@PId", invcprdIdplace.Text.Trim());
                                    cmd.Parameters.AddWithValue("@PName", invPcdrNameplace.Text.Trim());
                                    cmd.Parameters.AddWithValue("@PCompanyName", invcCompanyplace.Text.Trim());
                                    cmd.Parameters.AddWithValue("@PGeneric", invcGenericplace.Text.Trim());
                                    cmd.Parameters.AddWithValue("@PStock", invcStockplace.Text.Trim());
                                    cmd.Parameters.AddWithValue("@PBuyingPrice", invcBuyingplace.Text.Trim());
                                    cmd.Parameters.AddWithValue("@PSellingPrice", invcSellingplace.Text.Trim());
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

        private void invcUpdatebtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (invcprdIdplace.Text == "")
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
                        cmd.Parameters.AddWithValue("@PId", invcprdIdplace.Text.Trim());
                        cmd.Parameters.AddWithValue("@PName", invPcdrNameplace.Text.Trim());
                        cmd.Parameters.AddWithValue("@PCompanyName", invcCompanyplace.Text.Trim());
                        cmd.Parameters.AddWithValue("@PGeneric", invcGenericplace.Text.Trim());
                        cmd.Parameters.AddWithValue("@PStock", invcStockplace.Text.Trim());
                        cmd.Parameters.AddWithValue("@PBuyingPrice", invcBuyingplace.Text.Trim());
                        cmd.Parameters.AddWithValue("@PSellingPrice", invcSellingplace.Text.Trim());

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

        private void invcDeletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (invcprdIdplace.Text == "")
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
                            cmd.Parameters.AddWithValue("@PId", invcprdIdplace.Text.Trim());

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

        private void ClearTextBoxes()
        {
            invcprdIdplace.Clear();
            invPcdrNameplace.Clear();
            invcCompanyplace.Clear();
            invcGenericplace.Clear();
            invcStockplace.Clear();
            invcSellingplace.Clear();
            invcBuyingplace.Clear();
        }

        private void invcClearbtn_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void prdctview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = prdctview.Rows[e.RowIndex];

                // Retrieve the data from the selected row
                string productId = row.Cells["PId"].Value.ToString();
                string productName = row.Cells["PName"].Value.ToString();
                string companyName = row.Cells["PCompanyName"].Value.ToString();
                string genericName = row.Cells["PGeneric"].Value.ToString();
                string stock = row.Cells["PStock"].Value.ToString();
                string buyingPrice = row.Cells["PBuyingPrice"].Value.ToString();
                string sellingPrice = row.Cells["PSellingPrice"].Value.ToString();

                // Display the data in TextBoxes or other controls
                invcprdIdplace.Text = productId;
                invPcdrNameplace.Text = productName;
                invcCompanyplace.Text = companyName;
                invcGenericplace.Text = genericName;
                invcStockplace.Text = stock;
                invcSellingplace.Text = sellingPrice;
                invcBuyingplace.Text = buyingPrice;
            }
        }
    }
}
