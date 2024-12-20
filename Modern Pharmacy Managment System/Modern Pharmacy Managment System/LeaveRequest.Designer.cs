
namespace Modern_Pharmacy_Managment_System
{
    partial class LeaveRequest
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
            this.IdTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LeaveCategoriesLabel = new System.Windows.Forms.Label();
            this.DateStartCalender = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateStartLabel = new System.Windows.Forms.Label();
            this.DateEndCalender = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateEndLabel = new System.Windows.Forms.Label();
            this.RequestLeaveBtn = new FontAwesome.Sharp.IconButton();
            this.ReasonTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // IdTxt
            // 
            this.IdTxt.BorderRadius = 8;
            this.IdTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IdTxt.DefaultText = "";
            this.IdTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IdTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IdTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IdTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IdTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IdTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IdTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IdTxt.Location = new System.Drawing.Point(43, 58);
            this.IdTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.PasswordChar = '\0';
            this.IdTxt.PlaceholderText = "";
            this.IdTxt.SelectedText = "";
            this.IdTxt.Size = new System.Drawing.Size(102, 36);
            this.IdTxt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Enter Your Id";
            // 
            // LeaveCategoriesLabel
            // 
            this.LeaveCategoriesLabel.AutoSize = true;
            this.LeaveCategoriesLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveCategoriesLabel.ForeColor = System.Drawing.Color.Black;
            this.LeaveCategoriesLabel.Location = new System.Drawing.Point(259, 22);
            this.LeaveCategoriesLabel.Name = "LeaveCategoriesLabel";
            this.LeaveCategoriesLabel.Size = new System.Drawing.Size(72, 23);
            this.LeaveCategoriesLabel.TabIndex = 46;
            this.LeaveCategoriesLabel.Text = "Reason";
            // 
            // DateStartCalender
            // 
            this.DateStartCalender.BorderColor = System.Drawing.Color.DimGray;
            this.DateStartCalender.BorderRadius = 8;
            this.DateStartCalender.BorderThickness = 2;
            this.DateStartCalender.Checked = true;
            this.DateStartCalender.FillColor = System.Drawing.Color.Black;
            this.DateStartCalender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateStartCalender.ForeColor = System.Drawing.Color.White;
            this.DateStartCalender.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateStartCalender.Location = new System.Drawing.Point(418, 55);
            this.DateStartCalender.MaxDate = new System.DateTime(9988, 12, 31, 0, 0, 0, 0);
            this.DateStartCalender.MinDate = new System.DateTime(2024, 4, 6, 0, 0, 0, 0);
            this.DateStartCalender.Name = "DateStartCalender";
            this.DateStartCalender.Size = new System.Drawing.Size(211, 36);
            this.DateStartCalender.TabIndex = 49;
            this.DateStartCalender.Value = new System.DateTime(2024, 4, 6, 0, 0, 0, 0);
            // 
            // DateStartLabel
            // 
            this.DateStartLabel.AutoSize = true;
            this.DateStartLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateStartLabel.ForeColor = System.Drawing.Color.Black;
            this.DateStartLabel.Location = new System.Drawing.Point(414, 29);
            this.DateStartLabel.Name = "DateStartLabel";
            this.DateStartLabel.Size = new System.Drawing.Size(99, 23);
            this.DateStartLabel.TabIndex = 48;
            this.DateStartLabel.Text = "Date Start";
            // 
            // DateEndCalender
            // 
            this.DateEndCalender.BorderRadius = 8;
            this.DateEndCalender.BorderThickness = 3;
            this.DateEndCalender.Checked = true;
            this.DateEndCalender.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DateEndCalender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateEndCalender.ForeColor = System.Drawing.Color.White;
            this.DateEndCalender.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateEndCalender.Location = new System.Drawing.Point(650, 52);
            this.DateEndCalender.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateEndCalender.MinDate = new System.DateTime(2024, 4, 5, 0, 0, 0, 0);
            this.DateEndCalender.Name = "DateEndCalender";
            this.DateEndCalender.Size = new System.Drawing.Size(193, 39);
            this.DateEndCalender.TabIndex = 51;
            this.DateEndCalender.Value = new System.DateTime(2024, 4, 5, 17, 31, 20, 106);
            // 
            // DateEndLabel
            // 
            this.DateEndLabel.AutoSize = true;
            this.DateEndLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateEndLabel.ForeColor = System.Drawing.Color.Black;
            this.DateEndLabel.Location = new System.Drawing.Point(646, 26);
            this.DateEndLabel.Name = "DateEndLabel";
            this.DateEndLabel.Size = new System.Drawing.Size(89, 23);
            this.DateEndLabel.TabIndex = 50;
            this.DateEndLabel.Text = "Date End";
            // 
            // RequestLeaveBtn
            // 
            this.RequestLeaveBtn.BackColor = System.Drawing.Color.DimGray;
            this.RequestLeaveBtn.FlatAppearance.BorderSize = 0;
            this.RequestLeaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RequestLeaveBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RequestLeaveBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.RequestLeaveBtn.IconColor = System.Drawing.Color.Beige;
            this.RequestLeaveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RequestLeaveBtn.Location = new System.Drawing.Point(418, 97);
            this.RequestLeaveBtn.Name = "RequestLeaveBtn";
            this.RequestLeaveBtn.Size = new System.Drawing.Size(179, 49);
            this.RequestLeaveBtn.TabIndex = 52;
            this.RequestLeaveBtn.Text = "Request Leave";
            this.RequestLeaveBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RequestLeaveBtn.UseVisualStyleBackColor = false;
            // 
            // ReasonTxt
            // 
            this.ReasonTxt.BorderRadius = 8;
            this.ReasonTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ReasonTxt.DefaultText = "";
            this.ReasonTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ReasonTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ReasonTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReasonTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReasonTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReasonTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ReasonTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReasonTxt.Location = new System.Drawing.Point(200, 49);
            this.ReasonTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReasonTxt.Name = "ReasonTxt";
            this.ReasonTxt.PasswordChar = '\0';
            this.ReasonTxt.PlaceholderText = "";
            this.ReasonTxt.SelectedText = "";
            this.ReasonTxt.Size = new System.Drawing.Size(197, 91);
            this.ReasonTxt.TabIndex = 53;
            // 
            // LeaveRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(946, 173);
            this.Controls.Add(this.ReasonTxt);
            this.Controls.Add(this.RequestLeaveBtn);
            this.Controls.Add(this.DateEndCalender);
            this.Controls.Add(this.DateEndLabel);
            this.Controls.Add(this.DateStartCalender);
            this.Controls.Add(this.DateStartLabel);
            this.Controls.Add(this.LeaveCategoriesLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LeaveRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeaveRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox IdTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LeaveCategoriesLabel;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateStartCalender;
        private System.Windows.Forms.Label DateStartLabel;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateEndCalender;
        private System.Windows.Forms.Label DateEndLabel;
        private FontAwesome.Sharp.IconButton RequestLeaveBtn;
        private Guna.UI2.WinForms.Guna2TextBox ReasonTxt;
    }
}