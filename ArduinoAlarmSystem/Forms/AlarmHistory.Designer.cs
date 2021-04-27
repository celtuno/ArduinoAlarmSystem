namespace ArduinoAlarmSystem
{
    partial class AlarmHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmHistory));
            this.btnBackAlarmhistorikk = new System.Windows.Forms.Button();
            this.btnMailPDF = new System.Windows.Forms.Button();
            this.dgvAlarmHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarmHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackAlarmhistorikk
            // 
            this.btnBackAlarmhistorikk.Location = new System.Drawing.Point(862, 504);
            this.btnBackAlarmhistorikk.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackAlarmhistorikk.Name = "btnBackAlarmhistorikk";
            this.btnBackAlarmhistorikk.Size = new System.Drawing.Size(56, 19);
            this.btnBackAlarmhistorikk.TabIndex = 0;
            this.btnBackAlarmhistorikk.Text = "Tilbake";
            this.btnBackAlarmhistorikk.UseVisualStyleBackColor = true;
            this.btnBackAlarmhistorikk.Click += new System.EventHandler(this.btnBackAlarmhistorikk_Click);
            // 
            // btnMailPDF
            // 
            this.btnMailPDF.Location = new System.Drawing.Point(12, 12);
            this.btnMailPDF.Name = "btnMailPDF";
            this.btnMailPDF.Size = new System.Drawing.Size(75, 23);
            this.btnMailPDF.TabIndex = 1;
            this.btnMailPDF.Text = "Email PDF ";
            this.btnMailPDF.UseVisualStyleBackColor = true;
            this.btnMailPDF.Click += new System.EventHandler(this.btnMailPDF_Click);
            // 
            // dgvAlarmHistory
            // 
            this.dgvAlarmHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlarmHistory.Location = new System.Drawing.Point(12, 41);
            this.dgvAlarmHistory.Name = "dgvAlarmHistory";
            this.dgvAlarmHistory.Size = new System.Drawing.Size(845, 481);
            this.dgvAlarmHistory.TabIndex = 2;
            this.dgvAlarmHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlarmHistory_CellContentClick);
            // 
            // AlarmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArduinoAlarmSystem.Properties.Resources.COLOURBOX1687381;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 534);
            this.Controls.Add(this.dgvAlarmHistory);
            this.Controls.Add(this.btnMailPDF);
            this.Controls.Add(this.btnBackAlarmhistorikk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AlarmHistory";
            this.Text = "AlarmHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarmHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackAlarmhistorikk;
        private System.Windows.Forms.Button btnMailPDF;
        private System.Windows.Forms.DataGridView dgvAlarmHistory;
    }
}