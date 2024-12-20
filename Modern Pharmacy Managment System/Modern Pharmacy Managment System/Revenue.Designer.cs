
namespace Modern_Pharmacy_Managment_System
{
    partial class Revenue
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ExpenseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.UseBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Calender2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Calender1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.LastYearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Today = new Guna.UI2.WinForms.Guna2Button();
            this.Last30Btn = new Guna.UI2.WinForms.Guna2Button();
            this.Last7Btn = new Guna.UI2.WinForms.Guna2Button();
            this.ProfitChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OnlineOfflineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfitChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OnlineOfflineChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ExpenseChart
            // 
            this.ExpenseChart.BackColor = System.Drawing.Color.Black;
            this.ExpenseChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.BlueViolet;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.MediumPurple;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.BlueViolet;
            chartArea1.AxisY.LabelStyle.Format = "${0}";
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorTickMark.LineWidth = 0;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Aqua;
            this.ExpenseChart.ChartAreas.Add(chartArea1);
            this.ExpenseChart.Location = new System.Drawing.Point(4, 74);
            this.ExpenseChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExpenseChart.Name = "ExpenseChart";
            this.ExpenseChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.BackSecondaryColor = System.Drawing.Color.Orchid;
            series1.BorderColor = System.Drawing.Color.Magenta;
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.DarkSlateBlue;
            series1.MarkerColor = System.Drawing.Color.Cyan;
            series1.MarkerSize = 2;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Expense";
            series1.ShadowColor = System.Drawing.Color.LightGreen;
            series1.YValuesPerPoint = 2;
            this.ExpenseChart.Series.Add(series1);
            this.ExpenseChart.Size = new System.Drawing.Size(679, 313);
            this.ExpenseChart.TabIndex = 34;
            this.ExpenseChart.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.BackColor = System.Drawing.Color.Black;
            title1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.SaddleBrown;
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.Red;
            title1.Text = "Total Expense";
            this.ExpenseChart.Titles.Add(title1);
            // 
            // UseBtn
            // 
            this.UseBtn.BorderRadius = 8;
            this.UseBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UseBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UseBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UseBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UseBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.UseBtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.UseBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UseBtn.ForeColor = System.Drawing.Color.White;
            this.UseBtn.Location = new System.Drawing.Point(440, 12);
            this.UseBtn.Name = "UseBtn";
            this.UseBtn.Size = new System.Drawing.Size(84, 36);
            this.UseBtn.TabIndex = 59;
            this.UseBtn.Text = "Use";
            this.UseBtn.Click += new System.EventHandler(this.UseBtn_Click);
            // 
            // Calender2
            // 
            this.Calender2.BorderRadius = 8;
            this.Calender2.Checked = true;
            this.Calender2.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.Calender2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Calender2.ForeColor = System.Drawing.Color.White;
            this.Calender2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Calender2.Location = new System.Drawing.Point(222, 12);
            this.Calender2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Calender2.MinDate = new System.DateTime(2023, 11, 27, 0, 0, 0, 0);
            this.Calender2.Name = "Calender2";
            this.Calender2.Size = new System.Drawing.Size(186, 36);
            this.Calender2.TabIndex = 58;
            this.Calender2.Value = new System.DateTime(2024, 4, 5, 17, 31, 20, 106);
            // 
            // Calender1
            // 
            this.Calender1.BorderRadius = 8;
            this.Calender1.Checked = true;
            this.Calender1.FillColor = System.Drawing.Color.RoyalBlue;
            this.Calender1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Calender1.ForeColor = System.Drawing.Color.White;
            this.Calender1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Calender1.Location = new System.Drawing.Point(7, 12);
            this.Calender1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Calender1.MinDate = new System.DateTime(2023, 10, 30, 0, 0, 0, 0);
            this.Calender1.Name = "Calender1";
            this.Calender1.Size = new System.Drawing.Size(185, 36);
            this.Calender1.TabIndex = 57;
            this.Calender1.Value = new System.DateTime(2024, 4, 5, 17, 31, 20, 106);
            // 
            // LastYearBtn
            // 
            this.LastYearBtn.Animated = true;
            this.LastYearBtn.BackColor = System.Drawing.Color.Transparent;
            this.LastYearBtn.BorderRadius = 10;
            this.LastYearBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.LastYearBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.LastYearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LastYearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LastYearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LastYearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LastYearBtn.FillColor = System.Drawing.Color.Navy;
            this.LastYearBtn.FocusedColor = System.Drawing.Color.Red;
            this.LastYearBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastYearBtn.ForeColor = System.Drawing.Color.White;
            this.LastYearBtn.Location = new System.Drawing.Point(1131, 14);
            this.LastYearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastYearBtn.Name = "LastYearBtn";
            this.LastYearBtn.Size = new System.Drawing.Size(190, 34);
            this.LastYearBtn.TabIndex = 53;
            this.LastYearBtn.Text = "Last Year";
            this.LastYearBtn.Click += new System.EventHandler(this.LastYearBtn_Click);
            // 
            // Today
            // 
            this.Today.Animated = true;
            this.Today.BorderRadius = 10;
            this.Today.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Today.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.Today.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Today.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Today.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Today.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Today.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Today.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.Today.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Today.ForeColor = System.Drawing.Color.White;
            this.Today.Location = new System.Drawing.Point(644, 14);
            this.Today.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Today.Name = "Today";
            this.Today.Size = new System.Drawing.Size(122, 34);
            this.Today.TabIndex = 55;
            this.Today.Text = "Today";
            this.Today.Click += new System.EventHandler(this.Today_Click);
            // 
            // Last30Btn
            // 
            this.Last30Btn.Animated = true;
            this.Last30Btn.BorderRadius = 10;
            this.Last30Btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Last30Btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.Last30Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Last30Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Last30Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Last30Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Last30Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Last30Btn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.Last30Btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last30Btn.ForeColor = System.Drawing.Color.White;
            this.Last30Btn.Location = new System.Drawing.Point(940, 14);
            this.Last30Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Last30Btn.Name = "Last30Btn";
            this.Last30Btn.Size = new System.Drawing.Size(185, 34);
            this.Last30Btn.TabIndex = 54;
            this.Last30Btn.Text = "Last 30 days";
            this.Last30Btn.Click += new System.EventHandler(this.Last30Btn_Click);
            // 
            // Last7Btn
            // 
            this.Last7Btn.Animated = true;
            this.Last7Btn.BorderRadius = 10;
            this.Last7Btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Last7Btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.Last7Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Last7Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Last7Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Last7Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Last7Btn.FillColor = System.Drawing.Color.Blue;
            this.Last7Btn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.Last7Btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last7Btn.ForeColor = System.Drawing.Color.White;
            this.Last7Btn.Location = new System.Drawing.Point(772, 14);
            this.Last7Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Last7Btn.Name = "Last7Btn";
            this.Last7Btn.Size = new System.Drawing.Size(162, 34);
            this.Last7Btn.TabIndex = 56;
            this.Last7Btn.Text = "Last 7 days";
            this.Last7Btn.Click += new System.EventHandler(this.Last7Btn_Click);
            // 
            // ProfitChart
            // 
            this.ProfitChart.BackColor = System.Drawing.Color.MediumPurple;
            this.ProfitChart.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.BackSecondaryColor = System.Drawing.Color.DimGray;
            chartArea2.Name = "ChartArea1";
            this.ProfitChart.ChartAreas.Add(chartArea2);
            this.ProfitChart.Location = new System.Drawing.Point(4, 404);
            this.ProfitChart.Name = "ProfitChart";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series2.BackSecondaryColor = System.Drawing.Color.Black;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Aqua;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelBackColor = System.Drawing.Color.Red;
            series2.LabelBorderColor = System.Drawing.Color.Red;
            series2.LabelForeColor = System.Drawing.Color.WhiteSmoke;
            series2.Legend = "Legend1";
            series2.Name = "Profit";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.ProfitChart.Series.Add(series2);
            this.ProfitChart.Size = new System.Drawing.Size(1317, 403);
            this.ProfitChart.TabIndex = 60;
            this.ProfitChart.Text = "chart1";
            title2.BackColor = System.Drawing.Color.Transparent;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title2.ForeColor = System.Drawing.Color.DarkRed;
            title2.Name = "Total Orders";
            title2.Text = "Total Orders";
            this.ProfitChart.Titles.Add(title2);
            // 
            // OnlineOfflineChart
            // 
            this.OnlineOfflineChart.BackColor = System.Drawing.Color.Black;
            chartArea3.BackColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.OnlineOfflineChart.ChartAreas.Add(chartArea3);
            legend1.Name = "Legend1";
            this.OnlineOfflineChart.Legends.Add(legend1);
            this.OnlineOfflineChart.Location = new System.Drawing.Point(712, 74);
            this.OnlineOfflineChart.Name = "OnlineOfflineChart";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series3.BackSecondaryColor = System.Drawing.Color.Red;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "OnlineOffline";
            this.OnlineOfflineChart.Series.Add(series3);
            this.OnlineOfflineChart.Size = new System.Drawing.Size(611, 313);
            this.OnlineOfflineChart.TabIndex = 61;
            this.OnlineOfflineChart.Text = "chart1";
            title3.BackColor = System.Drawing.Color.Magenta;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title3.Name = "Title1";
            title3.Text = "Online vs Offline Orders";
            this.OnlineOfflineChart.Titles.Add(title3);
            // 
            // Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1335, 766);
            this.Controls.Add(this.OnlineOfflineChart);
            this.Controls.Add(this.ProfitChart);
            this.Controls.Add(this.UseBtn);
            this.Controls.Add(this.Calender2);
            this.Controls.Add(this.Calender1);
            this.Controls.Add(this.LastYearBtn);
            this.Controls.Add(this.Today);
            this.Controls.Add(this.Last30Btn);
            this.Controls.Add(this.Last7Btn);
            this.Controls.Add(this.ExpenseChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Revenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revenue";
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfitChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OnlineOfflineChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ExpenseChart;
        private Guna.UI2.WinForms.Guna2Button UseBtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker Calender2;
        private Guna.UI2.WinForms.Guna2DateTimePicker Calender1;
        private Guna.UI2.WinForms.Guna2Button LastYearBtn;
        private Guna.UI2.WinForms.Guna2Button Today;
        private Guna.UI2.WinForms.Guna2Button Last30Btn;
        private Guna.UI2.WinForms.Guna2Button Last7Btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart ProfitChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart OnlineOfflineChart;
    }
}