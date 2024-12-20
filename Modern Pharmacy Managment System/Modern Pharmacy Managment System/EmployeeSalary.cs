using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using Modern_Pharmacy_Managment_System.Database;



namespace Modern_Pharmacy_Managment_System

{
    public partial class EmployeeSalary : Form

    {

        Functions Con;
        int Key = 0;

        public EmployeeSalary()
        {
            InitializeComponent();
            Con = new Functions();
            LoadSalaryData();
            PayDateCalender.Value = DateTime.Today;
        }

        private void LoadSalaryData()
        {
            try
            {
                string query = "SELECT * FROM SalaryTbl";
                SalaryView.DataSource = Con.GetData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void NotificationImage_Click(object sender, EventArgs e)
        {
            try
            {

               
                string query = "SELECT EmpId, EmpJoiningDate FROM EmployeeTbl WHERE EmpId NOT IN (SELECT DISTINCT EmpId FROM SalaryTbl)";

                
                DataTable dtUnpaidEmployees = Con.GetData(query);

               
                if (dtUnpaidEmployees.Rows.Count > 0)
                {
                    
                    string unpaidEmployeeMessage = "Unpaid Employees:\n\n";
                    foreach (DataRow row in dtUnpaidEmployees.Rows)
                    {
                       
                        int empId = Convert.ToInt32(row["EmpId"]);

                        
                        DateTime joiningDate = Convert.ToDateTime(row["EmpJoiningDate"]);

                       
                        DateTime currentDate = DateTime.Now;
                        TimeSpan timeSinceJoining = currentDate - joiningDate;
                        int daysSinceJoining = (int)timeSinceJoining.TotalDays;

                       
                        int monthsDue = daysSinceJoining > 30 ? ((currentDate.Year - joiningDate.Year) * 12) + currentDate.Month - joiningDate.Month : 0;

                       
                        if (monthsDue > 0)
                        {
                            float perMonthSalary = GetPerMonthSalary(empId);

                            float totalDue = monthsDue * perMonthSalary;

                            
                            unpaidEmployeeMessage += $"Employee ID: {empId}\n  - Per Month Salary: {perMonthSalary}\n  - Due Months: {monthsDue}\n  - Due Amount: {totalDue}\n\n";
                        }
                    }


                   
                    
                    Form messageForm = new Form();
                    messageForm.Text = "Unpaid Employees";
                    messageForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                    messageForm.StartPosition = FormStartPosition.Manual;
                    messageForm.Location = new Point(100, 100);
                    messageForm.Size = new Size(700, 500);
                    Panel panel = new Panel();
                    panel.Dock = DockStyle.Right;
                    panel.AutoScroll = true;
                    messageForm.Controls.Add(panel);

                    
                    RichTextBox messageTextBox = new RichTextBox();
                    messageTextBox.Text = unpaidEmployeeMessage;
                    messageTextBox.ReadOnly = true;
                    messageTextBox.Dock = DockStyle.Fill; 
                    messageTextBox.Font = new Font("Arial", 10, FontStyle.Regular); 
                    messageTextBox.ForeColor = Color.Black; 
                    messageTextBox.BackColor = Color.LightBlue; 


                    
                    messageForm.Controls.Add(messageTextBox);

                    int buttonTop = 20;
                    foreach (DataRow row in dtUnpaidEmployees.Rows)
                    {
                       
                        int empId = Convert.ToInt32(row["EmpId"]);

                       
                        DateTime joiningDate = Convert.ToDateTime(row["EmpJoiningDate"]);

                        
                        DateTime currentDate = DateTime.Now;
                        TimeSpan timeSinceJoining = currentDate - joiningDate;
                        int daysSinceJoining = (int)timeSinceJoining.TotalDays;

                      
                        int monthsDue = daysSinceJoining > 30 ? ((currentDate.Year - joiningDate.Year) * 12) + currentDate.Month - joiningDate.Month : 0;

                       
                        if (monthsDue > 0)
                        {
                           
                            Button employeeButton = new Button();
                            employeeButton.Text = $"Employee ID: {empId}\nDue Amount: {monthsDue} months";
                            employeeButton.Tag = empId;
                            employeeButton.Width = 200;
                            employeeButton.Height = 60;
                            employeeButton.Top = buttonTop;
                            employeeButton.Left = 20;
                            employeeButton.Click += EmployeeButton_Click; 

                           
                            panel.Controls.Add(employeeButton);

                           
                            buttonTop += employeeButton.Height + 10;
                        }
                    }

                   
                    messageForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("All employees have been paid.", "No Unpaid Employees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                Button clickedButton = (Button)sender;

                
                int empId = (int)clickedButton.Tag;

               
                EmpIdTxt.Text = empId.ToString();

                
                string buttonText = clickedButton.Text;
                string dueAmountString = buttonText.Split(new string[] { "Due Amount: " }, StringSplitOptions.None)[1].Trim().Split(' ')[0];
                int dueAmountMonths = int.Parse(dueAmountString);

             
                float perMonthSalary = GetPerMonthSalary(empId);
                float totalDue = dueAmountMonths * perMonthSalary;

                
                SalaryAmountTxt.Text = totalDue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }













        private float GetPerMonthSalary(int empId)
        {
            try
            {
                string query = "SELECT EmpSalary FROM EmployeeTbl WHERE EmpId = " + empId;
                DataTable dt = Con.GetData(query);
                if (dt.Rows.Count > 0)
                {
                    return Convert.ToSingle(dt.Rows[0]["EmpSalary"]);
                }
                else
                {
                    throw new Exception("Employee not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching per month salary: " + ex.Message);
            }
        }

        private void SalaryPaidButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                int empId = int.Parse(EmpIdTxt.Text);
                float salaryAmount = float.Parse(SalaryAmountTxt.Text);
                DateTime payDate = PayDateCalender.Value;

                if (payDate.Date != DateTime.Today)
                {
                    MessageBox.Show("Salary can only be paid on the present date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

              
                if (IsEmployeePaidOnSameDay(empId, payDate))
                {
                    MessageBox.Show($"Employee ID: {empId} has already been paid on {payDate.ToShortDateString()}.", "Duplicate Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                DateTime joiningDate = GetJoiningDate(empId);

                
                int monthsDue = ((DateTime.Now.Year - joiningDate.Year) * 12) + DateTime.Now.Month - joiningDate.Month;

               
                float perMonthSalary = GetPerMonthSalary(empId);

                
                float totalDue = monthsDue * perMonthSalary;

                
                if (totalDue <= 0 || monthsDue < 1)
                {
                    MessageBox.Show($"Employee ID: {empId} - Due is clear", "No Due", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                
                if (salaryAmount != totalDue)
                {
                    MessageBox.Show("Paid amount does not match the total due amount. Please pay the correct amount.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

              
                string insertQuery = "INSERT INTO SalaryTbl (EmpId, SalaryPaidAmount, SalaryPaidDate) VALUES ({0}, {1}, '{2}')";
                insertQuery = string.Format(insertQuery, empId, salaryAmount, payDate.ToString("yyyy-MM-dd"));
                Con.SetData(insertQuery);

                
                string accountInsertQuery = "INSERT INTO AccountTbl (SalaryId, Expense, Date) VALUES ((SELECT SCOPE_IDENTITY()), {0}, '{1}')";
                accountInsertQuery = string.Format(accountInsertQuery, salaryAmount, payDate.ToString("yyyy-MM-dd"));
                Con.SetData(accountInsertQuery);

                MessageBox.Show("Salary paid successfully!", "Payment Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                LoadSalaryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsEmployeePaidOnSameDay(int empId, DateTime payDate)
        {
           
            string query = "SELECT COUNT(*) FROM SalaryTbl WHERE EmpId = @EmpId AND SalaryPaidDate = @PayDate";

            int count = 0;

            try
            {
                using (var connection = DatabaseConnection.databaseConnect())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmpId", empId);
                        command.Parameters.AddWithValue("@PayDate", payDate);

                       
                        count = (int)command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error while checking duplicate payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            return count > 0;
        }






        private DateTime GetJoiningDate(int empId)
        {
            try
            {
                string query = "SELECT EmpJoiningDate FROM EmployeeTbl WHERE EmpId = " + empId;
                DataTable dt = Con.GetData(query);
                if (dt.Rows.Count > 0)
                {
                    return Convert.ToDateTime(dt.Rows[0]["EmpJoiningDate"]);
                }
                else
                {
                    throw new Exception("Employee not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching joining date: " + ex.Message);
            }
        }

        private void DeleteSalaryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(EmpIdTxt.Text) || string.IsNullOrEmpty(SalaryAmountTxt.Text))
                {
                    MessageBox.Show("Please select a record to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (SalaryView.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = SalaryView.SelectedRows[0];
                    int salaryId = Convert.ToInt32(selectedRow.Cells[0].Value);

                    string deleteQuery = "DELETE FROM SalaryTbl WHERE SalaryId = " + salaryId;
                    Con.SetData(deleteQuery);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete the record " + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                       
                        string deleteAccountQuery = "DELETE FROM AccountTbl WHERE SalaryId = " + salaryId;
                        Con.SetData(deleteAccountQuery);

                        MessageBox.Show("Salary record deleted successfully!", "Deletion Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSalaryData();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

       
        private void SalaryView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = SalaryView.Rows[e.RowIndex];
                EmpIdTxt.Text = row.Cells[1].Value.ToString();



                SalaryAmountTxt.Text = row.Cells[2].Value.ToString();


                Key = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = SearchTextBox.Text.Trim();

                
                if (!string.IsNullOrEmpty(searchText))
                {
                   
                    string query = "SELECT SalaryId, EmpId, SalaryPaidAmount, SalaryPaidDate " +
                                   $"FROM SalaryTbl WHERE EmpId LIKE '%{searchText}%'";

                    
                    Functions functions = new Functions();

                   
                    DataTable searchResult = functions.GetData(query);

                    
                    if (searchResult.Rows.Count > 0)
                    {
                        
                        SalaryView.DataSource = searchResult;
                    }
                    else
                    {
                        MessageBox.Show("No employees found with the provided Id.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                   
                    MessageBox.Show("Please provide a Employee Id number to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

