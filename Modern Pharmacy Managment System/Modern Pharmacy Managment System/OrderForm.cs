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
using System.Data;
using System.Data.SqlClient;


namespace Modern_Pharmacy_Managment_System
{

    public partial class OrderForm : Form
    {
        Functions con;


        Double grandTotal;
        private bool rewardUsed = false;
        private bool isCustomer = false;
        public OrderForm()
        {
            InitializeComponent();
            con = new Functions();
            Login login = Login.GetInstance();
            string customerPhone = login.getCustomerPhone();
            customerPanel.Visible = false;

            if (!string.IsNullOrEmpty(customerPhone))
            {
                // customerPhone is not empty
                lblCustomerPhone.Text = customerPhone;
                txtCustomerName.Visible = false;
                btnAdd.Visible = false;
                btnPay.Visible = false;
                customerPanel.Visible = true;
                txtCPhone.Text = customerPhone;
                isCustomer = true;
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();
                    string query = "SELECT cname FROM tbCustomer WHERE cphone = @cphone";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@cphone", txtCPhone.Text);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {

                        txtCName.Text = result.ToString();
                        getRewards();

                    }
                    else
                    {
                        txtCName.Text = "";
                    }
                }


            }
            else
            {
                // customerPhone is empty
                //lblCustomerPhone.Text = "Employee";
                customerPanel.Visible = false;
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            showProduct();
            showOrder();
            UpdateTotalAmount();
        }

        private void showProduct()
        {
            string Query = "SELECT PId, PName, PSellingPrice, PStock FROM InventoryTbl";
            dgvProduct.DataSource = con.GetData(Query);
        }

        private void showOrder()
        {
            string Query = "SELECT OId, OName, OUnit, OPrice, OTotalCost FROM OrderTbl";
            dgvOrder.DataSource = con.GetData(Query);
        }

        private void UpdateTotalAmount()
        {
            // Calculate the total amount
            decimal totalAmount = CalculateTotalAmount();

            // Display the total amount in the txtTotalAmount textbox
            txtTotalAmount.Text = totalAmount.ToString();
            txtGrandTotal.Text = totalAmount.ToString();

        }

        private decimal CalculateTotalAmount()
        {
            decimal totalAmount = 0;

            // sum of the OTotalCost
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                totalAmount += Convert.ToDecimal(row.Cells[4].Value);
            }

            return totalAmount;
        }

        private void getRewards()
        {

            try
            {
                
                string customerPhoneNumber = txtCPhone.Text.Trim();


                
                string query = "SELECT cpoints FROM tbCustomer WHERE cphone = @customerPhoneNumber";

                
                using (var con = DatabaseConnection.databaseConnect())
                {
                    
                    con.Open();

                   
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                       
                        cmd.Parameters.AddWithValue("@customerPhoneNumber", customerPhoneNumber);

                        
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            
                            int rewards = Convert.ToInt32(result);

                           
                            txtRewards.Text = rewards.ToString();


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdateRewardsPoints(double newRewards)
        {
            try
            {
                string customerPhoneNumber = txtCPhone.Text;

               
                string query = "UPDATE tbCustomer SET cpoints =  @newRewards WHERE cphone = @customerPhoneNumber";

               
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@newRewards", newRewards);
                cmd.Parameters.AddWithValue("@customerPhoneNumber", customerPhoneNumber);

              
                int rowsAffected = con.insertData(cmd);

                if (rowsAffected > 0)
                {

                    MessageBox.Show("Rewards Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to Update rewards.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int CalculateTotalUnits()
        {
            int totalUnits = 0;

            // sum of the OUnit
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                totalUnits += Convert.ToInt32(row.Cells[2].Value);
            }

            return totalUnits;
        }

        public void RemoveOrder()
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();

                    
                    string selectOrdersQuery = "SELECT OName, OUnit FROM OrderTbl";
                    SqlCommand selectOrdersCmd = new SqlCommand(selectOrdersQuery, con);

                    // Create a list to store the data
                    List<Tuple<string, int>> orders = new List<Tuple<string, int>>();

                  
                    using (SqlDataReader reader = selectOrdersCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string productName = reader.GetString(0);
                            int orderUnit = reader.GetInt32(1);
                            orders.Add(new Tuple<string, int>(productName, orderUnit));
                        }
                    }

                   
                    selectOrdersCmd.Dispose();

                    // Restock each medicine in InventoryTbl
                    foreach (var order in orders)
                    {
                        string productName = order.Item1;
                        int orderUnit = order.Item2;

                        // Restock the medicine in InventoryTbl
                        string restockQuery = "UPDATE InventoryTbl SET PStock = PStock + @OrderUnit WHERE PName = @ProductName";
                        SqlCommand restockCmd = new SqlCommand(restockQuery, con);
                        restockCmd.Parameters.AddWithValue("@OrderUnit", orderUnit);
                        restockCmd.Parameters.AddWithValue("@ProductName", productName);
                        restockCmd.ExecuteNonQuery();
                    }

                    // Remove all records from OrderTbl
                    string clearOrderQuery = "DELETE FROM OrderTbl";
                    SqlCommand clearOrderCmd = new SqlCommand(clearOrderQuery, con);
                    clearOrderCmd.ExecuteNonQuery();

                    MessageBox.Show("All medicines removed from the order and restocked.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
            showOrder();
            showProduct();
            UpdateTotalAmount();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            CustomerManagementForm moduleForm = new CustomerManagementForm();
            moduleForm.btnSave.Enabled = true;
            moduleForm.btnUpdate.Enabled = false;
            moduleForm.ShowDialog();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {


            int unit;
            if (!int.TryParse(txtUnit.Text, out unit))
            {
                MessageBox.Show("Please enter a valid quantity");
                return;
            }

            if (string.IsNullOrEmpty(txtUnit.Text) || txtUnit.Text == "Amount want to buy" || unit <= 0)
            {
                MessageBox.Show("Please enter the quantity");
                return;
            }

            try
            {


                if (dgvProduct.SelectedRows.Count > 0)
                {
                  
                    DataGridViewRow selectedRow = dgvProduct.SelectedRows[0];

                 
                    int productId = Convert.ToInt32(selectedRow.Cells[0].Value);
                    string productName = selectedRow.Cells[1].Value.ToString();
                    int availableStock = Convert.ToInt32(selectedRow.Cells[3].Value);
                    decimal sellingPrice = Convert.ToDecimal(selectedRow.Cells[2].Value);
                    

                    if (unit > availableStock)
                    {
                        MessageBox.Show("Not Enough available stock!!");
                        return;
                    }

                    // Calculate the total cost
                    decimal totalCost = sellingPrice * unit;

                    
                    DateTime defaultDate = DateTime.Now;

                    // Insert into the OrderTbl
                    string insertOrderQuery = "INSERT INTO OrderTbl (OName, OPrice, OUnit, OTotalCost, ODate) VALUES (@OName, @OPrice, @OUnit, @OTotalCost, @ODate)";
                    SqlCommand insertCmd = new SqlCommand(insertOrderQuery);
                    insertCmd.Parameters.AddWithValue("@OName", productName);
                    insertCmd.Parameters.AddWithValue("@OPrice", sellingPrice);
                    insertCmd.Parameters.AddWithValue("@OUnit", unit);
                    insertCmd.Parameters.AddWithValue("@OTotalCost", totalCost);
                    insertCmd.Parameters.AddWithValue("@ODate", defaultDate);

                    int rowsAffectedInsert = con.insertData(insertCmd);

                    // Check if the insert was successful
                    if (rowsAffectedInsert > 0)
                    {
                        
                        showProduct();
                        showOrder();

                       
                        txtUnit.Text = "";

                       
                        UpdateTotalAmount();
                    }
                    else
                    {
                        
                        MessageBox.Show("Failed to add product to cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    // Decrease stock in the InventoryTbl

                    SqlCommand cmdUpdate = new SqlCommand("UPDATE InventoryTbl SET PStock = PStock - @Unit WHERE PId = @ProductId");
                    cmdUpdate.Parameters.AddWithValue("@Unit", unit);
                    cmdUpdate.Parameters.AddWithValue("@ProductId", productId);
                    con.insertData(cmdUpdate);

                    showProduct();
                    showOrder();

                    // Update the total amount

                    UpdateTotalAmount();

                }
                else
                {
                  
                     MessageBox.Show("Please select a product to add to cart!", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            if (dgvOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a medicine to remove.", "No Medicine Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            DataGridViewRow selectedRow = dgvOrder.SelectedRows[0];

            
            int orderId = Convert.ToInt32(selectedRow.Cells[0].Value);
            string productName = Convert.ToString(selectedRow.Cells[1].Value);
            int orderUnit = Convert.ToInt32(selectedRow.Cells[2].Value);

            // Remove the order from OrderTbl
            SqlCommand removeCmd = new SqlCommand("DELETE FROM OrderTbl WHERE OId = @OrderId");
            removeCmd.Parameters.AddWithValue("@OrderId", orderId);

            // Update PStock in InventoryTbl
            SqlCommand updateCmd = new SqlCommand("UPDATE InventoryTbl SET PStock = PStock + @OrderUnit WHERE PName = @ProductName");
            updateCmd.Parameters.AddWithValue("@OrderUnit", orderUnit);
            updateCmd.Parameters.AddWithValue("@ProductName", productName);

            try
            {
                con.insertData(removeCmd);
                con.insertData(updateCmd);
                MessageBox.Show("Medicine removed from the order.", "Medicine Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

         
            showOrder();
            showProduct();
            UpdateTotalAmount();
        }

        private void txtSearchMedicine_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchMedicine.Text.Trim();

            DataTable tableSchema = con.GetData("SELECT TOP 1 * FROM InventoryTbl");
            string columnName = tableSchema.Columns[1].ColumnName;

            
            string Query = $"SELECT PId, PName, PSellingPrice, PStock FROM InventoryTbl WHERE [{columnName}] LIKE '%{searchText}%'";

            
            dgvProduct.DataSource = con.GetData(Query);
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtCustomerName.Text.Trim();
            string query = "SELECT cname FROM tbCustomer WHERE cphone LIKE @searchText";

            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        txtCName.Text = result.ToString();
                        txtCPhone.Text = searchText;
                        getRewards();
                    }
                    else
                    {
                        txtCName.Text = "Customer not found!";
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
           
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            if (dgvOrder.Rows.Count == 0)
            {
                MessageBox.Show("There are no items in the order to pay for.", "Empty Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            ///////////////////////////           Rewards Points add                 ///////////////////////////

            try
            {
                double totalAmount;
                if (rewardUsed == false)
                {
                    txtGrandTotal.Text = txtTotalAmount.Text;
                    totalAmount = Convert.ToDouble(txtGrandTotal.Text);
                }
                else
                {
                    totalAmount = Convert.ToDouble(txtGrandTotal.Text);
                }

                // Calculate rewards
                int rewards = (int)totalAmount / 2;

                // Get the customer phone number from txtCPhone
                string customerPhoneNumber = txtCPhone.Text.Trim();

                // SQL query to update cpoints for the customer
                string query = "UPDATE tbCustomer SET cpoints = cpoints + @rewards WHERE cphone = @customerPhoneNumber";
               
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@rewards", rewards);
                cmd.Parameters.AddWithValue("@customerPhoneNumber", customerPhoneNumber);

               
                int rowsAffected = con.insertData(cmd);

               
                if (rowsAffected > 0)
                {
                    getRewards();

                   // MessageBox.Show("Rewards added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //MessageBox.Show("Failed to add rewards.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            /////////////////////////////                  PAYMENT METHOD         ///////////////////////////

            int totalUnits = CalculateTotalUnits();

            try
            {
                


                // Check if txtGrandTotal is not empty and contains valid data
                if (double.TryParse(txtGrandTotal.Text, out grandTotal))
                {
                    // Get the current date
                    DateTime currentDate = DateTime.Now;

                    // Insert into the accountTbl
                    int EmployeeID = Login.EmpId;
                    string CustomerPhone = txtCPhone.Text;

                    string insertAccountQuery = "INSERT INTO AccountTbl (TotalOrders, Revenue, Date, EmpId, CustomerPhone) VALUES (@TotalOrders, @Revenue, @Date, @EmpId, @CustomerPhone)";
                    SqlCommand insertAccountCmd = new SqlCommand(insertAccountQuery);
                    insertAccountCmd.Parameters.AddWithValue("@TotalOrders", totalUnits);
                    insertAccountCmd.Parameters.AddWithValue("@Revenue", grandTotal);
                    insertAccountCmd.Parameters.AddWithValue("@Date", currentDate);
                    insertAccountCmd.Parameters.AddWithValue("@EmpId", EmployeeID);
                    insertAccountCmd.Parameters.AddWithValue("@CustomerPhone", CustomerPhone);

                    int rowsAffectedInsertAccount = con.insertData(insertAccountCmd);

                    // Check if the insert was successful
                    if (rowsAffectedInsertAccount > 0)
                    {
                      //  MessageBox.Show("Revenue added to account successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                       // MessageBox.Show("Failed to add revenue to account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                    MessageBox.Show("Total amount is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            /////////////////////////////////////////////////////////////////////////////////////////////////


            // Clear the order table
            SqlCommand clearOrderCmd = new SqlCommand("DELETE FROM OrderTbl");
            try
            {
                con.insertData(clearOrderCmd);
               // informationMessage.Show("Payment successful!");
                ShowCustomMessageBox("Payment successful! Order cleared.", "Neuron Pharma");

                // MessageBox.Show("Payment successful! Order cleared.", "Payment Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Clear TextBox
            txtCustomerName.Text = "";
            txtCName.Text = "";
            txtCPhone.Text = "";
            txtRewards.Text = "";
            txtGrandTotal.Text = "";
            txtTotalAmount.Text = "";

            // Refresh the dgvOrder and product list
            showOrder();
            showProduct();
            //UpdateTotalAmount();

            // update new order form
            rewardUsed = false;
        }

        private void btnUseReward_Click_1(object sender, EventArgs e)
        {
            rewardUsed = true;
               
            if (txtRewards.Text == "")
            {
                //MessageBox.Show("Choose a ")
                //informationMessage.Show("Invalid Phone Number");
                MessageBox.Show("Invalid Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            try
            {
                // Get the rewards points from txtRewards
                int rewards = Convert.ToInt32(txtRewards.Text);

                // Check if rewards points is greater than or equal to 100
                if (rewards >= 100)
                {
                    // Convert txtTotalAmount to double
                    double totalAmount = Convert.ToDouble(txtTotalAmount.Text);

                    // Calculate the discount amount based on rewards points
                    double discountAmount = rewards * 0.10;

                    // Check if totalAmount is less than discountAmount
                    if (totalAmount < discountAmount)
                    {
                        // Set txtGrandTotal to 0
                        txtGrandTotal.Text = "0";



                        // Update the rewards points in the database
                        double newRewards = rewards - (totalAmount * 10);
                        UpdateRewardsPoints(newRewards);
                        txtRewards.Text = newRewards.ToString();
                    }
                    else if (totalAmount >= discountAmount)
                    {
                        // Calculate the grand total after discount
                          grandTotal = totalAmount - discountAmount;

                        // Set txtGrandTotal to grandTotal
                        txtGrandTotal.Text = grandTotal.ToString();

                        // Update the rewards points in the database

                        UpdateRewardsPoints(0);
                        txtRewards.Text = "0.0";
                    }
                }
                else
                {
                    // Insufficient rewards points
                    MessageBox.Show("Insufficient rewards points. Minimum 100 points required to use rewards.", "Insufficient Points", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
              //  MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBkash_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrder.SelectedRows.Count == 0)
                {
                    MessageBox.Show("There is no medicine .", "Neuron Pharma", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (isCustomer == false)
                {
                    
                    StaffDashboard staffDashboard = (StaffDashboard)this.ParentForm;
                    int totalUnit = CalculateTotalUnits();

                   
                    staffDashboard.LoadBkashFormIntoMainPanel(new Bkash(txtGrandTotal.Text, totalUnit, "Employee"));

                   
                    this.Hide();
                }
                else
                {
                    
                    CustomerDashboard db = (CustomerDashboard)this.ParentForm;
                    int totalUnit = CalculateTotalUnits();
                    
                    db.LoadBkashFormIntoMainPanel(new Bkash(txtGrandTotal.Text, totalUnit, "Customer"));

                 
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ShowCustomMessageBox(string message, string title)
        {
            Form customMessageBox = new Form();
            customMessageBox.StartPosition = FormStartPosition.CenterParent;
            customMessageBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            customMessageBox.BackColor = Color.DodgerBlue;

           
            customMessageBox.Size = new Size(300, 150);

            Label label = new Label();
            label.Text = message;
            label.AutoSize = true;
            label.Location = new Point(20, 20);
            label.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            customMessageBox.Controls.Add(label);

            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.BackColor = Color.DodgerBlue;
            okButton.ForeColor = Color.Black;
            okButton.Location = new Point(140, 60);
            okButton.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            customMessageBox.Controls.Add(okButton);

            customMessageBox.Text = title;

            customMessageBox.AcceptButton = okButton;

            DialogResult result = customMessageBox.ShowDialog();
            if (result == DialogResult.OK)
            {
                customMessageBox.Close();
            }
        }

        
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            Font headingFont = new Font("Arial", 16, FontStyle.Bold);
            Font normalFont = new Font("Arial", 12, FontStyle.Regular);

            
            int startX = 10;
            int startY = 10;
            int offsetY = 50;

            
            string invoiceText = "INVOICE";
            SizeF textSize = e.Graphics.MeasureString(invoiceText, headingFont);
            float centerX = (e.PageBounds.Width - textSize.Width) / 2;
            e.Graphics.DrawString(invoiceText, headingFont, Brushes.Black, centerX, startY);
            string HEadText = "Nuron pharma";
            e.Graphics.DrawString(HEadText, headingFont, Brushes.Black, 350, 30);

            string orderQuery = "SELECT * FROM OrderTbl WHERE ODate = @OrderDate";
            using (var con = DatabaseConnection.databaseConnect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(orderQuery, con);
                cmd.Parameters.AddWithValue("@OrderDate", DateTime.Today); 
                SqlDataReader reader = cmd.ExecuteReader();

                
                while (reader.Read())
                {
         
                    e.Graphics.DrawString($"Product Name: {reader["OName"]}", normalFont, Brushes.Black, startX, startY + offsetY);
                    offsetY += 40;
                    e.Graphics.DrawString($"Price: {reader["OPrice"]}", normalFont, Brushes.Black, startX, startY + offsetY);
                    offsetY += 20;
                    e.Graphics.DrawString($"Quantity: {reader["OUnit"]}", normalFont, Brushes.Black, startX, startY + offsetY);
                    offsetY += 20;
                    e.Graphics.DrawString($"Total Cost: {reader["OTotalCost"]}", normalFont, Brushes.Black, startX, startY + offsetY);
                    offsetY += 20;
                    e.Graphics.DrawString($"Date: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}", normalFont, Brushes.Black, startX, startY + offsetY);
                    offsetY += 40;
                   
                }
                e.Graphics.DrawString($"GrandTotal {txtGrandTotal.Text}", headingFont, Brushes.Black, 500, startY + offsetY);
                offsetY += 20;
                e.Graphics.DrawString($"PAID", headingFont, Brushes.Black, 500, startY + offsetY);
                offsetY += 20;
                e.Graphics.DrawString($"Customer Phone: {txtCPhone.Text}", normalFont, Brushes.Black, 500, startY + offsetY);
                offsetY += 20;
                e.Graphics.DrawString($"Customer Name: {txtCName.Text}", normalFont, Brushes.Black, 500, startY + offsetY);
                offsetY += 20;
                e.Graphics.DrawString($"Reward Point: {txtRewards.Text}", normalFont, Brushes.Black, 500, startY + offsetY);
                offsetY += 20;
                reader.Close();

            }
        }
    }
}
