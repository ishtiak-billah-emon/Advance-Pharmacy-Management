using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Modern_Pharmacy_Managment_System
{
    public partial class ViewLeave : Form
    {
        Functions Con;

        public ViewLeave()
        {
            InitializeComponent();
            Con = new Functions();
            EmpIdLbl.Text = Login.EmpId.ToString();
            EmpNameLbl.Text = Login.EmpName;
            ShowLeaveForm();
        }

        private void ShowLeaveForm()
        {
            try
            {
                
                string Query = "SELECT * FROM LeaveTbl WHERE Employee = " + Login.EmpId;
                DataTable leaveData = Con.GetData(Query);
                LeaveList.DataSource = leaveData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            /*LeaveRequest leaveRequestForm = new LeaveRequest();
            leaveRequestForm.StartPosition = FormStartPosition.Manual;
            leaveRequestForm.Location = new Point(598, 550); // Adjust the coordinates as needed
            leaveRequestForm.Show();*/
            loadform(new LeaveRequest());
            
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
           
                ShowLeaveForm(); 
            
        }

        private void EmpIdLbl_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
