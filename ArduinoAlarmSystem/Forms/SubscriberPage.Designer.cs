namespace ArduinoAlarmSystem
{
    partial class SubscriberPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubscriberPage));
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cboLowBat = new System.Windows.Forms.ComboBox();
            this.cboMotionAlert = new System.Windows.Forms.ComboBox();
            this.cboTempLow = new System.Windows.Forms.ComboBox();
            this.cboBatCharging = new System.Windows.Forms.ComboBox();
            this.cboEmailAlert = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWarnings = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnBackSubscriberPage = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboIsAdmin = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTempHigh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(105, 239);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(193, 20);
            this.txtEMail.TabIndex = 3;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(105, 289);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(193, 20);
            this.txtPhoneNum.TabIndex = 4;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(105, 186);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(193, 20);
            this.txtLName.TabIndex = 2;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(105, 135);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(193, 20);
            this.txtFName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(105, 82);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(193, 20);
            this.txtPassword.TabIndex = 0;
            // 
            // cboLowBat
            // 
            this.cboLowBat.FormattingEnabled = true;
            this.cboLowBat.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cboLowBat.Location = new System.Drawing.Point(518, 79);
            this.cboLowBat.Name = "cboLowBat";
            this.cboLowBat.Size = new System.Drawing.Size(193, 21);
            this.cboLowBat.TabIndex = 5;
            // 
            // cboMotionAlert
            // 
            this.cboMotionAlert.FormattingEnabled = true;
            this.cboMotionAlert.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cboMotionAlert.Location = new System.Drawing.Point(518, 286);
            this.cboMotionAlert.Name = "cboMotionAlert";
            this.cboMotionAlert.Size = new System.Drawing.Size(193, 21);
            this.cboMotionAlert.TabIndex = 9;
            // 
            // cboTempLow
            // 
            this.cboTempLow.FormattingEnabled = true;
            this.cboTempLow.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cboTempLow.Location = new System.Drawing.Point(518, 181);
            this.cboTempLow.Name = "cboTempLow";
            this.cboTempLow.Size = new System.Drawing.Size(193, 21);
            this.cboTempLow.TabIndex = 7;
            // 
            // cboBatCharging
            // 
            this.cboBatCharging.FormattingEnabled = true;
            this.cboBatCharging.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cboBatCharging.Location = new System.Drawing.Point(518, 128);
            this.cboBatCharging.Name = "cboBatCharging";
            this.cboBatCharging.Size = new System.Drawing.Size(193, 21);
            this.cboBatCharging.TabIndex = 6;
            // 
            // cboEmailAlert
            // 
            this.cboEmailAlert.FormattingEnabled = true;
            this.cboEmailAlert.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cboEmailAlert.Location = new System.Drawing.Point(518, 336);
            this.cboEmailAlert.Name = "cboEmailAlert";
            this.cboEmailAlert.Size = new System.Drawing.Size(193, 21);
            this.cboEmailAlert.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(660, 425);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 28);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(57, 140);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 16);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "Name";
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword2.Location = new System.Drawing.Point(41, 84);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(58, 16);
            this.lblPassword2.TabIndex = 25;
            this.lblPassword2.Text = "Password";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(41, 187);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 16);
            this.lblLastName.TabIndex = 26;
            this.lblLastName.Text = "LastName";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(12, 291);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(87, 16);
            this.lblPhone.TabIndex = 27;
            this.lblPhone.Text = "Phone number";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(57, 244);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 16);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Low battery ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Computer not charging";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(417, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Low temprature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Motion alarm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(449, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Email alert";
            // 
            // lblWarnings
            // 
            this.lblWarnings.AutoSize = true;
            this.lblWarnings.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarnings.Location = new System.Drawing.Point(416, 33);
            this.lblWarnings.Name = "lblWarnings";
            this.lblWarnings.Size = new System.Drawing.Size(96, 20);
            this.lblWarnings.TabIndex = 35;
            this.lblWarnings.Text = "Notifications";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(12, 33);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(126, 20);
            this.lblInfo.TabIndex = 36;
            this.lblInfo.Text = "User information";
            // 
            // btnBackSubscriberPage
            // 
            this.btnBackSubscriberPage.Location = new System.Drawing.Point(733, 449);
            this.btnBackSubscriberPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackSubscriberPage.Name = "btnBackSubscriberPage";
            this.btnBackSubscriberPage.Size = new System.Drawing.Size(56, 19);
            this.btnBackSubscriberPage.TabIndex = 13;
            this.btnBackSubscriberPage.Text = "Tilbake";
            this.btnBackSubscriberPage.UseVisualStyleBackColor = true;
            this.btnBackSubscriberPage.Click += new System.EventHandler(this.btnBackSubscriberPage_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Admin ?";
            // 
            // cboIsAdmin
            // 
            this.cboIsAdmin.FormattingEnabled = true;
            this.cboIsAdmin.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cboIsAdmin.Location = new System.Drawing.Point(518, 382);
            this.cboIsAdmin.Name = "cboIsAdmin";
            this.cboIsAdmin.Size = new System.Drawing.Size(193, 21);
            this.cboIsAdmin.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(417, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "High temprature";
            // 
            // cboTempHigh
            // 
            this.cboTempHigh.FormattingEnabled = true;
            this.cboTempHigh.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cboTempHigh.Location = new System.Drawing.Point(518, 231);
            this.cboTempHigh.Name = "cboTempHigh";
            this.cboTempHigh.Size = new System.Drawing.Size(193, 21);
            this.cboTempHigh.TabIndex = 8;
            // 
            // SubscriberPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArduinoAlarmSystem.Properties.Resources.COLOURBOX1687381;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboTempHigh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboIsAdmin);
            this.Controls.Add(this.btnBackSubscriberPage);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblWarnings);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblPassword2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtEMail);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cboLowBat);
            this.Controls.Add(this.cboMotionAlert);
            this.Controls.Add(this.cboTempLow);
            this.Controls.Add(this.cboBatCharging);
            this.Controls.Add(this.cboEmailAlert);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubscriberPage";
            this.Text = "SubscriberPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cboLowBat;
        private System.Windows.Forms.ComboBox cboMotionAlert;
        private System.Windows.Forms.ComboBox cboTempLow;
        private System.Windows.Forms.ComboBox cboBatCharging;
        private System.Windows.Forms.ComboBox cboEmailAlert;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWarnings;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnBackSubscriberPage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboIsAdmin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboTempHigh;
    }
}