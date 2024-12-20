using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Pharmacy_Managment_System
{
    public partial class Category : Form
    {
        Functions Con;
        public Category()
        {
            InitializeComponent();
            Con = new Functions();
            ShowCategories();
        }

        private void ShowCategories()
        {
            string Query = "select * from CategoryTbl";
            CategoryList.DataSource = Con.GetData(Query);

        }
        private void EmpSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(CategoryNameTb.Text=="")
                {
                    MessageBox.Show("Missing Datails!!!");
                }
                else
                {
                    string Category = CategoryNameTb.Text;
                    string Query = "insert into CategoryTbl values('{0}')";
                    Query = string.Format(Query, Category);
                    Con.SetData(Query);
                    ShowCategories();
                    CategoryNameTb.Text = "";

                }

            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        int Key = 0;

        private void CategoryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoryNameTb.Text = CategoryList.SelectedRows[0].Cells[1].Value.ToString();
            if(CategoryNameTb.Text=="")
            {
                Key = 0;

            }

            else
            {
                Key = Convert.ToInt32(CategoryList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EmpEditBtnCat_Click(object sender, EventArgs e)
        {

            try
            {
                if (CategoryNameTb.Text == "")
                {
                    MessageBox.Show("Missing Datails!!!");
                }
                else
                {
                    string Category = CategoryNameTb.Text;
                    string Query = "Update CategoryTbl set CatName ='{0}' where CatId={1}";
                    Query = string.Format(Query, Category,Key);
                    Con.SetData(Query);
                    ShowCategories();
                    CategoryNameTb.Text = "";

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void EmpDltBtnCat_Click(object sender, EventArgs e)
        {

            try
            {
                if (Key==0)
                {
                    MessageBox.Show("Missing Datails!!!");
                }
                else
                {
                    string Category = CategoryNameTb.Text;
                    string Query = "delete from  CategoryTbl where CatId ={0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowCategories();
                    CategoryNameTb.Text = "";

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void StaffFormEmployeesBtn_Click(object sender, EventArgs e)
        {
            StaffForm sf = new StaffForm();
            Point location = new Point(598, 250); // Adjust the coordinates as needed

            // Show the Category form
            sf.StartPosition = FormStartPosition.Manual;
            sf.Location = location;
            sf.Show();
            this.Hide();
        }

        private void LeaveBtn_Click(object sender, EventArgs e)
        {
            LeavesForm lf = new LeavesForm();
            Point location = new Point(598, 250); // Adjust the coordinates as needed

            // Show the Category form
            lf.StartPosition = FormStartPosition.Manual;
            lf.Location = location;
            lf.Show();
            this.Hide();
        }
    }
}
