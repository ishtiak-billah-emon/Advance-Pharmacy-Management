using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace Modern_Pharmacy_Managment_System
{
    public partial class LeavesForm : Form
    {
        Functions Con;
        DateTime originalDateStart;
        DateTime originalDateEnd;
        int Key = 0;

        public LeavesForm()
        {
            InitializeComponent();
            Con = new Functions();
            ShowLeaveForm();
            GetEmployees();

           
            DateStartCalender.Enabled = false;
            DateEndCalender.Enabled = false;

       
            ReasonBox.Enabled = false;
        }

        private void ShowLeaveForm()
        {
            string Query = "SELECT * FROM LeaveTbl";
            LeaveList.DataSource = Con.GetData(Query);
        }

        private void FilterLeaves()
        {
            string Query = "SELECT * FROM LeaveTbl WHERE Status = '{0}'";
            Query = string.Format(Query, SearchCb.SelectedItem.ToString());
            LeaveList.DataSource = Con.GetData(Query);
        }

        private void GetEmployees()
        {
            string Query = "SELECT * FROM EmployeeTbl";
            EmployeeCb.DisplayMember = "EmpName";
            EmployeeCb.ValueMember = "EmpId";
            EmployeeCb.DataSource = Con.GetData(Query);
        }

        private void LeaveList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = LeaveList.Rows[e.RowIndex];
                    


                    
                    string reason = row.Cells["Reason"].Value.ToString();
                    string empid = row.Cells["Employee"].Value.ToString();
                    EmpTxt.Text = empid;

                    EmpTxt.Enabled = false;

                   
                    ReasonBox.Text = reason;

                    
                    DateStartCalender.Enabled = false;
                    DateEndCalender.Enabled = false;
                
                    ReasonBox.Enabled = false;

                   
                    originalDateStart = Convert.ToDateTime(row.Cells["DateStart"].Value);
                    originalDateEnd = Convert.ToDateTime(row.Cells["DateEnd"].Value);

                    
                    DateStartCalender.Value = originalDateStart;
                    DateEndCalender.Value = originalDateEnd;

                    
                    Key = Convert.ToInt32(row.Cells["LId"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void EmpEditBtnLeave_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeCb.SelectedIndex == -1 || StatusCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Details!!!");
                }
                else
                {
                    int empId = Convert.ToInt32(EmployeeCb.SelectedValue);
                    string dateStart = DateStartCalender.Value.Date.ToString("yyyy-MM-dd");
                    string dateEnd = DateEndCalender.Value.Date.ToString("yyyy-MM-dd");
                    string status = StatusCb.SelectedItem.ToString();

                    string query = "UPDATE LeaveTbl SET Employee = @EmpId, DateStart = @DateStart, " +
                                   "DateEnd = @DateEnd, Status = @Status WHERE LId = @LeaveId";

                    SqlCommand cmd = new SqlCommand(query, Con.Connection);
                    cmd.Parameters.AddWithValue("@EmpId", empId);
                    cmd.Parameters.AddWithValue("@DateStart", dateStart);
                    cmd.Parameters.AddWithValue("@DateEnd", dateEnd);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@LeaveId", Key); 

                    int rowsAffected = Con.insertData(cmd);

                    if (rowsAffected > 0)
                    {
                        ShowLeaveForm();
                        MessageBox.Show("Leave Updated!!!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update leave.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EmpDltBtnLeave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Select the leave to delete!");
                }
                else
                {
                   
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this leave?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                   
                    if (result == DialogResult.Yes)
                    {
                        string Query = "DELETE FROM LeaveTbl WHERE LId = @LeaveId";
                        SqlCommand cmd = new SqlCommand(Query, Con.Connection);
                        cmd.Parameters.AddWithValue("@LeaveId", Key);
                        int rowsAffected = Con.insertData(cmd);

                        if (rowsAffected > 0)
                        {
                            ShowLeaveForm();
                            MessageBox.Show("Leave Deleted!!!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete leave.");
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void EmpSaveBtnLeave_Click(object sender, EventArgs e)
        {
            
            if (DateStartCalender.Enabled && DateStartCalender.Value != originalDateStart ||
                DateEndCalender.Enabled && DateEndCalender.Value != originalDateEnd)
            {
                MessageBox.Show("You cannot change any value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EmpEditBtnLeave_Click(sender, e);
           
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            ShowLeaveForm();
        }

        private void SearchCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterLeaves();
        }

        private void EmployeesBtn_Click(object sender, EventArgs e)
        {
            StaffForm sf = new StaffForm();
            Point location = new Point(553, 220); 

            
            sf.StartPosition = FormStartPosition.Manual;
            sf.Location = location;
            sf.Show();
            this.Hide();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            Point location = new Point(598, 250); 

            
            c.StartPosition = FormStartPosition.Manual;
            c.Location = location;
            c.Show();
            this.Hide();
        }

        private void DateEndCalender_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
