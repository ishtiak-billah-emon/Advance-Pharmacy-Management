
namespace Modern_Pharmacy_Managment_System
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanelSignup = new Guna.UI2.WinForms.Guna2Panel();
            this.signupLoginLabel = new System.Windows.Forms.LinkLabel();
            this.signupBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainPanelSignup.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(343, 506);
            this.guna2Panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-19, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 506);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainPanelSignup
            // 
            this.mainPanelSignup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanelSignup.Controls.Add(this.signupLoginLabel);
            this.mainPanelSignup.Controls.Add(this.signupBtn);
            this.mainPanelSignup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelSignup.Location = new System.Drawing.Point(343, 0);
            this.mainPanelSignup.Name = "mainPanelSignup";
            this.mainPanelSignup.Size = new System.Drawing.Size(380, 506);
            this.mainPanelSignup.TabIndex = 1;
            // 
            // signupLoginLabel
            // 
            this.signupLoginLabel.AutoSize = true;
            this.signupLoginLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupLoginLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.signupLoginLabel.Location = new System.Drawing.Point(234, 432);
            this.signupLoginLabel.Name = "signupLoginLabel";
            this.signupLoginLabel.Size = new System.Drawing.Size(37, 15);
            this.signupLoginLabel.TabIndex = 7;
            this.signupLoginLabel.TabStop = true;
            this.signupLoginLabel.Text = "Login";
            this.signupLoginLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signupLoginLabel_LinkClicked);
            // 
            // signupBtn
            // 
            this.signupBtn.BorderRadius = 5;
            this.signupBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.signupBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.signupBtn.ForeColor = System.Drawing.Color.White;
            this.signupBtn.Location = new System.Drawing.Point(59, 356);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(237, 33);
            this.signupBtn.TabIndex = 3;
            this.signupBtn.Text = "Sign Up";
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 506);
            this.Controls.Add(this.mainPanelSignup);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainPanelSignup.ResumeLayout(false);
            this.mainPanelSignup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel mainPanelSignup;
        private Guna.UI2.WinForms.Guna2Button signupBtn;
        private System.Windows.Forms.LinkLabel signupLoginLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}