
namespace Modern_Pharmacy_Managment_System
{
    partial class CustomerSettings
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
            this.UpdatePasswordBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ConfirmNewPasswordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.NewPasswordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.CurrentPasswordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // UpdatePasswordBtn
            // 
            this.UpdatePasswordBtn.BorderRadius = 12;
            this.UpdatePasswordBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(55)))), ((int)(((byte)(174)))));
            this.UpdatePasswordBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.UpdatePasswordBtn.ForeColor = System.Drawing.Color.White;
            this.UpdatePasswordBtn.Location = new System.Drawing.Point(286, 312);
            this.UpdatePasswordBtn.Name = "UpdatePasswordBtn";
            this.UpdatePasswordBtn.Size = new System.Drawing.Size(90, 45);
            this.UpdatePasswordBtn.TabIndex = 33;
            this.UpdatePasswordBtn.Text = "Update";
            this.UpdatePasswordBtn.Click += new System.EventHandler(this.UpdatePasswordBtn_Click);
            // 
            // ConfirmNewPasswordTxt
            // 
            this.ConfirmNewPasswordTxt.BorderRadius = 8;
            this.ConfirmNewPasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmNewPasswordTxt.DefaultText = "";
            this.ConfirmNewPasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ConfirmNewPasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ConfirmNewPasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmNewPasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmNewPasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConfirmNewPasswordTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConfirmNewPasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConfirmNewPasswordTxt.Location = new System.Drawing.Point(286, 225);
            this.ConfirmNewPasswordTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConfirmNewPasswordTxt.Name = "ConfirmNewPasswordTxt";
            this.ConfirmNewPasswordTxt.PasswordChar = '\0';
            this.ConfirmNewPasswordTxt.PlaceholderText = "Confirm New Password";
            this.ConfirmNewPasswordTxt.SelectedText = "";
            this.ConfirmNewPasswordTxt.Size = new System.Drawing.Size(237, 44);
            this.ConfirmNewPasswordTxt.TabIndex = 32;
            this.ConfirmNewPasswordTxt.TextOffset = new System.Drawing.Point(25, 0);
            // 
            // NewPasswordTxt
            // 
            this.NewPasswordTxt.BorderRadius = 8;
            this.NewPasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewPasswordTxt.DefaultText = "";
            this.NewPasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NewPasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NewPasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewPasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewPasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewPasswordTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewPasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewPasswordTxt.Location = new System.Drawing.Point(286, 162);
            this.NewPasswordTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewPasswordTxt.Name = "NewPasswordTxt";
            this.NewPasswordTxt.PasswordChar = '\0';
            this.NewPasswordTxt.PlaceholderText = "Enter Your New Password";
            this.NewPasswordTxt.SelectedText = "";
            this.NewPasswordTxt.Size = new System.Drawing.Size(237, 44);
            this.NewPasswordTxt.TabIndex = 31;
            this.NewPasswordTxt.TextOffset = new System.Drawing.Point(25, 0);
            // 
            // CurrentPasswordTxt
            // 
            this.CurrentPasswordTxt.BorderRadius = 8;
            this.CurrentPasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CurrentPasswordTxt.DefaultText = "";
            this.CurrentPasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CurrentPasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CurrentPasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CurrentPasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CurrentPasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CurrentPasswordTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CurrentPasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CurrentPasswordTxt.Location = new System.Drawing.Point(286, 98);
            this.CurrentPasswordTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CurrentPasswordTxt.Name = "CurrentPasswordTxt";
            this.CurrentPasswordTxt.PasswordChar = '\0';
            this.CurrentPasswordTxt.PlaceholderText = "Enter Your Current Password";
            this.CurrentPasswordTxt.SelectedText = "";
            this.CurrentPasswordTxt.Size = new System.Drawing.Size(237, 44);
            this.CurrentPasswordTxt.TabIndex = 30;
            this.CurrentPasswordTxt.TextOffset = new System.Drawing.Point(25, 0);
            // 
            // CustomerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 469);
            this.Controls.Add(this.UpdatePasswordBtn);
            this.Controls.Add(this.ConfirmNewPasswordTxt);
            this.Controls.Add(this.NewPasswordTxt);
            this.Controls.Add(this.CurrentPasswordTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerSettings";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button UpdatePasswordBtn;
        private Guna.UI2.WinForms.Guna2TextBox ConfirmNewPasswordTxt;
        private Guna.UI2.WinForms.Guna2TextBox NewPasswordTxt;
        private Guna.UI2.WinForms.Guna2TextBox CurrentPasswordTxt;
    }
}