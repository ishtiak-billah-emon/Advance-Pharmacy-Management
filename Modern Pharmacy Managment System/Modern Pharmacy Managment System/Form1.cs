using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Modern_Pharmacy_Managment_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // Increment the width of panel1 by 5 pixels each tick
            panel1.Width += 15;

            // Check if panel1 width has reached or exceeded 491 pixels
            if (panel1.Width >= 291)
            {
                // Set the width of panel1 to the exact target width (491 pixels)
                panel1.Width = 291;                      
                // Stop the timer to prevent further increments
                timer1.Stop();

                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
