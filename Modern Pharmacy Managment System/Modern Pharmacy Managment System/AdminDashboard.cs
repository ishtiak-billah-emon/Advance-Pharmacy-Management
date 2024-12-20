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
using System.Data.SqlTypes;
using System.Windows.Forms.DataVisualization.Charting;

namespace Modern_Pharmacy_Managment_System
{
    public partial class AdminDashboard : Form
    {
        // Define enum for time ranges
        enum TimeRange
        {
            All,
            Today,
            Last7Days,
            Last30Days,
            LastYear
        }

        // Variable to store the current time range
        TimeRange currentTimeRange = TimeRange.All;

        public AdminDashboard()
        {
            InitializeComponent();
            InitializeDashboard();
            SetupButtonClickHandlers();
           
        }

        private void InitializeDashboard()
        {
            // Populate initial data
            PopulateEmployeeCount();
            PopulateLeaveCount();
            PopulateUnpaidEmployeeCount();
            PopulateSalaryExpense();
            PopulateRevenueChart();



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
                SqlCommand cm = new SqlCommand("SELECT Count(*) From LeaveTbl  WHERE status = 'Approved'", con);
                var totalLeave = cm.ExecuteScalar();
                lblLeaveCnt.Text = totalLeave.ToString();
                con.Close();
            }
        }

        private void PopulateUnpaidEmployeeCount()
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

        private void PopulateSalaryExpense()
        {
            try
            {
                SalaryExpenseCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void PopulateRevenueChart()
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();
                    SqlCommand cm = new SqlCommand("SELECT Date, SUM(Revenue) AS TotalRevenue FROM AccountTbl GROUP BY Date", con);
                    SqlDataReader reader = cm.ExecuteReader();

                    // Clear existing data points
                    RevenueChart.Series["Revenue"].Points.Clear();

                    while (reader.Read())
                    {
                        // Check if the Revenue field is not DBNull
                        if (!reader.IsDBNull(reader.GetOrdinal("TotalRevenue")))
                        {
                            DateTime date = Convert.ToDateTime(reader["Date"]);
                            double revenue = Convert.ToDouble(reader["TotalRevenue"]);

                            // Add data point to the chart
                            RevenueChart.Series["Revenue"].Points.AddXY(date.ToString("d MMM yyyy"), revenue);
                        }
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }















        private void SetupButtonClickHandlers()
        {
            TodayBtn.Click += (sender, e) =>
            {
                currentTimeRange = TimeRange.Today;
                SalaryExpenseCount();
            };

            Last7DaysBtn.Click += (sender, e) =>
            {
                currentTimeRange = TimeRange.Last7Days;
                SalaryExpenseCount();
            };

            Last30DaysBtn.Click += (sender, e) =>
            {
                currentTimeRange = TimeRange.Last30Days;
                SalaryExpenseCount();
            };

            LastYearsBtn.Click += (sender, e) =>
            {
                currentTimeRange = TimeRange.LastYear;
                SalaryExpenseCount();
            };
        }

        private void SalaryExpenseCount()
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();
                    // Define the start and end dates based on the current time range
                    DateTime startDate;
                    DateTime endDate = DateTime.Today;
                    switch (currentTimeRange)
                    {
                        case TimeRange.Today:
                            startDate = endDate;
                            break;
                        case TimeRange.Last7Days:
                            startDate = endDate.AddDays(-6);
                            break;
                        case TimeRange.Last30Days:
                            startDate = endDate.AddDays(-29);
                            break;
                        case TimeRange.LastYear:
                            startDate = endDate.AddYears(-1);
                            break;
                        default: // All
                            startDate = new DateTime(1753, 1, 1); // Set to the minimum supported date
                            break;
                    }

                    // Ensure that the start date is within the supported range
                    if (startDate < SqlDateTime.MinValue.Value)
                    {
                        startDate = SqlDateTime.MinValue.Value;
                    }

                    // Prepare the SQL command to sum the SalaryPaidAmount within the date range
                    SqlCommand cm = new SqlCommand(@"
                        SELECT SUM(SalaryPaidAmount) 
                        FROM SalaryTbl 
                        WHERE SalaryPaidDate >= @StartDate AND SalaryPaidDate <= @EndDate", con);
                    // Add parameters for start and end dates
                    cm.Parameters.AddWithValue("@StartDate", startDate.Date);
                    cm.Parameters.AddWithValue("@EndDate", endDate.Date);
                    // Execute the command to get the total salary expense
                    object totalSalaryExpense = cm.ExecuteScalar();
                    if (totalSalaryExpense != null && totalSalaryExpense != DBNull.Value)
                    {
                        // Display the total salary expense in your desired label or variable
                        SalaryExpenseCnt.Text = totalSalaryExpense.ToString();
                    }
                    else
                    {
                        // If no records found for the specified date range, display 0
                        SalaryExpenseCnt.Text = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RevenueChart_Click(object sender, EventArgs e)
        {

        }
    }
}
