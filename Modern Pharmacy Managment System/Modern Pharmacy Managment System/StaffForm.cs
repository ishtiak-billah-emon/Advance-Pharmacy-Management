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
    public partial class StaffForm : Form
    {
        Functions Con;
        int Key = 0; 

        public StaffForm()
        {
            InitializeComponent();
            Con = new Functions();
            ShowStaffForm();


            EmployeeJoiningCalender.Value = DateTime.Today;
        }

        private void ShowStaffForm()
        {
            try
            {
                string query = "select * from EmployeeTbl";
                EmployeeList.DataSource = Con.GetData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                
                Con.CloseConnection();
            }
        }

        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = EmployeeList.Rows[e.RowIndex];
                EmpNameTb.Text = row.Cells[1].Value.ToString();


                EmpGenderCb.SelectedItem = row.Cells[2].Value.ToString();
                EmpPhoneTb.Text = row.Cells[3].Value.ToString();
                EmpPassTb.Text = row.Cells[4].Value.ToString();
                EmpAddressTb.Text = row.Cells[5].Value.ToString();
                EmployeeJoiningCalender.Value = Convert.ToDateTime(row.Cells[6].Value);
                EmpSalaryBox.Text = row.Cells[7].Value.ToString();

                Key = Convert.ToInt32(row.Cells[0].Value);
            }
        }
        
        private void EmpSaveBtnStaff_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(EmpNameTb.Text) ||
                    string.IsNullOrWhiteSpace(EmpPhoneTb.Text) ||
                    string.IsNullOrWhiteSpace(EmpPassTb.Text) ||
                    string.IsNullOrWhiteSpace(EmpAddressTb.Text) ||
                    EmpGenderCb.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(EmpSalaryBox.Text))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                string name = EmpNameTb.Text;
                string gender = EmpGenderCb.SelectedItem.ToString();
                string phone = EmpPhoneTb.Text;
                string pass = EmpPassTb.Text;
                string add = EmpAddressTb.Text;
                DateTime joiningDate = EmployeeJoiningCalender.Value;

                
                if (!float.TryParse(EmpSalaryBox.Text, out float parsedSalary))
                {
                    MessageBox.Show("Please enter a valid numerical value for salary.", "Invalid Salary", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime presentDate = DateTime.Today;

                if (joiningDate.Date > presentDate)
                {
                    MessageBox.Show("Joining date cannot be in the future. Please select a valid date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }






                string checkPhoneQuery = "SELECT COUNT(*) FROM EmployeeTbl WHERE EmpPhone = '{0}'";
                checkPhoneQuery = string.Format(checkPhoneQuery, phone);
                int existingPhoneCount = (int)Con.ExecuteScalar(checkPhoneQuery);

                if (existingPhoneCount > 0)
                {
                    MessageBox.Show("Phone number already exists. Please enter a different phone number.", "Duplicate Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                string insertQuery = "INSERT INTO EmployeeTbl (EmpName, EmpGen, EmpPhone, EmpPass, EmpAdd, EmpJoiningDate, EmpSalary) " +
                                     "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6})";
                insertQuery = string.Format(insertQuery, name, gender, phone, pass, add, joiningDate.ToString("yyyy-MM-dd"), parsedSalary);
                Con.SetData(insertQuery);

                ShowStaffForm();
                MessageBox.Show("Employee Added!!!");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }






        private void EmpEditBtnStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key != 0)
                {
                   
                    if (string.IsNullOrWhiteSpace(EmpNameTb.Text) ||
                        string.IsNullOrWhiteSpace(EmpPhoneTb.Text) ||
                        string.IsNullOrWhiteSpace(EmpPassTb.Text) ||
                        string.IsNullOrWhiteSpace(EmpAddressTb.Text) ||
                        EmpGenderCb.SelectedItem == null ||
                        string.IsNullOrWhiteSpace(EmpSalaryBox.Text))
                    {
                        MessageBox.Show("Please fill in all the required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    
                    string name = EmpNameTb.Text;
                    string gender = EmpGenderCb.SelectedItem.ToString();
                    string phone = EmpPhoneTb.Text;
                    string pass = EmpPassTb.Text;
                    string add = EmpAddressTb.Text;
                    DateTime joiningDate = EmployeeJoiningCalender.Value;

                   
                    if (!float.TryParse(EmpSalaryBox.Text, out float parsedSalary))
                    {
                        MessageBox.Show("Please enter a valid numerical value for salary.", "Invalid Salary", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    
                    string checkPhoneQuery = "SELECT COUNT(*) FROM EmployeeTbl WHERE EmpPhone = '{0}' AND EmpId != {1}";
                    checkPhoneQuery = string.Format(checkPhoneQuery, phone, Key);
                    int existingPhoneCount = (int)Con.ExecuteScalar(checkPhoneQuery);

                    if (existingPhoneCount > 0)
                    {
                        MessageBox.Show("Phone number already exists. Please enter a different phone number.", "Duplicate Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    
                    string query = "UPDATE EmployeeTbl SET EmpName='{0}', EmpGen='{1}', EmpPhone='{2}', EmpPass='{3}', " +
                                   "EmpAdd='{4}', EmpJoiningDate='{5}', EmpSalary={6} WHERE EmpId={7}";
                    query = string.Format(query, name, gender, phone, pass, add, joiningDate.ToString("yyyy-MM-dd"), parsedSalary, Key);
                    Con.SetData(query);

                    ShowStaffForm();
                    MessageBox.Show("Employee Updated!!!");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please select an employee to edit.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void EmpDltBtnStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key != 0)
                {
                   
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    
                    if (result == DialogResult.Yes)
                    {
                        
                        string deleteSalaryQuery = "DELETE FROM SalaryTbl WHERE EmpId = {0}";
                        deleteSalaryQuery = string.Format(deleteSalaryQuery, Key);
                        Con.SetData(deleteSalaryQuery);

                       
                        string deleteEmployeeQuery = "DELETE FROM EmployeeTbl WHERE EmpId = {0}";
                        deleteEmployeeQuery = string.Format(deleteEmployeeQuery, Key);
                        Con.SetData(deleteEmployeeQuery);

                        ShowStaffForm();
                        MessageBox.Show("Employee Deleted!!!");
                        ClearFields();
                    }
                }
                else
                {
                    MessageBox.Show("Please select an employee to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void ClearFields()
        {
            EmpNameTb.Text = "";
            EmpPhoneTb.Text = "";
            EmpPassTb.Text = "";
            EmpAddressTb.Text = "";
            EmpGenderCb.SelectedIndex = -1;
            EmployeeJoiningCalender.Value = DateTime.Now;
            EmpSalaryBox.Text = "";
        }

        

       

        private void EmpDltBtnStaff_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Key != 0)
                {
                    string query = "delete from EmployeeTbl where EmpId={0}";
                    query = string.Format(query, Key);
                    Con.SetData(query);
                    ShowStaffForm();
                    MessageBox.Show("Employee Deleted!!!");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please select an employee to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

       

        private void EmpGenderCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void LeaveNotification_Click(object sender, EventArgs e)
        {
            try
            {
               
                string query = @"
            SELECT EmployeeTbl.EmpId, EmployeeTbl.EmpName, LeaveTbl.Reason, LeaveTbl.DateStart, LeaveTbl.DateEnd
            FROM LeaveTbl 
            INNER JOIN EmployeeTbl ON LeaveTbl.Employee = EmployeeTbl.EmpId
            WHERE LeaveTbl.Status = 'Pending'";

               
                DataTable dtPendingLeaves = Con.GetData(query);

                
                if (dtPendingLeaves.Rows.Count > 0)
                {
                    
                    string leaveRequestMessage = "Pending Leave Requests:\n\n";
                    foreach (DataRow row in dtPendingLeaves.Rows)
                    {
                        
                        int empId = Convert.ToInt32(row["EmpId"]);
                        string employeeName = row["EmpName"].ToString();
                        string reason = row["Reason"].ToString();
                        string startDate = Convert.ToDateTime(row["DateStart"]).ToString("yyyy-MM-dd");
                        string endDate = Convert.ToDateTime(row["DateEnd"]).ToString("yyyy-MM-dd");

                       
                        leaveRequestMessage += $"Employee ID: {empId}\n  - Name: {employeeName}\n  - Reason: {reason}\n  - Start Date: {startDate}\n  - End Date: {endDate}\n\n";
                    }

                   
                    Form messageForm = new Form();
                    messageForm.Text = "Pending Leave Requests";
                    messageForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                    messageForm.StartPosition = FormStartPosition.Manual;
                    messageForm.Location = new Point(100, 100); 
                    messageForm.Size = new Size(500, 400); 

                   
                    Label messageLabel = new Label();
                    messageLabel.Text = leaveRequestMessage;
                    messageLabel.AutoSize = false;
                    messageLabel.Size = new Size(480, 320); 
                    messageLabel.Location = new Point(10, 10);
                    messageLabel.Font = new Font("Arial", 10, FontStyle.Regular); 
                    messageLabel.ForeColor = Color.Black; 
                    messageLabel.BackColor = Color.LightBlue; 

                   
                    messageForm.Controls.Add(messageLabel);

                
                    messageForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("There are no pending leave requests.", "No Pending Leaves");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void LeaveNotification2_Click(object sender, EventArgs e)
        {
           /* try
            {
                // Query to retrieve employees with pending leave requests along with their names
                string query = @"SELECT EmployeeTbl.EmpName, LeaveTbl.Reason 
                         FROM LeaveTbl 
                         INNER JOIN EmployeeTbl ON LeaveTbl.Employee = EmployeeTbl.EmpId
                         WHERE LeaveTbl.Status = 'Pending'";

                // Retrieve employees with pending leave requests and their names
                DataTable dtPendingLeaves = Con.GetData(query);

                // Check if there are employees with pending leave requests
                if (dtPendingLeaves.Rows.Count > 0)
                {
                    // Generate the message with employees' leave requests
                    string leaveRequestMessage = "Pending Leave Requests:\n\n";
                    foreach (DataRow row in dtPendingLeaves.Rows)
                    {
                        // Get the employee name and reason for leave
                        string employeeName = row["EmpName"].ToString();
                        string reason = row["Reason"].ToString();

                        // Append employee's leave request to the message
                        leaveRequestMessage += $"Employee: {employeeName}\n  - Reason: {reason}\n\n";
                    }

                    // Show MessageBox with pending leave requests
                    MessageBox.Show(leaveRequestMessage, "Pending Leave Requests", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("There are no pending leave requests.", "No Pending Leaves", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
*/
        }

        private void LeaveBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                LeavesForm lf = new LeavesForm();
                Point location = new Point(553, 220); 
                
                lf.StartPosition = FormStartPosition.Manual;
                lf.Location = location;
                lf.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }


       







        

       

       

        private void pictureBoxGif1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
           

            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = SearchTextBox.Text.Trim();

               
                if (!string.IsNullOrEmpty(searchText))
                {
                   
                    string query = "SELECT EmpId, EmpName, EmpGen, EmpPhone, EmpPass, EmpAdd, EmpJoiningDate, EmpSalary " +
                                   $"FROM EmployeeTbl WHERE EmpPhone LIKE '%{searchText}%'";

                    
                    Functions functions = new Functions();

                   
                    DataTable searchResult = functions.GetData(query);

                    
                    if (searchResult.Rows.Count > 0)
                    {
                        
                        EmployeeList.DataSource = searchResult;
                    }
                    else
                    {
                        MessageBox.Show("No employees found with the provided phone number.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    
                    MessageBox.Show("Please provide a phone number to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SearchButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = SearchTextBox2.Text.Trim();

                
                if (!string.IsNullOrEmpty(searchText))
                {
                   
                    string query = "SELECT EmpId, EmpName, EmpGen, EmpPhone, EmpPass, EmpAdd, EmpJoiningDate, EmpSalary " +
                                   $"FROM EmployeeTbl WHERE EmpPhone LIKE '%{searchText}%'";

                    
                    Functions functions = new Functions();

                    
                    DataTable searchResult = functions.GetData(query);

               
                    if (searchResult.Rows.Count > 0)
                    {
                        
                        EmployeeList.DataSource = searchResult;
                    }
                    else
                    {
                        MessageBox.Show("No employees found with the provided phone number.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                 
                    MessageBox.Show("Please provide a phone number to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Notification2_Click(object sender, EventArgs e)
        {
            try
            {
                
                string query = @"
            SELECT EmployeeTbl.EmpId, EmployeeTbl.EmpName, LeaveTbl.Reason, LeaveTbl.DateStart, LeaveTbl.DateEnd
            FROM LeaveTbl 
            INNER JOIN EmployeeTbl ON LeaveTbl.Employee = EmployeeTbl.EmpId
            WHERE LeaveTbl.Status = 'Pending'";

                
                DataTable dtPendingLeaves = Con.GetData(query);

              
                if (dtPendingLeaves.Rows.Count > 0)
                {
                    
                    string leaveRequestMessage = "Pending Leave Requests:\n\n";
                    foreach (DataRow row in dtPendingLeaves.Rows)
                    {
                       
                        int empId = Convert.ToInt32(row["EmpId"]);
                        string employeeName = row["EmpName"].ToString();
                        string reason = row["Reason"].ToString();
                        string startDate = Convert.ToDateTime(row["DateStart"]).ToString("yyyy-MM-dd");
                        string endDate = Convert.ToDateTime(row["DateEnd"]).ToString("yyyy-MM-dd");

                        
                        leaveRequestMessage += $"Employee ID: {empId}\n  - Name: {employeeName}\n  - Reason: {reason}\n  - Start Date: {startDate}\n  - End Date: {endDate}\n\n";
                    }

                
                    Form messageForm = new Form();
                    messageForm.Text = "Pending Leave Requests";
                    messageForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                    messageForm.StartPosition = FormStartPosition.Manual;
                    messageForm.Location = new Point(100, 100);
                    messageForm.Size = new Size(500, 400); 

                    Label messageLabel = new Label();
                    messageLabel.Text = leaveRequestMessage;
                    messageLabel.AutoSize = false;
                    messageLabel.Size = new Size(480, 320); 
                    messageLabel.Location = new Point(10, 10);
                    messageLabel.Font = new Font("Arial", 10, FontStyle.Regular); 
                    messageLabel.ForeColor = Color.Black; 
                    messageLabel.BackColor = Color.LightBlue;

                    
                    messageForm.Controls.Add(messageLabel);

                    
                    messageForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("There are no pending leave requests.", "No Pending Leaves");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Addpanel.Visible = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                LeavesForm lf = new LeavesForm();
                Point location = new Point(553, 220); 

                
                lf.StartPosition = FormStartPosition.Manual;
                lf.Location = location;
                lf.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
    

