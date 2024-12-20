using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Modern_Pharmacy_Managment_System.Database;

namespace Modern_Pharmacy_Managment_System
{
    public partial class Revenue : Form
    {
        public Revenue()
        {
            InitializeComponent();
            PopulateExpenseChart();
            PopulateProfitChart();
            PopulateOnlineOfflineChart();

        }
        private void PopulateExpenseChart(bool filterToday = false, bool filterLast7Days = false, bool filterLast30Days = false, bool filterLastYear = false, DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();
                    string query = "SELECT Date, SUM(Expense) AS TotalRevenue FROM [PMSnew].[dbo].[AccountTbl] WHERE 1 = 1";

                   
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

                    
                    ExpenseChart.Series["Expense"].Points.Clear();

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

                        
                        ExpenseChart.Series["Expense"].Points.AddXY(date, totalRevenue);
                    }

                    reader.Close();
                }

               
                ExpenseChart.ChartAreas[0].AxisX.Interval = 1; 
                ExpenseChart.ChartAreas[0].AxisX.LabelStyle.Format = "d MMM yyyy"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //  SUM((Revenue - Expense) + NetIncome)

        private void PopulateProfitChart(bool filterToday = false, bool filterLast7Days = false, bool filterLast30Days = false, bool filterLastYear = false, DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();
                    string query = "SELECT Date, SUM(TotalOrders) AS TotalRevenue FROM [PMSnew].[dbo].[AccountTbl] WHERE 1 = 1";


                    
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

                    
                    ProfitChart.Series["Profit"].Points.Clear();

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

                        
                        ProfitChart.Series["Profit"].Points.AddXY(date, totalRevenue);
                    }

                    reader.Close();
                }

                
                ProfitChart.ChartAreas[0].AxisX.Interval = 1; 
                ProfitChart.ChartAreas[0].AxisX.LabelStyle.Format = "d MMM yyyy"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PopulateOnlineOfflineChart(bool filterToday = false, bool filterLast7Days = false, bool filterLast30Days = false, bool filterLastYear = false, DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();
                    string query = "SELECT SUM(TotalOrders) AS TotalOrders, OrderType " +
                                   "FROM ( " +
                                   "    SELECT " +
                                   "    TotalOrders, " +
                                   "    CASE " +
                                   "            WHEN (EmpId IS NULL AND (CustomerPhone IS NOT NULL )) THEN 'Online' " +
                                   "            WHEN (EmpId IS NOT NULL AND (CustomerPhone IS NULL OR CustomerPhone = '')) THEN 'Offline' " +
                                   "            WHEN (EmpId IS NOT NULL AND CustomerPhone IS NOT NULL) THEN 'Offline' " +
                                   "    END AS OrderType " +
                                   "    FROM [PMSnew].[dbo].[AccountTbl] " +
                                   "    WHERE 1 = 1";

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
                        query += " AND Date >= @StartDate AND Date <= @EndDate";
                    }

                    query += " ) AS TempTable GROUP BY OrderType";

                    SqlCommand cm = new SqlCommand(query, con);

                    if (startDate != null && endDate != null)
                    {
                        cm.Parameters.AddWithValue("@StartDate", startDate.Value.Date);
                        cm.Parameters.AddWithValue("@EndDate", endDate.Value.Date);
                    }

                    SqlDataReader reader = cm.ExecuteReader();

                    OnlineOfflineChart.Series["OnlineOffline"].Points.Clear();

                    while (reader.Read())
                    {
                        double totalOrders;
                        string orderType;

                        if (!reader.IsDBNull(reader.GetOrdinal("TotalOrders")))
                        {
                            totalOrders = Convert.ToDouble(reader["TotalOrders"]);
                        }
                        else
                        {
                            continue;
                        }

                        if (!reader.IsDBNull(reader.GetOrdinal("OrderType")))
                        {
                            orderType = reader["OrderType"].ToString();
                        }
                        else
                        {
                            continue;
                        }

                        OnlineOfflineChart.Series["OnlineOffline"].Points.AddXY(orderType, totalOrders);
                    }

                    reader.Close();
                }

                OnlineOfflineChart.Series["OnlineOffline"].IsValueShownAsLabel = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }








        private void Today_Click(object sender, EventArgs e)
        {
            PopulateExpenseChart(filterToday: true);
            PopulateProfitChart(filterToday: true);
            PopulateOnlineOfflineChart(filterToday: true);
        }

        private void Last7Btn_Click(object sender, EventArgs e)
        {
            PopulateExpenseChart(filterLast7Days: true);
            PopulateProfitChart(filterLast7Days: true);
            PopulateOnlineOfflineChart(filterLast7Days: true);
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
            PopulateOnlineOfflineChart(startDate: startDate, endDate: endDate);
            PopulateProfitChart(startDate: startDate, endDate: endDate);
            PopulateExpenseChart(startDate: startDate, endDate: endDate);

        }

        private void Last30Btn_Click(object sender, EventArgs e)
        {
            PopulateExpenseChart(filterLast30Days: true);
            PopulateProfitChart(filterLast30Days: true);
            PopulateOnlineOfflineChart(filterLast30Days: true);

        }

        private void LastYearBtn_Click(object sender, EventArgs e)
        {
            PopulateExpenseChart(filterLastYear: true);
            PopulateProfitChart(filterLastYear:true) ;
            PopulateOnlineOfflineChart(filterLastYear: true);

        }
    }
}

