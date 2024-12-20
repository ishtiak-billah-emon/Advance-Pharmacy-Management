using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modern_Pharmacy_Managment_System.Classes;
using Modern_Pharmacy_Managment_System.Database;
using System.Data.SqlClient;


namespace Modern_Pharmacy_Managment_System
{
    public partial class CustomerDashboard : Form
    {

        const string connectionString = @"Data Source=DESKTOP-ES6IRGF\MSSQLSERVER01;Initial Catalog=PMSnew;Integrated Security=True";
        private int requestCount = 0;
        
        public CustomerDashboard(string customerName)
        {
            InitializeComponent();
            btncstOrder.MouseEnter += Buy_Medicine_btn_MouseEnter;
            btncstOrder.MouseLeave += Buy_Medicine_btn_MouseLeave;

            CustomerNameTxt.Text = customerName;
            LoadCustomerPoints();


            // Load your images into the array
             images[0] = Image.FromFile(@"C:\Users\RAFSAN\Desktop\Csharp-project\Modern Pharmacy Managment System\Modern Pharmacy Managment System\bin\Debug\ors.jpg"); // Replace Image1 with your actual image
             images[1] = Image.FromFile(@"C:\Users\RAFSAN\Desktop\Csharp-project\Modern Pharmacy Managment System\Modern Pharmacy Managment System\bin\Debug\smc plus 2.jpg"); // Replace Image2 with your actual image
              images[2] = Image.FromFile(@"C:\Users\RAFSAN\Desktop\Csharp-project\Modern Pharmacy Managment System\Modern Pharmacy Managment System\bin\Debug\glucose-product-banner1.jpg"); // Replace Image3 with your actual image

            // Set initial image
            guna2PictureBox5.Image = images[0];

            // Configure the timer
            timer1.Interval = 1000; // Interval in milliseconds (e.g., 2000 milliseconds = 2 seconds)
            timer1.Tick += timer1_Tick;

            // Start the timer
            timer1.Start();
            lblReqMadiniceCount.Text = 0.ToString();

        }
        private int imageIndex = 0;
        private Image[] images = new Image[3];

        private void Buy_Medicine_btn_MouseEnter(object sender, EventArgs e)
        {
            // Change button background color when mouse enters
            btncstOrder.BackColor = Color.FromArgb(8, 224, 255); // Change to desired color
        }

        private void Buy_Medicine_btn_MouseLeave(object sender, EventArgs e)
        {
            // Change button background color when mouse enters
            btncstOrder.BackColor = Color.FromArgb(40, 51, 66); // Change to desired color
        }


        public void loadform(object Form)
        {
            if (this.CustomPanel.Controls.Count > 0)
                this.CustomPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.CustomPanel.Controls.Add(f);
            this.CustomPanel.Tag = f;
            f.Show();
        }
        public void loadformMD(object Form)
        {
            if (this.CustomPanel.Controls.Count > 0)
                this.CustomPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.Dock = DockStyle.Fill;
            this.CustomPanel.Controls.Add(f);
            this.CustomPanel.Tag = f;
            f.Show();
        }

        private void btncstOrder_Click(object sender, EventArgs e)
        {

            loadform(new OrderForm());
            this.guna2Panel3.Hide();
            this.guna2Panel2.Hide();
            this.guna2Panel6.Hide();
            this.guna2Panel7.Hide();
            this.guna2PictureBox5.Hide();

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            loadform(new CustomerSettings());
            this.guna2Panel3.Dispose();
            this.guna2Panel2.Dispose();
            this.guna2Panel6.Dispose();
            this.guna2Panel7.Dispose();
            this.guna2PictureBox5.Dispose();
        }

        private void btncstLogout_Click(object sender, EventArgs e)
        {
            
            Login login = new Login();
            this.Dispose();
            CustomerDashboard customerDashboardForm = new CustomerDashboard(CustomerNameTxt.Text);
            customerDashboardForm.Dispose();
            login.Show();
            this.guna2Panel3.Dispose();
            this.guna2Panel2.Dispose();
            this.guna2Panel6.Dispose();
            this.guna2Panel7.Dispose();
            this.guna2PictureBox5.Dispose();

            List<Form> formsToClose = new List<Form>();

            foreach (Form form in Application.OpenForms)
            {
                if (form is CustomerDashboard )
                {
                    formsToClose.Add(form);
                }
            }


            foreach (Form form in formsToClose)
            {
                form.Close();
            }
            this.Hide();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            CustomerDashboard customerDashboardForm = new CustomerDashboard(CustomerNameTxt.Text);
            customerDashboardForm.Show();
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            
        }

        public void LoadBkashFormIntoMainPanel(Object Form)
        {
            if (this.CustomPanel.Controls.Count > 0)
                this.CustomPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.CustomPanel.Controls.Add(f);
            this.CustomPanel.Tag = f;
            f.Show();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnreqMed_Click(object sender, EventArgs e)
        {
            reqCustomerProduct rq = new reqCustomerProduct();
            rq.Show();
            requestCount++;
            
            // Show the request count in lblReqMadiniceCount
            lblReqMadiniceCount.Text = requestCount.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }


        private void LoadCustomerPoints()
        {

            Login login = Login.GetInstance();
            string customerPhone = login.getCustomerPhone();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to select cpoints for the customer with the provided phone number
                    string query = "SELECT cpoints FROM tbCustomer WHERE cphone = @customerPhone";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter for customerPhone
                        command.Parameters.AddWithValue("@customerPhone", customerPhone);

                        // Execute the query and get the result using SqlDataReader
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Check if there are any rows
                            {
                                // Retrieve the value of cpoints and display it in label5
                                string points = reader.GetString(0);
                                label5.Text = points;
                                int intValue = int.Parse(points);
                                double rev = intValue*2;
                                label7.Text = rev.ToString();

                            }
                            else
                            {
                                label5.Text = "0"; // or any default value you want to display if the customer points are not found
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            imageIndex++;

            // Reset to the first image if we've reached the end
            if (imageIndex >= images.Length)
            {
                imageIndex = 0;
            }

            // Update the PictureBox with the next image
            guna2PictureBox5.Image = images[imageIndex];
        }
        

        private void lblMadiniceCount_Click(object sender, EventArgs e)
        {
            

        }
    }
}
