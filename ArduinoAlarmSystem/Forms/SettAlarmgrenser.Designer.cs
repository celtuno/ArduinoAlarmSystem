namespace ArduinoAlarmSystem
{
    partial class AlarmLimit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmLimit));
            this.btnInsertNewLimits = new System.Windows.Forms.Button();
            this.txtBatPerc = new System.Windows.Forms.TextBox();
            this.txtTempLow = new System.Windows.Forms.TextBox();
            this.btnBackAlarmgrenser = new System.Windows.Forms.Button();
            this.txtTempHigh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMotion = new System.Windows.Forms.ComboBox();
            this.txtDelayIntervalAfterAlarm = new System.Windows.Forms.TextBox();
            this.txtReadInterval = new System.Windows.Forms.TextBox();
            this.txtTempErrorLimit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInsertNewLimits
            // 
            this.btnInsertNewLimits.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInsertNewLimits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsertNewLimits.Location = new System.Drawing.Point(437, 250);
            this.btnInsertNewLimits.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertNewLimits.Name = "btnInsertNewLimits";
            this.btnInsertNewLimits.Size = new System.Drawing.Size(83, 52);
            this.btnInsertNewLimits.TabIndex = 9;
            this.btnInsertNewLimits.Text = "Sett alarm limits";
            this.btnInsertNewLimits.UseVisualStyleBackColor = false;
            this.btnInsertNewLimits.Click += new System.EventHandler(this.btnInsertNewLimits_Click);
            // 
            // txtBatPerc
            // 
            this.txtBatPerc.Location = new System.Drawing.Point(42, 232);
            this.txtBatPerc.Margin = new System.Windows.Forms.Padding(2);
            this.txtBatPerc.Name = "txtBatPerc";
            this.txtBatPerc.Size = new System.Drawing.Size(132, 20);
            this.txtBatPerc.TabIndex = 2;
            // 
            // txtTempLow
            // 
            this.txtTempLow.Location = new System.Drawing.Point(39, 184);
            this.txtTempLow.Margin = new System.Windows.Forms.Padding(2);
            this.txtTempLow.Name = "txtTempLow";
            this.txtTempLow.Size = new System.Drawing.Size(135, 20);
            this.txtTempLow.TabIndex = 1;
            // 
            // btnBackAlarmgrenser
            // 
            this.btnBackAlarmgrenser.Location = new System.Drawing.Point(520, 327);
            this.btnBackAlarmgrenser.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackAlarmgrenser.Name = "btnBackAlarmgrenser";
            this.btnBackAlarmgrenser.Size = new System.Drawing.Size(56, 19);
            this.btnBackAlarmgrenser.TabIndex = 10;
            this.btnBackAlarmgrenser.Text = "Back";
            this.btnBackAlarmgrenser.UseVisualStyleBackColor = true;
            this.btnBackAlarmgrenser.Click += new System.EventHandler(this.btnBackAlarmgrenser_Click);
            // 
            // txtTempHigh
            // 
            this.txtTempHigh.Location = new System.Drawing.Point(39, 135);
            this.txtTempHigh.Margin = new System.Windows.Forms.Padding(2);
            this.txtTempHigh.Name = "txtTempHigh";
            this.txtTempHigh.Size = new System.Drawing.Size(135, 20);
            this.txtTempHigh.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Alarmgrense temperatur høy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Alarmlimit temperature Low";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Alarmlimit battery percent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Motion ON/OFF";
            // 
            // cboMotion
            // 
            this.cboMotion.FormattingEnabled = true;
            this.cboMotion.Items.AddRange(new object[] {
            "ON",
            "OFF"});
            this.cboMotion.Location = new System.Drawing.Point(45, 286);
            this.cboMotion.Name = "cboMotion";
            this.cboMotion.Size = new System.Drawing.Size(129, 21);
            this.cboMotion.TabIndex = 3;
            // 
            // txtDelayIntervalAfterAlarm
            // 
            this.txtDelayIntervalAfterAlarm.Location = new System.Drawing.Point(218, 232);
            this.txtDelayIntervalAfterAlarm.Name = "txtDelayIntervalAfterAlarm";
            this.txtDelayIntervalAfterAlarm.Size = new System.Drawing.Size(138, 20);
            this.txtDelayIntervalAfterAlarm.TabIndex = 6;
            // 
            // txtReadInterval
            // 
            this.txtReadInterval.Location = new System.Drawing.Point(218, 184);
            this.txtReadInterval.Name = "txtReadInterval";
            this.txtReadInterval.Size = new System.Drawing.Size(138, 20);
            this.txtReadInterval.TabIndex = 5;
            // 
            // txtTempErrorLimit
            // 
            this.txtTempErrorLimit.Location = new System.Drawing.Point(218, 135);
            this.txtTempErrorLimit.Name = "txtTempErrorLimit";
            this.txtTempErrorLimit.Size = new System.Drawing.Size(138, 20);
            this.txtTempErrorLimit.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Temperature error limit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Temperature read interval";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Delay interval for new alarm";
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.ItemHeight = 13;
            this.cboPorts.Location = new System.Drawing.Point(218, 286);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(129, 21);
            this.cboPorts.TabIndex = 8;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(219, 270);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(52, 13);
            this.lblPort.TabIndex = 18;
            this.lblPort.Text = "COM-port";
            // 
            // AlarmLimit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArduinoAlarmSystem.Properties.Resources.COLOURBOX1687381;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.cboPorts);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTempErrorLimit);
            this.Controls.Add(this.txtReadInterval);
            this.Controls.Add(this.txtDelayIntervalAfterAlarm);
            this.Controls.Add(this.cboMotion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTempHigh);
            this.Controls.Add(this.btnBackAlarmgrenser);
            this.Controls.Add(this.txtTempLow);
            this.Controls.Add(this.txtBatPerc);
            this.Controls.Add(this.btnInsertNewLimits);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AlarmLimit";
            this.Text = "SetAlarmLimits";
            this.Load += new System.EventHandler(this.AlarmLimit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertNewLimits;
        private System.Windows.Forms.TextBox txtBatPerc;
        private System.Windows.Forms.TextBox txtTempLow;
        private System.Windows.Forms.Button btnBackAlarmgrenser;
        private System.Windows.Forms.TextBox txtTempHigh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMotion;
        private System.Windows.Forms.TextBox txtDelayIntervalAfterAlarm;
        private System.Windows.Forms.TextBox txtReadInterval;
        private System.Windows.Forms.TextBox txtTempErrorLimit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.Label lblPort;
    }
}