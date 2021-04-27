namespace ArduinoAlarmSystem.Forms
{
    partial class CurrentValues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentValues));
            this.txtCurrentTemp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrentBattery = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurrentMSensor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tmrBattery = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txtBatCharging = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCurrentTemp
            // 
            this.txtCurrentTemp.Location = new System.Drawing.Point(111, 27);
            this.txtCurrentTemp.Name = "txtCurrentTemp";
            this.txtCurrentTemp.ReadOnly = true;
            this.txtCurrentTemp.Size = new System.Drawing.Size(42, 20);
            this.txtCurrentTemp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temprature";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Battery %";
            // 
            // txtCurrentBattery
            // 
            this.txtCurrentBattery.Location = new System.Drawing.Point(111, 67);
            this.txtCurrentBattery.Name = "txtCurrentBattery";
            this.txtCurrentBattery.ReadOnly = true;
            this.txtCurrentBattery.Size = new System.Drawing.Size(42, 20);
            this.txtCurrentBattery.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Motion sensor";
            // 
            // txtCurrentMSensor
            // 
            this.txtCurrentMSensor.Location = new System.Drawing.Point(111, 156);
            this.txtCurrentMSensor.Name = "txtCurrentMSensor";
            this.txtCurrentMSensor.ReadOnly = true;
            this.txtCurrentMSensor.Size = new System.Drawing.Size(42, 20);
            this.txtCurrentMSensor.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(157, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "TRUE == Active alarm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(159, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "FALSE == Inactive alarm";
            // 
            // tmrBattery
            // 
            this.tmrBattery.Interval = 1500;
            this.tmrBattery.Tick += new System.EventHandler(this.tmrBattery_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Battery charging";
            // 
            // txtBatCharging
            // 
            this.txtBatCharging.Location = new System.Drawing.Point(111, 110);
            this.txtBatCharging.Name = "txtBatCharging";
            this.txtBatCharging.ReadOnly = true;
            this.txtBatCharging.Size = new System.Drawing.Size(42, 20);
            this.txtBatCharging.TabIndex = 8;
            // 
            // CurrentValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArduinoAlarmSystem.Properties.Resources.COLOURBOX2277756;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(421, 238);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBatCharging);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCurrentMSensor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCurrentBattery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCurrentTemp);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CurrentValues";
            this.Text = "CurrentValues";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CurrentValues_FormClosed);
            this.Load += new System.EventHandler(this.CurrentValues_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrentTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrentBattery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurrentMSensor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer tmrBattery;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBatCharging;
    }
}