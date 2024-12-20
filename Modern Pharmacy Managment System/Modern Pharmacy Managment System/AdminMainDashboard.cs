using Modern_Pharmacy_Managment_System.Database;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Modern_Pharmacy_Managment_System
{
    public partial class AdminMainDashboard : Form
    {
        public AdminMainDashboard()
        {
            InitializeComponent();
            DisplayTotalRevenueOrdersAndExpense();
            PopulateRevenueChart();
            PopulateLeaveCount();
            PopulateEmployeeCount();
            CountshowInformation();
            //PopulateUnpaidEmployeeCount();
        }

        

        private void PopulateRevenueChart(bool filterToday = false, bool filterLast7Days = false, bool filterLast30Days = false, bool filterLastYear = false, DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();
                    string query = "SELECT Date, SUM(Revenue) AS TotalRevenue FROM [PMSnew].[dbo].[AccountTbl] WHERE 1 = 1";

                    
                    if (filterToday)
                    {
                        query += " AND CONVERT(date, Date) = CONVERT(date, GETDATE())";
                    }
                    else if (filterLast7Days)
                    {
                        query += " AND Date >= DATEADD(day, -6, CONVERT(date, GETDATE())) AND Date <= CONVERT(date, GETDATE())";
                    }
                    else if (filterLast30Days)
                    {
                        query += " AND Date >= DATEADD(day, -29, CONVERT(date, GETDATE())) AND Date <= CONVERT(date, GETDATE())";
                    }
                    else if (filterLastYear)
                    {
                        query += " AND Date >= DATEADD(year, -1, CONVERT(date, GETDATE())) AND Date <= CONVERT(date, GETDATE())";
                    }
                    else if (startDate != null && endDate != null)
                    {
                        query += $" AND Date >= @StartDate AND Date <= @EndDate";
                    }

                    query += " GROUP BY Date ORDER BY Date";

                    SqlCommand cm = new SqlCommand(query, con);

                    if (startDate != null && endDate != null)
                    {
                        cm.Parameters.AddWithValue("@StartDate", startDate.Value.Date);
                        cm.Parameters.AddWithValue("@EndDate", endDate.Value.Date);
                    }

                    SqlDataReader reader = cm.ExecuteReader();

                    
                    RevenueChart.Series["Revenue"].Points.Clear();

                    while (reader.Read())
                    {
                        DateTime date;
                        double totalRevenue;

                       
                        if (!reader.IsDBNull(reader.GetOrdinal("Date")))
                        {
                            date = Convert.ToDateTime(reader["Date"]);
                        }
                        else
                        {
                            
                            continue;
                        }

                        
                        if (!reader.IsDBNull(reader.GetOrdinal("TotalRevenue")))
                        {
                            totalRevenue = Convert.ToDouble(reader["TotalRevenue"]);
                        }
                        else
                        {
                            
                            continue;
                        }

                        
                        RevenueChart.Series["Revenue"].Points.AddXY(date, totalRevenue);
                    }

                    reader.Close();
                }

                
                RevenueChart.ChartAreas[0].AxisX.Interval = 1; 
                RevenueChart.ChartAreas[0].AxisX.LabelStyle.Format = "d MMM yyyy"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void DisplayTotalRevenueOrdersAndExpense(bool filterToday = false, bool filterLast7Days = false, bool filterLast30Days = false, bool filterLastYear = false, DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();
                    string query = "SELECT SUM(Revenue) AS TotalRevenue, SUM(TotalOrders) AS TotalOrders, SUM(Expense) AS TotalExpense, SUM(NetIncome) AS TotalNetIncome FROM [PMSnew].[dbo].[AccountTbl] WHERE 1 = 1";

                    
                    if (filterToday)
                    {
                        query += " AND CONVERT(date, Date) = CONVERT(date, GETDATE())";
                    }
                    else if (filterLast7Days)
                    {
                        query += " AND Date >= DATEADD(day, -6, CONVERT(date, GETDATE())) AND Date <= CONVERT(date, GETDATE())";
                    }
                    else if (filterLast30Days)
                    {
                        query += " AND Date >= DATEADD(day, -29, CONVERT(date, GETDATE())) AND Date <= CONVERT(date, GETDATE())";
                    }
                    else if (filterLastYear)
                    {
                        query += " AND Date >= DATEADD(year, -1, CONVERT(date, GETDATE())) AND Date <= CONVERT(date, GETDATE())";
                    }
                    else if (startDate != null && endDate != null)
                    {
                        query += $" AND Date >= @StartDate AND Date <= @EndDate";
                    }

                    SqlCommand cm = new SqlCommand(query, con);

                    if (startDate != null && endDate != null)
                    {
                        cm.Parameters.AddWithValue("@StartDate", startDate.Value.Date);
                        cm.Parameters.AddWithValue("@EndDate", endDate.Value.Date);
                    }

                    SqlDataReader reader = cm.ExecuteReader();

                    
                    if (reader.Read())
                    {
                        
                        double totalRevenue = reader.IsDBNull(reader.GetOrdinal("TotalRevenue")) ? 0 : reader.GetDouble(reader.GetOrdinal("TotalRevenue"));
                        int totalOrders = reader.IsDBNull(reader.GetOrdinal("TotalOrders")) ? 0 : reader.GetInt32(reader.GetOrdinal("TotalOrders"));
                        double totalExpense = reader.IsDBNull(reader.GetOrdinal("TotalExpense")) ? 0 : reader.GetDouble(reader.GetOrdinal("TotalExpense"));
                        double totalNetIncome = reader.IsDBNull(reader.GetOrdinal("TotalNetIncome")) ? 0 : reader.GetDouble(reader.GetOrdinal("TotalNetIncome"));

                        
                        double netProfit = totalRevenue - totalExpense + totalNetIncome;

                        
                        TotalRevenue.Text = totalRevenue.ToString("C");
                        TotalOrders.Text = totalOrders.ToString();
                        ExpenseLbl.Text = totalExpense.ToString("C");
                        ProfitLbl.Text = netProfit.ToString("C");
                    }
                    else
                    {
                       
                        TotalRevenue.Text = "Total Revenue: $0.00";
                        TotalOrders.Text = "Total Orders: 0";
                        ExpenseLbl.Text = "Total Expense: $0.00";
                        ProfitLbl.Text = "Net Profit: $0.00";
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        public void CountshowInformation()
        {
            using (var con = DatabaseConnection.databaseConnect())
            {
                con.Open();

                // count total customer.
                SqlCommand cm = new SqlCommand("SELECT Count(*) From tbCustomer", con);
                var totalCustomer = cm.ExecuteScalar();
                if (int.Parse(totalCustomer.ToString()) < 10)
                {
                    totalCustomer = "" + totalCustomer;
                }
                lblCustomerCount.Text = totalCustomer.ToString();


                // Check total medicine count
                SqlCommand cm2 = new SqlCommand("SELECT COUNT(*) FROM InventoryTbl", con);
                int totalMedicineCount = (int)cm2.ExecuteScalar();
                string totalMedicineDisplay = totalMedicineCount < 10 ? "" + totalMedicineCount.ToString() : totalMedicineCount.ToString();
                lblMadiniceCount.Text = totalMedicineDisplay;
                
                // Check total medicine shortage count
                SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM InventoryTbl WHERE PStock < 50", con);
                int shortageCount = (int)cmd3.ExecuteScalar();
                string shortageCountDisplay = shortageCount < 10 ? "" + shortageCount.ToString() : shortageCount.ToString();
                lblMadicineShortage.Text = shortageCountDisplay;

                con.Close();
            }
        }




        private void TodayBtn_Click(object sender, EventArgs e)
        {
            
            PopulateRevenueChart(filterToday: true);
            DisplayTotalRevenueOrdersAndExpense(filterToday: true);
        }

        private void Last7Btn_Click(object sender, EventArgs e)
        {
            
            PopulateRevenueChart(filterLast7Days: true);

            
            DisplayTotalRevenueOrdersAndExpense(filterLast7Days: true);
        }

       
        private void Last30Btn_Click_1(object sender, EventArgs e)
        {
            PopulateRevenueChart(filterLast30Days: true);
            DisplayTotalRevenueOrdersAndExpense(filterLast30Days: true);

        }

        private void PopulateEmployeeCount()
        {
            using (var con = DatabaseConnection.databaseConnect())
            {
                con.Open();
                SqlCommand cm = new SqlCommand("SELECT Count(*) From EmployeeTbl", con);
                var totalEmployee = cm.ExecuteScalar();
                lblEmployeeCnt.Text = totalEmployee.ToString();
                con.Close();
            }
        }

       
        
    private void PopulateLeaveCount()
    {
       using (var con = DatabaseConnection.databaseConnect())
       {
        con.Open();
        SqlCommand cm = new SqlCommand("SELECT COUNT(DISTINCT Employee) FROM LeaveTbl WHERE status = 'Approved'", con);
        var totalLeave = cm.ExecuteScalar();
        lblLeaveCnt.Text = totalLeave.ToString();
        con.Close();
       }
    }


        /*private void PopulateUnpaidEmployeeCount()
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();
                    SqlCommand cm = new SqlCommand(@"
                        SELECT 
                            (SELECT COUNT(DISTINCT EmpId) FROM EmployeeTbl) - 
                            (SELECT COUNT(DISTINCT EmpId) FROM SalaryTbl) AS UnpaidEmployeeCount;", con);
                    object unpaidEmployeeCount = cm.ExecuteScalar();
                    if (unpaidEmployeeCount != null)
                    {
                        UnpaidEmpCnt.Text = unpaidEmployeeCount.ToString();
                    }
                    else
                    {
                        UnpaidEmpCnt.Text = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
*/
        private void LastYearBtn_Click(object sender, EventArgs e)
        {
            PopulateRevenueChart(filterLastYear: true);

           
            DisplayTotalRevenueOrdersAndExpense(filterLastYear: true);
        }

        private void UseBtn_Click(object sender, EventArgs e)
        {
            
            DateTime startDate = Calender1.Value.Date;
            DateTime endDate = Calender2.Value.Date;

            if (endDate < startDate)
            {
                MessageBox.Show("Please choose a correct date range.");
                return;
            }


            DisplayTotalRevenueOrdersAndExpense(startDate: startDate, endDate: endDate);

            
            PopulateRevenueChart(startDate: startDate, endDate: endDate);
        }

    }
}
