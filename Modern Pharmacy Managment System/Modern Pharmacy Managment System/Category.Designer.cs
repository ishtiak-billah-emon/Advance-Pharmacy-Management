
namespace Modern_Pharmacy_Managment_System
{
    partial class Category
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.CategoryList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EmpDltBtnCat = new FontAwesome.Sharp.IconButton();
            this.EmpSaveBtn = new FontAwesome.Sharp.IconButton();
            this.EmpEditBtnCat = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryNameTb = new System.Windows.Forms.TextBox();
            this.EmpTopPanel = new System.Windows.Forms.Panel();
            this.Emp_manage_label = new System.Windows.Forms.Label();
            this.LeaveBtn = new FontAwesome.Sharp.IconButton();
            this.StaffFormEmployeesBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryList)).BeginInit();
            this.EmpTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(432, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 32);
            this.label5.TabIndex = 43;
            this.label5.Text = "Category List";
            // 
            // CategoryList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.CategoryList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CategoryList.ColumnHeadersHeight = 30;
            this.CategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryList.DefaultCellStyle = dataGridViewCellStyle3;
            this.CategoryList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.CategoryList.Location = new System.Drawing.Point(12, 312);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.RowHeadersVisible = false;
            this.CategoryList.RowHeadersWidth = 51;
            this.CategoryList.RowTemplate.Height = 27;
            this.CategoryList.Size = new System.Drawing.Size(971, 267);
            this.CategoryList.TabIndex = 42;
            this.CategoryList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.CategoryList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.CategoryList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CategoryList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CategoryList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CategoryList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CategoryList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CategoryList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.CategoryList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.CategoryList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CategoryList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CategoryList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CategoryList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CategoryList.ThemeStyle.HeaderStyle.Height = 30;
            this.CategoryList.ThemeStyle.ReadOnly = false;
            this.CategoryList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.CategoryList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoryList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CategoryList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.CategoryList.ThemeStyle.RowsStyle.Height = 27;
            this.CategoryList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.CategoryList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.CategoryList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryList_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.panel3.Location = new System.Drawing.Point(0, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 10);
            this.panel3.TabIndex = 41;
            // 
            // EmpDltBtnCat
            // 
            this.EmpDltBtnCat.BackColor = System.Drawing.Color.Black;
            this.EmpDltBtnCat.FlatAppearance.BorderSize = 0;
            this.EmpDltBtnCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpDltBtnCat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpDltBtnCat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EmpDltBtnCat.IconColor = System.Drawing.Color.Black;
            this.EmpDltBtnCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmpDltBtnCat.Location = new System.Drawing.Point(590, 167);
            this.EmpDltBtnCat.Name = "EmpDltBtnCat";
            this.EmpDltBtnCat.Size = new System.Drawing.Size(133, 42);
            this.EmpDltBtnCat.TabIndex = 37;
            this.EmpDltBtnCat.Text = "Delete";
            this.EmpDltBtnCat.UseVisualStyleBackColor = false;
            this.EmpDltBtnCat.Click += new System.EventHandler(this.EmpDltBtnCat_Click);
            // 
            // EmpSaveBtn
            // 
            this.EmpSaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmpSaveBtn.FlatAppearance.BorderSize = 0;
            this.EmpSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpSaveBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpSaveBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EmpSaveBtn.IconColor = System.Drawing.Color.Black;
            this.EmpSaveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmpSaveBtn.Location = new System.Drawing.Point(590, 119);
            this.EmpSaveBtn.Name = "EmpSaveBtn";
            this.EmpSaveBtn.Size = new System.Drawing.Size(133, 42);
            this.EmpSaveBtn.TabIndex = 36;
            this.EmpSaveBtn.Text = "Save";
            this.EmpSaveBtn.UseVisualStyleBackColor = false;
            this.EmpSaveBtn.Click += new System.EventHandler(this.EmpSaveBtn_Click);
            // 
            // EmpEditBtnCat
            // 
            this.EmpEditBtnCat.BackColor = System.Drawing.Color.Gray;
            this.EmpEditBtnCat.FlatAppearance.BorderSize = 0;
            this.EmpEditBtnCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpEditBtnCat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpEditBtnCat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EmpEditBtnCat.IconColor = System.Drawing.Color.Black;
            this.EmpEditBtnCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmpEditBtnCat.Location = new System.Drawing.Point(590, 71);
            this.EmpEditBtnCat.Name = "EmpEditBtnCat";
            this.EmpEditBtnCat.Size = new System.Drawing.Size(133, 42);
            this.EmpEditBtnCat.TabIndex = 35;
            this.EmpEditBtnCat.Text = "Edit";
            this.EmpEditBtnCat.UseVisualStyleBackColor = false;
            this.EmpEditBtnCat.Click += new System.EventHandler(this.EmpEditBtnCat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(286, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Category Name";
            // 
            // CategoryNameTb
            // 
            this.CategoryNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryNameTb.Location = new System.Drawing.Point(289, 108);
            this.CategoryNameTb.Multiline = true;
            this.CategoryNameTb.Name = "CategoryNameTb";
            this.CategoryNameTb.Size = new System.Drawing.Size(183, 40);
            this.CategoryNameTb.TabIndex = 29;
            // 
            // EmpTopPanel
            // 
            this.EmpTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmpTopPanel.Controls.Add(this.Emp_manage_label);
            this.EmpTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmpTopPanel.Location = new System.Drawing.Point(0, 0);
            this.EmpTopPanel.Name = "EmpTopPanel";
            this.EmpTopPanel.Size = new System.Drawing.Size(995, 32);
            this.EmpTopPanel.TabIndex = 28;
            // 
            // Emp_manage_label
            // 
            this.Emp_manage_label.AutoSize = true;
            this.Emp_manage_label.Font = new System.Drawing.Font("ISOCTEUR", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_manage_label.ForeColor = System.Drawing.Color.White;
            this.Emp_manage_label.Location = new System.Drawing.Point(326, -2);
            this.Emp_manage_label.Name = "Emp_manage_label";
            this.Emp_manage_label.Size = new System.Drawing.Size(315, 34);
            this.Emp_manage_label.TabIndex = 0;
            this.Emp_manage_label.Text = "MANAGE CATEGORY";
            // 
            // LeaveBtn
            // 
            this.LeaveBtn.BackColor = System.Drawing.Color.Blue;
            this.LeaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeaveBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LeaveBtn.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.LeaveBtn.IconColor = System.Drawing.Color.White;
            this.LeaveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LeaveBtn.IconSize = 35;
            this.LeaveBtn.Location = new System.Drawing.Point(729, 146);
            this.LeaveBtn.Name = "LeaveBtn";
            this.LeaveBtn.Size = new System.Drawing.Size(133, 42);
            this.LeaveBtn.TabIndex = 6;
            this.LeaveBtn.Text = "Leaves";
            this.LeaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LeaveBtn.UseVisualStyleBackColor = false;
            this.LeaveBtn.Click += new System.EventHandler(this.LeaveBtn_Click);
            // 
            // StaffFormEmployeesBtn
            // 
            this.StaffFormEmployeesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.StaffFormEmployeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffFormEmployeesBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StaffFormEmployeesBtn.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.StaffFormEmployeesBtn.IconColor = System.Drawing.Color.White;
            this.StaffFormEmployeesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.StaffFormEmployeesBtn.IconSize = 30;
            this.StaffFormEmployeesBtn.Location = new System.Drawing.Point(729, 98);
            this.StaffFormEmployeesBtn.Name = "StaffFormEmployeesBtn";
            this.StaffFormEmployeesBtn.Size = new System.Drawing.Size(133, 42);
            this.StaffFormEmployeesBtn.TabIndex = 4;
            this.StaffFormEmployeesBtn.Text = "Employees";
            this.StaffFormEmployeesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StaffFormEmployeesBtn.UseVisualStyleBackColor = false;
            this.StaffFormEmployeesBtn.Click += new System.EventHandler(this.StaffFormEmployeesBtn_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 614);
            this.Controls.Add(this.LeaveBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CategoryList);
            this.Controls.Add(this.StaffFormEmployeesBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.EmpDltBtnCat);
            this.Controls.Add(this.EmpSaveBtn);
            this.Controls.Add(this.EmpEditBtnCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CategoryNameTb);
            this.Controls.Add(this.EmpTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            ((System.ComponentModel.ISupportInitialize)(this.CategoryList)).EndInit();
            this.EmpTopPanel.ResumeLayout(false);
            this.EmpTopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView CategoryList;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton EmpDltBtnCat;
        private FontAwesome.Sharp.IconButton EmpSaveBtn;
        private FontAwesome.Sharp.IconButton EmpEditBtnCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CategoryNameTb;
        private System.Windows.Forms.Panel EmpTopPanel;
        private System.Windows.Forms.Label Emp_manage_label;
        private FontAwesome.Sharp.IconButton LeaveBtn;
        private FontAwesome.Sharp.IconButton StaffFormEmployeesBtn;
    }
}