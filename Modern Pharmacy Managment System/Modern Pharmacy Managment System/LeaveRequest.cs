using Modern_Pharmacy_Managment_System.Database;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Modern_Pharmacy_Managment_System
{
    public partial class LeaveRequest : Form
    {
        private Functions Con;

        public LeaveRequest()
        {
            InitializeComponent();
            Con = new Functions();
            RequestLeaveBtn.Click += RequestLeaveBtn_Click;
            IdTxt.Text = Login.EmpId.ToString();

            
            DateStartCalender.Value = DateTime.Now;
            DateEndCalender.Value = DateTime.Now;
        }

        private void RequestLeaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(IdTxt.Text) || string.IsNullOrEmpty(ReasonTxt.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                int employeeId = int.Parse(IdTxt.Text);
                string reason = ReasonTxt.Text;
                DateTime dateStart = DateStartCalender.Value.Date;
                DateTime dateEnd = DateEndCalender.Value.Date;
                DateTime appliedDate = DateTime.Today;

                // Check if end date is earlier than start date
                if (dateEnd < dateStart || dateStart < DateTime.Today || dateEnd < DateTime.Today)
                {
                    MessageBox.Show("Invalid date range. Date cannot be earlier than today.");
                    return;
                }

                if (IdTxt.Text != Login.EmpId.ToString())
                {
                    MessageBox.Show("Your Id is invalid");
                    return;
                }

                string leaveQuery = @"INSERT INTO LeaveTbl (Employee, Reason, DateStart, DateEnd, AppliedDate, Status) 
                                      VALUES (@EmployeeId, @Reason, @DateStart, @DateEnd, @AppliedDate, 'Pending')";

                using (var connection = DatabaseConnection.databaseConnect())
                {
                    SqlCommand leaveCmd = new SqlCommand(leaveQuery, connection);
                    leaveCmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                    leaveCmd.Parameters.AddWithValue("@Reason", reason);
                    leaveCmd.Parameters.AddWithValue("@DateStart", dateStart);
                    leaveCmd.Parameters.AddWithValue("@DateEnd", dateEnd);
                    leaveCmd.Parameters.AddWithValue("@AppliedDate", appliedDate);

                    connection.Open();
                    int rowsAffected = leaveCmd.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Leave request submitted successfully!");
                        
                    }
                    else
                    {
                        MessageBox.Show("Failed to submit leave request.");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format. Please check your input.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            this.Hide();
        }
    }
}
