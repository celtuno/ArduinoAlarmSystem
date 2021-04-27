using ArduinoAlarmSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ArduinoAlarmSystem
{
    public partial class MenyAfterLogin : Form
    {
        string COMport;
        public MenyAfterLogin()
        {
            InitializeComponent();
        }

        private void btnSeAlarmhistorikk_Click(object sender, EventArgs e)
        {
            
            AlarmHistory frmSeAlarmHistorikk = new AlarmHistory();
            frmSeAlarmHistorikk.ShowDialog();
            
        }

        private void btnTempUtvikling_Click(object sender, EventArgs e)
        {
            
            TempHistory frmTempHistory = new TempHistory();
            frmTempHistory.ShowDialog();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            SubscriberPage frmSubscriberPage = new SubscriberPage();
            frmSubscriberPage.ShowDialog();
        }

        private void MenyEtterLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSettAlarmbegrensninger_Click(object sender, EventArgs e)
        {
            AlarmLimit frmSettAlarmGrenser = new AlarmLimit();
            frmSettAlarmGrenser.ShowDialog();
        }

        private void btnLoggUt_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
            
            
        }

        private void btnValues_Click(object sender, EventArgs e)
        {
            CurrentValues frmCurrentValues = new CurrentValues();
            frmCurrentValues.ShowDialog();
        }

        private void btnChangeUserSettings_Click(object sender, EventArgs e)
        {
            ChangeUserSettings changeUserSettings = new ChangeUserSettings();
            changeUserSettings.ShowDialog();
        }
    }
}
