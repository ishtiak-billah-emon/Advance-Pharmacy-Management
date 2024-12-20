
namespace Modern_Pharmacy_Managment_System
{
    partial class LeavesForm
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
            this.DateEndCalender = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateStartCalender = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.StatusCb = new System.Windows.Forms.ComboBox();
            this.EmployeeCb = new System.Windows.Forms.ComboBox();
            this.Emp_manage_label = new System.Windows.Forms.Label();
            this.EmpTopPanel = new System.Windows.Forms.Panel();
            this.LeaveEmpLabel = new System.Windows.Forms.Label();
            this.DateStartLabel = new System.Windows.Forms.Label();
            this.DateEndLabel = new System.Windows.Forms.Label();
            this.LeaveStatusLabel = new System.Windows.Forms.Label();
            this.EmpSaveBtnLeave = new FontAwesome.Sharp.IconButton();
            this.EmpDltBtnLeave = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LeaveList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchCb = new System.Windows.Forms.ComboBox();
            this.RefreshBtn = new FontAwesome.Sharp.IconButton();
            this.EmployeesBtn = new FontAwesome.Sharp.IconButton();
            this.ReasonBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmpTxt = new System.Windows.Forms.TextBox();
            this.EmpTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveList)).BeginInit();
            this.SuspendLayout();
            // 
            // DateEndCalender
            // 
            this.DateEndCalender.Checked = true;
            this.DateEndCalender.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DateEndCalender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateEndCalender.ForeColor = System.Drawing.Color.White;
            this.DateEndCalender.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateEndCalender.Location = new System.Drawing.Point(493, 74);
            this.DateEndCalender.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateEndCalender.MinDate = new System.DateTime(2024, 4, 5, 0, 0, 0, 0);
            this.DateEndCalender.Name = "DateEndCalender";
            this.DateEndCalender.Size = new System.Drawing.Size(193, 40);
            this.DateEndCalender.TabIndex = 48;
            this.DateEndCalender.Value = new System.DateTime(2024, 4, 5, 17, 31, 20, 106);
            this.DateEndCalender.ValueChanged += new System.EventHandler(this.DateEndCalender_ValueChanged);
            // 
            // DateStartCalender
            // 
            this.DateStartCalender.Checked = true;
            this.DateStartCalender.FillColor = System.Drawing.Color.Black;
            this.DateStartCalender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateStartCalender.ForeColor = System.Drawing.Color.White;
            this.DateStartCalender.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateStartCalender.Location = new System.Drawing.Point(273, 71);
            this.DateStartCalender.MaxDate = new System.DateTime(9988, 12, 31, 0, 0, 0, 0);
            this.DateStartCalender.MinDate = new System.DateTime(2024, 4, 6, 0, 0, 0, 0);
            this.DateStartCalender.Name = "DateStartCalender";
            this.DateStartCalender.Size = new System.Drawing.Size(211, 38);
            this.DateStartCalender.TabIndex = 47;
            this.DateStartCalender.Value = new System.DateTime(2024, 4, 6, 0, 0, 0, 0);
            // 
            // StatusCb
            // 
            this.StatusCb.BackColor = System.Drawing.Color.White;
            this.StatusCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusCb.FormattingEnabled = true;
            this.StatusCb.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Rejected"});
            this.StatusCb.Location = new System.Drawing.Point(739, 77);
            this.StatusCb.Name = "StatusCb";
            this.StatusCb.Size = new System.Drawing.Size(168, 33);
            this.StatusCb.TabIndex = 46;
            // 
            // EmployeeCb
            // 
            this.EmployeeCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeCb.FormattingEnabled = true;
            this.EmployeeCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmployeeCb.Location = new System.Drawing.Point(12, 74);
            this.EmployeeCb.Name = "EmployeeCb";
            this.EmployeeCb.Size = new System.Drawing.Size(255, 33);
            this.EmployeeCb.TabIndex = 45;
            this.EmployeeCb.Visible = false;
            this.EmployeeCb.SelectedIndexChanged += new System.EventHandler(this.EmployeeCb_SelectedIndexChanged);
            // 
            // Emp_manage_label
            // 
            this.Emp_manage_label.AutoSize = true;
            this.Emp_manage_label.Font = new System.Drawing.Font("ISOCTEUR", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_manage_label.ForeColor = System.Drawing.Color.White;
            this.Emp_manage_label.Location = new System.Drawing.Point(316, -2);
            this.Emp_manage_label.Name = "Emp_manage_label";
            this.Emp_manage_label.Size = new System.Drawing.Size(315, 34);
            this.Emp_manage_label.TabIndex = 0;
            this.Emp_manage_label.Text = "MANAGING LEAVES";
            // 
            // EmpTopPanel
            // 
            this.EmpTopPanel.BackColor = System.Drawing.Color.Gray;
            this.EmpTopPanel.Controls.Add(this.Emp_manage_label);
            this.EmpTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmpTopPanel.Location = new System.Drawing.Point(0, 0);
            this.EmpTopPanel.Name = "EmpTopPanel";
            this.EmpTopPanel.Size = new System.Drawing.Size(1363, 32);
            this.EmpTopPanel.TabIndex = 28;
            // 
            // LeaveEmpLabel
            // 
            this.LeaveEmpLabel.AutoSize = true;
            this.LeaveEmpLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveEmpLabel.ForeColor = System.Drawing.Color.Black;
            this.LeaveEmpLabel.Location = new System.Drawing.Point(26, 48);
            this.LeaveEmpLabel.Name = "LeaveEmpLabel";
            this.LeaveEmpLabel.Size = new System.Drawing.Size(101, 23);
            this.LeaveEmpLabel.TabIndex = 30;
            this.LeaveEmpLabel.Text = "Employees";
            // 
            // DateStartLabel
            // 
            this.DateStartLabel.AutoSize = true;
            this.DateStartLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateStartLabel.ForeColor = System.Drawing.Color.Black;
            this.DateStartLabel.Location = new System.Drawing.Point(270, 48);
            this.DateStartLabel.Name = "DateStartLabel";
            this.DateStartLabel.Size = new System.Drawing.Size(99, 23);
            this.DateStartLabel.TabIndex = 32;
            this.DateStartLabel.Text = "Date Start";
            // 
            // DateEndLabel
            // 
            this.DateEndLabel.AutoSize = true;
            this.DateEndLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateEndLabel.ForeColor = System.Drawing.Color.Black;
            this.DateEndLabel.Location = new System.Drawing.Point(489, 48);
            this.DateEndLabel.Name = "DateEndLabel";
            this.DateEndLabel.Size = new System.Drawing.Size(89, 23);
            this.DateEndLabel.TabIndex = 33;
            this.DateEndLabel.Text = "Date End";
            // 
            // LeaveStatusLabel
            // 
            this.LeaveStatusLabel.AutoSize = true;
            this.LeaveStatusLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.LeaveStatusLabel.Location = new System.Drawing.Point(739, 48);
            this.LeaveStatusLabel.Name = "LeaveStatusLabel";
            this.LeaveStatusLabel.Size = new System.Drawing.Size(63, 23);
            this.LeaveStatusLabel.TabIndex = 34;
            this.LeaveStatusLabel.Text = "Status";
            // 
            // EmpSaveBtnLeave
            // 
            this.EmpSaveBtnLeave.BackColor = System.Drawing.Color.Black;
            this.EmpSaveBtnLeave.FlatAppearance.BorderSize = 0;
            this.EmpSaveBtnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpSaveBtnLeave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpSaveBtnLeave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EmpSaveBtnLeave.IconColor = System.Drawing.Color.Black;
            this.EmpSaveBtnLeave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmpSaveBtnLeave.Location = new System.Drawing.Point(988, 74);
            this.EmpSaveBtnLeave.Name = "EmpSaveBtnLeave";
            this.EmpSaveBtnLeave.Size = new System.Drawing.Size(157, 42);
            this.EmpSaveBtnLeave.TabIndex = 36;
            this.EmpSaveBtnLeave.Text = "Save";
            this.EmpSaveBtnLeave.UseVisualStyleBackColor = false;
            this.EmpSaveBtnLeave.Click += new System.EventHandler(this.EmpSaveBtnLeave_Click);
            // 
            // EmpDltBtnLeave
            // 
            this.EmpDltBtnLeave.BackColor = System.Drawing.Color.Gray;
            this.EmpDltBtnLeave.FlatAppearance.BorderSize = 0;
            this.EmpDltBtnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpDltBtnLeave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpDltBtnLeave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EmpDltBtnLeave.IconColor = System.Drawing.Color.Black;
            this.EmpDltBtnLeave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmpDltBtnLeave.Location = new System.Drawing.Point(988, 121);
            this.EmpDltBtnLeave.Name = "EmpDltBtnLeave";
            this.EmpDltBtnLeave.Size = new System.Drawing.Size(157, 42);
            this.EmpDltBtnLeave.TabIndex = 37;
            this.EmpDltBtnLeave.Text = "Delete";
            this.EmpDltBtnLeave.UseVisualStyleBackColor = false;
            this.EmpDltBtnLeave.Click += new System.EventHandler(this.EmpDltBtnLeave_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(12, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1272, 10);
            this.panel3.TabIndex = 41;
            // 
            // LeaveList
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.LeaveList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LeaveList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.LeaveList.ColumnHeadersHeight = 28;
            this.LeaveList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LeaveList.DefaultCellStyle = dataGridViewCellStyle6;
            this.LeaveList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.LeaveList.Location = new System.Drawing.Point(30, 374);
            this.LeaveList.Name = "LeaveList";
            this.LeaveList.RowHeadersVisible = false;
            this.LeaveList.RowHeadersWidth = 51;
            this.LeaveList.RowTemplate.Height = 24;
            this.LeaveList.Size = new System.Drawing.Size(1254, 310);
            this.LeaveList.TabIndex = 42;
            this.LeaveList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.LeaveList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.LeaveList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.LeaveList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.LeaveList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.LeaveList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.LeaveList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.LeaveList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.LeaveList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.LeaveList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.LeaveList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.LeaveList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.LeaveList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.LeaveList.ThemeStyle.HeaderStyle.Height = 28;
            this.LeaveList.ThemeStyle.ReadOnly = false;
            this.LeaveList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.LeaveList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LeaveList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.LeaveList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.LeaveList.ThemeStyle.RowsStyle.Height = 24;
            this.LeaveList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.LeaveList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.LeaveList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LeaveList_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(546, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 32);
            this.label5.TabIndex = 43;
            this.label5.Text = "Leaves List";
            // 
            // SearchCb
            // 
            this.SearchCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCb.FormattingEnabled = true;
            this.SearchCb.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Rejected"});
            this.SearchCb.Location = new System.Drawing.Point(542, 319);
            this.SearchCb.Name = "SearchCb";
            this.SearchCb.Size = new System.Drawing.Size(168, 33);
            this.SearchCb.TabIndex = 49;
            this.SearchCb.SelectedIndexChanged += new System.EventHandler(this.SearchCb_SelectedIndexChanged);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(1)))), ((int)(((byte)(113)))));
            this.RefreshBtn.FlatAppearance.BorderSize = 0;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RefreshBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.RefreshBtn.IconColor = System.Drawing.Color.Black;
            this.RefreshBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RefreshBtn.Location = new System.Drawing.Point(716, 319);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(133, 33);
            this.RefreshBtn.TabIndex = 50;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // EmployeesBtn
            // 
            this.EmployeesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmployeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeesBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmployeesBtn.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.EmployeesBtn.IconColor = System.Drawing.Color.White;
            this.EmployeesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmployeesBtn.IconSize = 30;
            this.EmployeesBtn.Location = new System.Drawing.Point(988, 169);
            this.EmployeesBtn.Name = "EmployeesBtn";
            this.EmployeesBtn.Size = new System.Drawing.Size(157, 49);
            this.EmployeesBtn.TabIndex = 0;
            this.EmployeesBtn.Text = "Employees";
            this.EmployeesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EmployeesBtn.UseVisualStyleBackColor = false;
            this.EmployeesBtn.Click += new System.EventHandler(this.EmployeesBtn_Click);
            // 
            // ReasonBox
            // 
            this.ReasonBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReasonBox.Location = new System.Drawing.Point(493, 127);
            this.ReasonBox.Multiline = true;
            this.ReasonBox.Name = "ReasonBox";
            this.ReasonBox.Size = new System.Drawing.Size(328, 103);
            this.ReasonBox.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(388, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 52;
            this.label1.Text = "Reason";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 774);
            this.panel1.TabIndex = 53;
            // 
            // EmpTxt
            // 
            this.EmpTxt.Location = new System.Drawing.Point(16, 74);
            this.EmpTxt.Multiline = true;
            this.EmpTxt.Name = "EmpTxt";
            this.EmpTxt.Size = new System.Drawing.Size(148, 36);
            this.EmpTxt.TabIndex = 54;
            // 
            // LeavesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 806);
            this.Controls.Add(this.EmpTxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReasonBox);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.SearchCb);
            this.Controls.Add(this.DateEndCalender);
            this.Controls.Add(this.EmployeesBtn);
            this.Controls.Add(this.DateStartCalender);
            this.Controls.Add(this.StatusCb);
            this.Controls.Add(this.EmployeeCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LeaveList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.EmpDltBtnLeave);
            this.Controls.Add(this.EmpSaveBtnLeave);
            this.Controls.Add(this.LeaveStatusLabel);
            this.Controls.Add(this.DateEndLabel);
            this.Controls.Add(this.DateStartLabel);
            this.Controls.Add(this.LeaveEmpLabel);
            this.Controls.Add(this.EmpTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LeavesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeavesForm";
            this.EmpTopPanel.ResumeLayout(false);
            this.EmpTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker DateEndCalender;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateStartCalender;
        private System.Windows.Forms.ComboBox StatusCb;
        private System.Windows.Forms.ComboBox EmployeeCb;
        private System.Windows.Forms.Label Emp_manage_label;
        private System.Windows.Forms.Panel EmpTopPanel;
        private System.Windows.Forms.Label LeaveEmpLabel;
        private System.Windows.Forms.Label DateStartLabel;
        private System.Windows.Forms.Label DateEndLabel;
        private System.Windows.Forms.Label LeaveStatusLabel;
        private FontAwesome.Sharp.IconButton EmpSaveBtnLeave;
        private FontAwesome.Sharp.IconButton EmpDltBtnLeave;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView LeaveList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SearchCb;
        private FontAwesome.Sharp.IconButton RefreshBtn;
        private FontAwesome.Sharp.IconButton EmployeesBtn;
        private System.Windows.Forms.TextBox ReasonBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox EmpTxt;
    }
}