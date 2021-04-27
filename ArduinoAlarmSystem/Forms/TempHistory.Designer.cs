namespace ArduinoAlarmSystem.Forms
{
    partial class TempHistory
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TempHistory));
            this.chartTempAlarm = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTempAlarm)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTempAlarm
            // 
            this.chartTempAlarm.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.ToolTip = "Vsl";
            chartArea1.AxisX2.Interval = 1D;
            chartArea1.AxisX2.LabelStyle.Enabled = false;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Maroon;
            chartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY2.Interval = 1D;
            chartArea1.AxisY2.LabelStyle.Enabled = false;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Maroon;
            chartArea1.AxisY2.MajorTickMark.Enabled = false;
            chartArea1.AxisY2.Maximum = 1D;
            chartArea1.AxisY2.Minimum = 0D;
            chartArea1.Name = "ChartAreaTempAlarm";
            this.chartTempAlarm.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTempAlarm.Legends.Add(legend1);
            this.chartTempAlarm.Location = new System.Drawing.Point(61, 12);
            this.chartTempAlarm.Name = "chartTempAlarm";
            series1.ChartArea = "ChartAreaTempAlarm";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Temperature";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chartTempAlarm.Series.Add(series1);
            this.chartTempAlarm.Size = new System.Drawing.Size(690, 362);
            this.chartTempAlarm.TabIndex = 4;
            this.chartTempAlarm.Text = "Temperatures";
            this.chartTempAlarm.Click += new System.EventHandler(this.chartTempAlarm_Click);
            // 
            // TempHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArduinoAlarmSystem.Properties.Resources.COLOURBOX1687381;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartTempAlarm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TempHistory";
            this.Text = "TempHistory";
            this.Load += new System.EventHandler(this.TempHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTempAlarm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTempAlarm;
    }
}