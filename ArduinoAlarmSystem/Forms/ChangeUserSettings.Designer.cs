namespace ArduinoAlarmSystem.Forms
{
    partial class ChangeUserSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeUserSettings));
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.cboLowBat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboLowTemp = new System.Windows.Forms.ComboBox();
            this.cboBatCharging = new System.Windows.Forms.ComboBox();
            this.cboHighTemp = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboPir = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboAdmin = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboEmail = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboUserRoll = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLoadCurrentValues = new System.Windows.Forms.Button();
            this.btnComittChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(15, 180);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // cboLowBat
            // 
            this.cboLowBat.FormattingEnabled = true;
            this.cboLowBat.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cboLowBat.Location = new System.Drawing.Point(215, 179);
            this.cboLowBat.Name = "cboLowBat";
            this.cboLowBat.Size = new System.Drawing.Size(100, 21);
            this.cboLowBat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "LastName";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(15, 234);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 293);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PhoneNumber";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(15, 352);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(15, 410);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Low Temperature Alert";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Low Battery Alert";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Not Charging Alert";
            // 
            // cboLowTemp
            // 
            this.cboLowTemp.FormattingEnabled = true;
            this.cboLowTemp.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cboLowTemp.Location = new System.Drawing.Point(215, 292);
            this.cboLowTemp.Name = "cboLowTemp";
            this.cboLowTemp.Size = new System.Drawing.Size(100, 21);
            this.cboLowTemp.TabIndex = 17;
            // 
            // cboBatCharging
            // 
            this.cboBatCharging.FormattingEnabled = true;
            this.cboBatCharging.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cboBatCharging.Location = new System.Drawing.Point(215, 234);
            this.cboBatCharging.Name = "cboBatCharging";
            this.cboBatCharging.Size = new System.Drawing.Size(100, 21);
            this.cboBatCharging.TabIndex = 18;
            // 
            // cboHighTemp
            // 
            this.cboHighTemp.FormattingEnabled = true;
            this.cboHighTemp.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cboHighTemp.Location = new System.Drawing.Point(215, 352);
            this.cboHighTemp.Name = "cboHighTemp";
            this.cboHighTemp.Size = new System.Drawing.Size(100, 21);
            this.cboHighTemp.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(212, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "High Temperature Alert";
            // 
            // cboPir
            // 
            this.cboPir.FormattingEnabled = true;
            this.cboPir.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cboPir.Location = new System.Drawing.Point(215, 409);
            this.cboPir.Name = "cboPir";
            this.cboPir.Size = new System.Drawing.Size(100, 21);
            this.cboPir.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(212, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Motion Sensor Alert";
            // 
            // cboAdmin
            // 
            this.cboAdmin.FormattingEnabled = true;
            this.cboAdmin.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cboAdmin.Location = new System.Drawing.Point(420, 233);
            this.cboAdmin.Name = "cboAdmin";
            this.cboAdmin.Size = new System.Drawing.Size(100, 21);
            this.cboAdmin.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(417, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Is Admin";
            // 
            // cboEmail
            // 
            this.cboEmail.FormattingEnabled = true;
            this.cboEmail.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cboEmail.Location = new System.Drawing.Point(420, 179);
            this.cboEmail.Name = "cboEmail";
            this.cboEmail.Size = new System.Drawing.Size(100, 21);
            this.cboEmail.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(417, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "E-Mail Alert";
            // 
            // cboUserRoll
            // 
            this.cboUserRoll.FormattingEnabled = true;
            this.cboUserRoll.Location = new System.Drawing.Point(15, 24);
            this.cboUserRoll.Name = "cboUserRoll";
            this.cboUserRoll.Size = new System.Drawing.Size(100, 21);
            this.cboUserRoll.TabIndex = 30;
            this.cboUserRoll.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Select User To Change";
            // 
            // btnLoadCurrentValues
            // 
            this.btnLoadCurrentValues.Location = new System.Drawing.Point(26, 51);
            this.btnLoadCurrentValues.Name = "btnLoadCurrentValues";
            this.btnLoadCurrentValues.Size = new System.Drawing.Size(75, 23);
            this.btnLoadCurrentValues.TabIndex = 31;
            this.btnLoadCurrentValues.Text = "Load";
            this.btnLoadCurrentValues.UseVisualStyleBackColor = true;
            this.btnLoadCurrentValues.Click += new System.EventHandler(this.btnLoadCurrentValues_Click);
            // 
            // btnComittChanges
            // 
            this.btnComittChanges.Location = new System.Drawing.Point(670, 415);
            this.btnComittChanges.Name = "btnComittChanges";
            this.btnComittChanges.Size = new System.Drawing.Size(118, 23);
            this.btnComittChanges.TabIndex = 32;
            this.btnComittChanges.Text = "Committ changes";
            this.btnComittChanges.UseVisualStyleBackColor = true;
            this.btnComittChanges.Click += new System.EventHandler(this.btnComittChanges_Click);
            // 
            // ChangeUserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ArduinoAlarmSystem.Properties.Resources.COLOURBOX2277756;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComittChanges);
            this.Controls.Add(this.btnLoadCurrentValues);
            this.Controls.Add(this.cboUserRoll);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboEmail);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cboAdmin);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboPir);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboHighTemp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboBatCharging);
            this.Controls.Add(this.cboLowTemp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboLowBat);
            this.Controls.Add(this.txtFirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeUserSettings";
            this.Text = "ChangeUserSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox cboLowBat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboLowTemp;
        private System.Windows.Forms.ComboBox cboBatCharging;
        private System.Windows.Forms.ComboBox cboHighTemp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboPir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboAdmin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboUserRoll;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLoadCurrentValues;
        private System.Windows.Forms.Button btnComittChanges;
    }
}