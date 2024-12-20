
namespace Modern_Pharmacy_Managment_System
{
    partial class EmployeeSalary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeSalary));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PayDateCalender = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SalaryView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Emp_manage_label = new System.Windows.Forms.Label();
            this.SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.EmpIdTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.SalaryAmountTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.NotificationImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.SearchButton = new FontAwesome.Sharp.IconButton();
            this.DeleteSalaryBtn = new FontAwesome.Sharp.IconButton();
            this.SalaryPaidButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.label3.Location = new System.Drawing.Point(146, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "EmpId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(146, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Salary Amount";
            // 
            // PayDateCalender
            // 
            this.PayDateCalender.Checked = true;
            this.PayDateCalender.FillColor = System.Drawing.Color.DimGray;
            this.PayDateCalender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PayDateCalender.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.PayDateCalender.Location = new System.Drawing.Point(150, 253);
            this.PayDateCalender.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.PayDateCalender.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.PayDateCalender.Name = "PayDateCalender";
            this.PayDateCalender.Size = new System.Drawing.Size(221, 54);
            this.PayDateCalender.TabIndex = 10;
            this.PayDateCalender.Value = new System.DateTime(2024, 5, 3, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(146, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pay Date";
            // 
            // SalaryView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.SalaryView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalaryView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.SalaryView.ColumnHeadersHeight = 19;
            this.SalaryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SalaryView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SalaryView.DefaultCellStyle = dataGridViewCellStyle6;
            this.SalaryView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.SalaryView.Location = new System.Drawing.Point(28, 381);
            this.SalaryView.Name = "SalaryView";
            this.SalaryView.RowHeadersVisible = false;
            this.SalaryView.RowHeadersWidth = 51;
            this.SalaryView.RowTemplate.Height = 24;
            this.SalaryView.Size = new System.Drawing.Size(1254, 342);
            this.SalaryView.TabIndex = 15;
            this.SalaryView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.SalaryView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.SalaryView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SalaryView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SalaryView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SalaryView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SalaryView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SalaryView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.SalaryView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.SalaryView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SalaryView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SalaryView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SalaryView.ThemeStyle.HeaderStyle.Height = 19;
            this.SalaryView.ThemeStyle.ReadOnly = false;
            this.SalaryView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.SalaryView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SalaryView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.SalaryView.ThemeStyle.RowsStyle.Height = 24;
            this.SalaryView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.SalaryView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.SalaryView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalaryView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SalaryId";
            this.Column1.HeaderText = "Salary Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "EmpId";
            this.Column2.HeaderText = "Employee Id";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SalaryPaidAmount";
            this.Column3.HeaderText = "Paid Amount";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SalaryPaidDate";
            this.Column4.HeaderText = "Paid Date";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.Emp_manage_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 36);
            this.panel1.TabIndex = 16;
            // 
            // Emp_manage_label
            // 
            this.Emp_manage_label.AutoSize = true;
            this.Emp_manage_label.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_manage_label.ForeColor = System.Drawing.Color.White;
            this.Emp_manage_label.Location = new System.Drawing.Point(349, 7);
            this.Emp_manage_label.Name = "Emp_manage_label";
            this.Emp_manage_label.Size = new System.Drawing.Size(376, 29);
            this.Emp_manage_label.TabIndex = 1;
            this.Emp_manage_label.Text = "EMPLOYEE SALARY MANAGEMENT";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox.DefaultText = "";
            this.SearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.Location = new System.Drawing.Point(978, 113);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.PlaceholderText = "Enter Employee Id";
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.Size = new System.Drawing.Size(229, 44);
            this.SearchTextBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.label4.Location = new System.Drawing.Point(974, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Search Employee";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 339);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1299, 10);
            this.guna2Panel1.TabIndex = 20;
            // 
            // EmpIdTxt
            // 
            this.EmpIdTxt.BorderRadius = 8;
            this.EmpIdTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpIdTxt.DefaultText = "";
            this.EmpIdTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmpIdTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmpIdTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpIdTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpIdTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpIdTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmpIdTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpIdTxt.Location = new System.Drawing.Point(150, 86);
            this.EmpIdTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmpIdTxt.Name = "EmpIdTxt";
            this.EmpIdTxt.PasswordChar = '\0';
            this.EmpIdTxt.PlaceholderText = "";
            this.EmpIdTxt.SelectedText = "";
            this.EmpIdTxt.Size = new System.Drawing.Size(200, 41);
            this.EmpIdTxt.TabIndex = 22;
            // 
            // SalaryAmountTxt
            // 
            this.SalaryAmountTxt.BorderRadius = 8;
            this.SalaryAmountTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SalaryAmountTxt.DefaultText = "";
            this.SalaryAmountTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SalaryAmountTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SalaryAmountTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SalaryAmountTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SalaryAmountTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalaryAmountTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SalaryAmountTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalaryAmountTxt.Location = new System.Drawing.Point(150, 166);
            this.SalaryAmountTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SalaryAmountTxt.Name = "SalaryAmountTxt";
            this.SalaryAmountTxt.PasswordChar = '\0';
            this.SalaryAmountTxt.PlaceholderText = "";
            this.SalaryAmountTxt.SelectedText = "";
            this.SalaryAmountTxt.Size = new System.Drawing.Size(200, 41);
            this.SalaryAmountTxt.TabIndex = 23;
            // 
            // NotificationImage
            // 
            this.NotificationImage.Image = ((System.Drawing.Image)(resources.GetObject("NotificationImage.Image")));
            this.NotificationImage.ImageRotate = 0F;
            this.NotificationImage.Location = new System.Drawing.Point(1251, 42);
            this.NotificationImage.Name = "NotificationImage";
            this.NotificationImage.Size = new System.Drawing.Size(48, 34);
            this.NotificationImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NotificationImage.TabIndex = 21;
            this.NotificationImage.TabStop = false;
            this.NotificationImage.Click += new System.EventHandler(this.NotificationImage_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SearchButton.IconChar = FontAwesome.Sharp.IconChar.SteamSymbol;
            this.SearchButton.IconColor = System.Drawing.Color.Black;
            this.SearchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SearchButton.Location = new System.Drawing.Point(978, 166);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(188, 67);
            this.SearchButton.TabIndex = 18;
            this.SearchButton.Text = "Search";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DeleteSalaryBtn
            // 
            this.DeleteSalaryBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DeleteSalaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSalaryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSalaryBtn.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
            this.DeleteSalaryBtn.IconColor = System.Drawing.Color.Black;
            this.DeleteSalaryBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteSalaryBtn.Location = new System.Drawing.Point(455, 256);
            this.DeleteSalaryBtn.Name = "DeleteSalaryBtn";
            this.DeleteSalaryBtn.Size = new System.Drawing.Size(202, 61);
            this.DeleteSalaryBtn.TabIndex = 14;
            this.DeleteSalaryBtn.Text = "Delete";
            this.DeleteSalaryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteSalaryBtn.UseVisualStyleBackColor = false;
            this.DeleteSalaryBtn.Click += new System.EventHandler(this.DeleteSalaryBtn_Click);
            // 
            // SalaryPaidButton
            // 
            this.SalaryPaidButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SalaryPaidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalaryPaidButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryPaidButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SalaryPaidButton.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.SalaryPaidButton.IconColor = System.Drawing.Color.White;
            this.SalaryPaidButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SalaryPaidButton.Location = new System.Drawing.Point(455, 183);
            this.SalaryPaidButton.Name = "SalaryPaidButton";
            this.SalaryPaidButton.Size = new System.Drawing.Size(202, 67);
            this.SalaryPaidButton.TabIndex = 13;
            this.SalaryPaidButton.Text = "Pay ";
            this.SalaryPaidButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SalaryPaidButton.UseVisualStyleBackColor = false;
            this.SalaryPaidButton.Click += new System.EventHandler(this.SalaryPaidButton_Click);
            // 
            // EmployeeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1311, 754);
            this.Controls.Add(this.SalaryAmountTxt);
            this.Controls.Add(this.EmpIdTxt);
            this.Controls.Add(this.NotificationImage);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SalaryView);
            this.Controls.Add(this.DeleteSalaryBtn);
            this.Controls.Add(this.SalaryPaidButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PayDateCalender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeSalary";
            ((System.ComponentModel.ISupportInitialize)(this.SalaryView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker PayDateCalender;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton SalaryPaidButton;
        private FontAwesome.Sharp.IconButton DeleteSalaryBtn;
        private Guna.UI2.WinForms.Guna2DataGridView SalaryView;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton SearchButton;
        private System.Windows.Forms.Label Emp_manage_label;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
       // private System.Windows.Forms.Timer SalaryNotificationTimer;
        private Guna.UI2.WinForms.Guna2PictureBox NotificationImage;
        private Guna.UI2.WinForms.Guna2TextBox EmpIdTxt;
        private Guna.UI2.WinForms.Guna2TextBox SalaryAmountTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}