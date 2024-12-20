
namespace Modern_Pharmacy_Managment_System
{
    partial class DashBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DropdownPanel = new System.Windows.Forms.Panel();
            this.SalaryPayBtn = new FontAwesome.Sharp.IconButton();
            this.StaffBtn = new FontAwesome.Sharp.IconButton();
            this.ManagementBtn = new FontAwesome.Sharp.IconButton();
            this.flowdropdownpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RevenueBtn = new FontAwesome.Sharp.IconButton();
            this.InventoryBtn = new FontAwesome.Sharp.IconButton();
            this.Settings = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.DashBoardBtn = new FontAwesome.Sharp.IconButton();
            this.AdminPictureBox = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateTimeShow = new System.Windows.Forms.Timer(this.components);
            this.mainpanel = new System.Windows.Forms.Panel();
            this.iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            this.LeftPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.DropdownPanel.SuspendLayout();
            this.flowdropdownpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPictureBox)).BeginInit();
            this.topPanel.SuspendLayout();
            this.TimerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(277, 59);
            this.LogoPanel.TabIndex = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.LeftPanel.Controls.Add(this.flowLayoutPanel1);
            this.LeftPanel.Controls.Add(this.DashBoardBtn);
            this.LeftPanel.Controls.Add(this.AdminPictureBox);
            this.LeftPanel.Controls.Add(this.LogoPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(277, 887);
            this.LeftPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.DropdownPanel);
            this.flowLayoutPanel1.Controls.Add(this.flowdropdownpanel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 207);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(277, 530);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // DropdownPanel
            // 
            this.DropdownPanel.Controls.Add(this.SalaryPayBtn);
            this.DropdownPanel.Controls.Add(this.StaffBtn);
            this.DropdownPanel.Controls.Add(this.ManagementBtn);
            this.DropdownPanel.Location = new System.Drawing.Point(3, 2);
            this.DropdownPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DropdownPanel.MaximumSize = new System.Drawing.Size(268, 190);
            this.DropdownPanel.MinimumSize = new System.Drawing.Size(268, 62);
            this.DropdownPanel.Name = "DropdownPanel";
            this.DropdownPanel.Size = new System.Drawing.Size(268, 62);
            this.DropdownPanel.TabIndex = 1;
            // 
            // SalaryPayBtn
            // 
            this.SalaryPayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.SalaryPayBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SalaryPayBtn.FlatAppearance.BorderSize = 0;
            this.SalaryPayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalaryPayBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SalaryPayBtn.IconChar = FontAwesome.Sharp.IconChar.CcAmazonPay;
            this.SalaryPayBtn.IconColor = System.Drawing.Color.White;
            this.SalaryPayBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SalaryPayBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalaryPayBtn.Location = new System.Drawing.Point(0, 124);
            this.SalaryPayBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalaryPayBtn.Name = "SalaryPayBtn";
            this.SalaryPayBtn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.SalaryPayBtn.Size = new System.Drawing.Size(268, 65);
            this.SalaryPayBtn.TabIndex = 6;
            this.SalaryPayBtn.Text = "Salary";
            this.SalaryPayBtn.UseVisualStyleBackColor = false;
            this.SalaryPayBtn.Click += new System.EventHandler(this.SalaryPayBtn_Click);
            // 
            // StaffBtn
            // 
            this.StaffBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.StaffBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.StaffBtn.FlatAppearance.BorderSize = 0;
            this.StaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StaffBtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            this.StaffBtn.IconColor = System.Drawing.Color.White;
            this.StaffBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.StaffBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StaffBtn.Location = new System.Drawing.Point(0, 62);
            this.StaffBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StaffBtn.Name = "StaffBtn";
            this.StaffBtn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.StaffBtn.Size = new System.Drawing.Size(268, 62);
            this.StaffBtn.TabIndex = 5;
            this.StaffBtn.Text = "Staff";
            this.StaffBtn.UseVisualStyleBackColor = false;
            this.StaffBtn.Click += new System.EventHandler(this.StaffBtn_Click);
            // 
            // ManagementBtn
            // 
            this.ManagementBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.ManagementBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManagementBtn.FlatAppearance.BorderSize = 0;
            this.ManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagementBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ManagementBtn.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.ManagementBtn.IconColor = System.Drawing.Color.White;
            this.ManagementBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ManagementBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManagementBtn.Location = new System.Drawing.Point(0, 0);
            this.ManagementBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ManagementBtn.Name = "ManagementBtn";
            this.ManagementBtn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.ManagementBtn.Size = new System.Drawing.Size(268, 62);
            this.ManagementBtn.TabIndex = 3;
            this.ManagementBtn.Text = "   Management";
            this.ManagementBtn.UseVisualStyleBackColor = false;
            this.ManagementBtn.Click += new System.EventHandler(this.ManagementBtn_Click);
            // 
            // flowdropdownpanel
            // 
            this.flowdropdownpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.flowdropdownpanel.Controls.Add(this.RevenueBtn);
            this.flowdropdownpanel.Controls.Add(this.InventoryBtn);
            this.flowdropdownpanel.Controls.Add(this.Settings);
            this.flowdropdownpanel.Controls.Add(this.iconButton1);
            this.flowdropdownpanel.Location = new System.Drawing.Point(3, 68);
            this.flowdropdownpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowdropdownpanel.Name = "flowdropdownpanel";
            this.flowdropdownpanel.Size = new System.Drawing.Size(296, 427);
            this.flowdropdownpanel.TabIndex = 2;
            // 
            // RevenueBtn
            // 
            this.RevenueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.RevenueBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.RevenueBtn.FlatAppearance.BorderSize = 0;
            this.RevenueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RevenueBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RevenueBtn.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTrendUp;
            this.RevenueBtn.IconColor = System.Drawing.Color.White;
            this.RevenueBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RevenueBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RevenueBtn.Location = new System.Drawing.Point(3, 2);
            this.RevenueBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RevenueBtn.Name = "RevenueBtn";
            this.RevenueBtn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.RevenueBtn.Size = new System.Drawing.Size(268, 62);
            this.RevenueBtn.TabIndex = 2;
            this.RevenueBtn.Text = "Revenue";
            this.RevenueBtn.UseVisualStyleBackColor = false;
            this.RevenueBtn.Click += new System.EventHandler(this.RevenueBtn_Click);
            // 
            // InventoryBtn
            // 
            this.InventoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.InventoryBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventoryBtn.FlatAppearance.BorderSize = 0;
            this.InventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InventoryBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InventoryBtn.IconChar = FontAwesome.Sharp.IconChar.Indent;
            this.InventoryBtn.IconColor = System.Drawing.Color.White;
            this.InventoryBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.InventoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InventoryBtn.Location = new System.Drawing.Point(3, 68);
            this.InventoryBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InventoryBtn.Name = "InventoryBtn";
            this.InventoryBtn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.InventoryBtn.Size = new System.Drawing.Size(268, 62);
            this.InventoryBtn.TabIndex = 4;
            this.InventoryBtn.Text = "Inventory";
            this.InventoryBtn.UseVisualStyleBackColor = false;
            this.InventoryBtn.Click += new System.EventHandler(this.InventoryBtn_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Settings.IconChar = FontAwesome.Sharp.IconChar.CloudSun;
            this.Settings.IconColor = System.Drawing.Color.White;
            this.Settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Location = new System.Drawing.Point(3, 134);
            this.Settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.Settings.Size = new System.Drawing.Size(268, 62);
            this.Settings.TabIndex = 5;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(3, 200);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(268, 62);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.Text = "Logout";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // DashBoardBtn
            // 
            this.DashBoardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashBoardBtn.FlatAppearance.BorderSize = 0;
            this.DashBoardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashBoardBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DashBoardBtn.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyUser;
            this.DashBoardBtn.IconColor = System.Drawing.Color.White;
            this.DashBoardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DashBoardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashBoardBtn.Location = new System.Drawing.Point(0, 143);
            this.DashBoardBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DashBoardBtn.Name = "DashBoardBtn";
            this.DashBoardBtn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.DashBoardBtn.Size = new System.Drawing.Size(277, 60);
            this.DashBoardBtn.TabIndex = 2;
            this.DashBoardBtn.Text = "Dashboard";
            this.DashBoardBtn.UseVisualStyleBackColor = true;
            this.DashBoardBtn.Click += new System.EventHandler(this.DashBoardBtn_Click);
            // 
            // AdminPictureBox
            // 
            this.AdminPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AdminPictureBox.Image")));
            this.AdminPictureBox.Location = new System.Drawing.Point(0, 59);
            this.AdminPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminPictureBox.Name = "AdminPictureBox";
            this.AdminPictureBox.Size = new System.Drawing.Size(277, 84);
            this.AdminPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AdminPictureBox.TabIndex = 1;
            this.AdminPictureBox.TabStop = false;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.TimerPanel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(277, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1365, 59);
            this.topPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(399, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "NEURON PHARMACY";
            // 
            // TimerPanel
            // 
            this.TimerPanel.BackColor = System.Drawing.Color.Transparent;
            this.TimerPanel.Controls.Add(this.pictureBox1);
            this.TimerPanel.Controls.Add(this.DateLabel);
            this.TimerPanel.Controls.Add(this.TimeLabel);
            this.TimerPanel.Location = new System.Drawing.Point(1151, -4);
            this.TimerPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimerPanel.Name = "TimerPanel";
            this.TimerPanel.Size = new System.Drawing.Size(211, 57);
            this.TimerPanel.TabIndex = 0;
            this.TimerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TimerPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.White;
            this.DateLabel.Location = new System.Drawing.Point(3, 36);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(45, 20);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "Date";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.White;
            this.TimeLabel.Location = new System.Drawing.Point(3, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(46, 20);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "Time";
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // DateTimeShow
            // 
            this.DateTimeShow.Enabled = true;
            this.DateTimeShow.Tick += new System.EventHandler(this.DateTimeShow_Tick);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mainpanel.Location = new System.Drawing.Point(277, 59);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1353, 817);
            this.mainpanel.TabIndex = 2;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // iconDropDownButton1
            // 
            this.iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconDropDownButton1.IconColor = System.Drawing.Color.Black;
            this.iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDropDownButton1.Name = "iconDropDownButton1";
            this.iconDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1642, 887);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.LeftPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.DropdownPanel.ResumeLayout(false);
            this.flowdropdownpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdminPictureBox)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.TimerPanel.ResumeLayout(false);
            this.TimerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox AdminPictureBox;
        private System.Windows.Forms.Panel LeftPanel;
        private FontAwesome.Sharp.IconButton DashBoardBtn;
        private System.Windows.Forms.Panel DropdownPanel;
        private FontAwesome.Sharp.IconButton StaffBtn;
        private FontAwesome.Sharp.IconButton ManagementBtn;
        private System.Windows.Forms.FlowLayoutPanel flowdropdownpanel;
        private FontAwesome.Sharp.IconButton RevenueBtn;
        private FontAwesome.Sharp.IconButton InventoryBtn;
        private FontAwesome.Sharp.IconButton Settings;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer DateTimeShow;
        private System.Windows.Forms.Panel TimerPanel;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton SalaryPayBtn;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
    }
}