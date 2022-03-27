namespace Simulation7
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ClientsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ClientsLabel = new System.Windows.Forms.Label();
            this.ClientsNumeric = new System.Windows.Forms.NumericUpDown();
            this.RunButton = new System.Windows.Forms.Button();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.MoneyNumeric = new System.Windows.Forms.NumericUpDown();
            this.MoneyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyChart)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ClientsChart);
            this.MainPanel.Controls.Add(this.ClientsLabel);
            this.MainPanel.Controls.Add(this.ClientsNumeric);
            this.MainPanel.Controls.Add(this.RunButton);
            this.MainPanel.Controls.Add(this.MoneyLabel);
            this.MainPanel.Controls.Add(this.MoneyNumeric);
            this.MainPanel.Controls.Add(this.MoneyChart);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1004, 750);
            this.MainPanel.TabIndex = 0;
            // 
            // ClientsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ClientsChart.ChartAreas.Add(chartArea1);
            this.ClientsChart.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.ClientsChart.Legends.Add(legend1);
            this.ClientsChart.Location = new System.Drawing.Point(0, 110);
            this.ClientsChart.Name = "ClientsChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Clients";
            series1.YValuesPerPoint = 2;
            this.ClientsChart.Series.Add(series1);
            this.ClientsChart.Size = new System.Drawing.Size(1004, 320);
            this.ClientsChart.TabIndex = 6;
            this.ClientsChart.Text = "chart1";
            // 
            // ClientsLabel
            // 
            this.ClientsLabel.AutoSize = true;
            this.ClientsLabel.Location = new System.Drawing.Point(191, 19);
            this.ClientsLabel.Name = "ClientsLabel";
            this.ClientsLabel.Size = new System.Drawing.Size(38, 13);
            this.ClientsLabel.TabIndex = 5;
            this.ClientsLabel.Text = "Clients";
            // 
            // ClientsNumeric
            // 
            this.ClientsNumeric.Location = new System.Drawing.Point(191, 38);
            this.ClientsNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ClientsNumeric.Name = "ClientsNumeric";
            this.ClientsNumeric.Size = new System.Drawing.Size(120, 20);
            this.ClientsNumeric.TabIndex = 4;
            this.ClientsNumeric.Value = new decimal(new int[] {
            170,
            0,
            0,
            0});
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(861, 21);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(118, 50);
            this.RunButton.TabIndex = 3;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.Location = new System.Drawing.Point(27, 19);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(39, 13);
            this.MoneyLabel.TabIndex = 2;
            this.MoneyLabel.Text = "Money";
            // 
            // MoneyNumeric
            // 
            this.MoneyNumeric.Location = new System.Drawing.Point(27, 38);
            this.MoneyNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MoneyNumeric.Name = "MoneyNumeric";
            this.MoneyNumeric.Size = new System.Drawing.Size(120, 20);
            this.MoneyNumeric.TabIndex = 1;
            this.MoneyNumeric.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // MoneyChart
            // 
            chartArea2.Name = "ChartArea1";
            this.MoneyChart.ChartAreas.Add(chartArea2);
            this.MoneyChart.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend2.Name = "Legend1";
            this.MoneyChart.Legends.Add(legend2);
            this.MoneyChart.Location = new System.Drawing.Point(0, 430);
            this.MoneyChart.Name = "MoneyChart";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Money";
            this.MoneyChart.Series.Add(series2);
            this.MoneyChart.Size = new System.Drawing.Size(1004, 320);
            this.MoneyChart.TabIndex = 0;
            this.MoneyChart.Text = "chart1";
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 1000;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 750);
            this.Controls.Add(this.MainPanel);
            this.Name = "Form1";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart MoneyChart;
        private System.Windows.Forms.NumericUpDown MoneyNumeric;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.Label ClientsLabel;
        private System.Windows.Forms.NumericUpDown ClientsNumeric;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart ClientsChart;
    }
}

