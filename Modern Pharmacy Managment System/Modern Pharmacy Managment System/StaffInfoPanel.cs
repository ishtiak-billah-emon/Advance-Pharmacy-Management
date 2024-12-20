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
using Modern_Pharmacy_Managment_System.Database;

namespace Modern_Pharmacy_Managment_System
{
    public partial class StaffInfoPanel : Form

    {  
        public StaffInfoPanel()
        {
            InitializeComponent();
            MedicineInfo();
            refreshInfo();
        }


        public void refreshInfo()
        {

            ShowTodaysMedicineSale();

            CountTotalInvoices();

            DateTimeLabel();

            showInformation();

            todaysSale();

            MedicineInfo();

            paymentType();

        }

        public void showInformation()
        {
            using (var con = DatabaseConnection.databaseConnect())
            {
                con.Open();

                // count total customer.
                SqlCommand cm = new SqlCommand("SELECT Count(*) From tbCustomer", con);
                var totalCustomer = cm.ExecuteScalar();
                if (int.Parse(totalCustomer.ToString()) < 10)
                {
                    totalCustomer = "0" + totalCustomer;
                }
                lblCustomerCount.Text = totalCustomer.ToString();
            
    
                // Check total medicine count
                SqlCommand cm2 = new SqlCommand("SELECT COUNT(*) FROM InventoryTbl", con);
                int totalMedicineCount = (int)cm2.ExecuteScalar();
                string totalMedicineDisplay = totalMedicineCount < 10 ? "0" + totalMedicineCount.ToString() : totalMedicineCount.ToString();
                lblMadiniceCount.Text = totalMedicineDisplay;
               // con.Close();


                // check total medicine requested.
                SqlCommand cm3 = new SqlCommand("SELECT COUNT(*) FROM MedicineRequestTbl", con);
                int totalRequestedMedicineCount = (int)cm3.ExecuteScalar();
                lblRequestedMedicine.Text = totalRequestedMedicineCount < 10 ? "0" + totalRequestedMedicineCount.ToString() : totalRequestedMedicineCount.ToString();
                con.Close();
            }
        }

        public void MedicineInfo()
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();

                    // Check for medicine shortage
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM InventoryTbl WHERE PStock < 50", con);
                    int shortageCount = (int)cmd.ExecuteScalar();
                    string shortageCountDisplay = shortageCount < 10 ? "0" + shortageCount.ToString() : shortageCount.ToString();
                    lblMadicineShortage.Text = shortageCountDisplay;

                    // If shortage, insert details into MedicineShortageTbl if not already there
                    if (shortageCount > 0)
                    {
                        SqlCommand insertCmd = new SqlCommand(@"INSERT INTO MedicineShortageTbl (SId, SName, SQuantity, SBuyingPrice)
                                                    SELECT PId, PName, PStock, PBuyingPrice 
                                                    FROM InventoryTbl 
                                                    WHERE PStock < 50 AND PId NOT IN (SELECT SId FROM MedicineShortageTbl)", con);
                        int rowsInserted = insertCmd.ExecuteNonQuery();
                        //MessageBox.Show(rowsInserted + " medicine(s) added to MedicineShortageTbl.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }

        private void ShowTodaysMedicineSale()
        {
            try
            {
               
                DateTime today = DateTime.Today;

                
                int empId = Login.EmpId;

                
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();

                    
                    SqlCommand cmd = new SqlCommand("SELECT ISNULL(SUM(TotalOrders), 0) FROM AccountTbl WHERE CONVERT(date, Date) = @Today AND EmpId = @EmpId", con);
                    cmd.Parameters.AddWithValue("@Today", today);
                    cmd.Parameters.AddWithValue("@EmpId", empId);

                   
                    object result = cmd.ExecuteScalar();
                    int todaysTotalMedicineSale = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                    // Display the result in lblTodaysMedicineSale
                    lblTodaysMedicineSale.Text = todaysTotalMedicineSale.ToString();

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void CountTotalInvoices()
        {
            try
            {
                // Total invoices count
                int totalInvoicesCount = 0;

                // Todays total invoices count
                int todaysTotalInvoicesCount = 0;

                // Get today's date
                DateTime today = DateTime.Today;

                // Get the employee ID
                int empId = Login.EmpId;

              
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();

                    
                    SqlCommand totalInvoicesCmd = new SqlCommand("SELECT COUNT(*) FROM AccountTbl WHERE TotalOrders IS NOT NULL AND Date IS NOT NULL AND EmpId = @EmpId", con);
                    totalInvoicesCmd.Parameters.AddWithValue("@EmpId", empId);
                    totalInvoicesCount = (int)totalInvoicesCmd.ExecuteScalar();

                    // Query to count today's total invoices
                    SqlCommand todaysTotalInvoicesCmd = new SqlCommand("SELECT COUNT(*) FROM AccountTbl WHERE TotalOrders IS NOT NULL AND Date = @Today AND EmpId = @EmpId", con);
                    todaysTotalInvoicesCmd.Parameters.AddWithValue("@Today", today);
                    todaysTotalInvoicesCmd.Parameters.AddWithValue("@EmpId", empId);
                    todaysTotalInvoicesCount = (int)todaysTotalInvoicesCmd.ExecuteScalar();
                }
                lblTotalInvoices.Text = todaysTotalInvoicesCount.ToString();
                // Display total invoices count and today's total invoices count
                // MessageBox.Show($"Total Invoices: {totalInvoicesCount}\nToday's Total Invoices: {todaysTotalInvoicesCount}", "Invoice Count", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void todaysSale()
        {
            try
            {
                
                DateTime today = DateTime.Today;

                // Get the employee ID
                int empId = Login.EmpId;

                
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();

                    
                    SqlCommand cmd = new SqlCommand("SELECT ISNULL(SUM(Revenue), 0) FROM AccountTbl WHERE CONVERT(date, Date) = @Today AND EmpId = @EmpId", con);
                    cmd.Parameters.AddWithValue("@Today", today);
                    cmd.Parameters.AddWithValue("@EmpId", empId);

                  
                    object result = cmd.ExecuteScalar();
                    int todaysTotalMedicineSale = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                  
                    lblSellingAmount.Text = todaysTotalMedicineSale.ToString();

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void paymentType()
        {
            try
            {
               
                DateTime today = DateTime.Today;

                
                double cashSum = 0;
                double bkashSum = 0;

                
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();

                   
                    SqlCommand cashCmd = new SqlCommand("SELECT ISNULL(SUM(Revenue), 0) FROM AccountTbl WHERE CONVERT(date, Date) = @Today AND CustomerPhone IS NULL AND EmpId = @EmpId", con);
                    cashCmd.Parameters.AddWithValue("@Today", today);
                    cashCmd.Parameters.AddWithValue("@EmpId", Login.EmpId);
                    object cashResult = cashCmd.ExecuteScalar();
                    cashSum = cashResult != DBNull.Value ? Convert.ToDouble(cashResult) : 0;

                    
                    SqlCommand bkashCmd = new SqlCommand("SELECT ISNULL(SUM(Revenue), 0) FROM AccountTbl WHERE CONVERT(date, Date) = @Today AND CustomerPhone IS NOT NULL AND EmpId = @EmpId", con);
                    bkashCmd.Parameters.AddWithValue("@Today", today);
                    bkashCmd.Parameters.AddWithValue("@EmpId", Login.EmpId);
                    object bkashResult = bkashCmd.ExecuteScalar();
                    bkashSum = bkashResult != DBNull.Value ? Convert.ToDouble(bkashResult) : 0;

                  
                    lblCash.Text = cashSum.ToString();
                    lblBkash.Text = bkashSum.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void DateTimeLabel()
        {
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            StaffDashboard staffDashboard = (StaffDashboard)this.ParentForm;
            staffDashboard.LoadBkashFormIntoMainPanel(new addproductPha());
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            StaffDashboard staffDashboard = (StaffDashboard)this.ParentForm;
            staffDashboard.LoadBkashFormIntoMainPanel(new CustomerForm());
            this.Hide();
        }

        private void btnMedicineShortage_Click(object sender, EventArgs e)
        {


          //  MedicineShortage ms = new MedicineShortage();
          //  ms.Show();

            StaffDashboard staffDashboard = (StaffDashboard)this.ParentForm;
            staffDashboard.LoadBkashFormIntoMainPanel(new MedicineShortage());
            this.Hide();

        }

        private void guna2Panel14_Paint(object sender, PaintEventArgs e)
        {
            //pnale
        }

        private void lblMedicineRequestedList_Click(object sender, EventArgs e)
        {

            StaffDashboard staffDashboard = (StaffDashboard)this.ParentForm;
            staffDashboard.LoadBkashFormIntoMainPanel(new RequestedMedicin());
            this.Hide();

         
        }
    }
}
