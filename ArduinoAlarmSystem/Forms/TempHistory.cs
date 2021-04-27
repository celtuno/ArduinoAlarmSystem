using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//for sql
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace ArduinoAlarmSystem.Forms
{
    public partial class TempHistory : Form
    {
        //for sql intit
        string conTempChart = ConfigurationManager.ConnectionStrings["Alarm"].ConnectionString;

        public TempHistory()
        {
            InitializeComponent();
            //initialize graph
            InitGraph();
            
        }

        private void TempHistory_Load(object sender, EventArgs e)
        {
            
            

        }
        void InitGraph()
        {
            //chart settings

            //set up gridline colors
            chartTempAlarm.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            chartTempAlarm.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            //chartTempAlarm.ChartAreas[0].AxisX2.MajorGrid.LineColor = Color.Gray;
            //chartTempAlarm.ChartAreas[0].AxisY2.MajorGrid.LineColor = Color.Gray;
            
            //set up dates as tyle for x-axis 
            chartTempAlarm.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            //chartTempAlarm.ChartAreas[0].AxisX2.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartTempAlarm.ChartAreas[0].AxisY.Interval = 2.0;

            chartTempAlarm.Series["Temperature"].Color = Color.Green;
            //chartTempAlarm.Series["Alarm"].Color = Color.Red;

            
            //Read data from sql with this method  (run this in your own -method / button / chart display solution)
            GetDataFromSql();
        }

        private void GetDataFromSql()
        {

            //Set up start stop dates in chart (beginning / end values)
            DateTime StopDate = DateTime.Today;
            DateTime StartDate = StopDate.AddDays(-4);
           // DateTime StartDate = new DateTime(2019, 1, 1);
            chartTempAlarm.ChartAreas[0].AxisX.Minimum = StartDate.ToOADate();
            chartTempAlarm.ChartAreas[0].AxisX.Maximum = StopDate.ToOADate();

            //define variables
            double tempRead;
             DateTime tempDate;

            //Set up sql commands for query
            string sqlTempQuery = "Select * from Temperature";
            //string sqlAlarmQuery = "Select * from Alarms";

            //set up sql connection
            SqlConnection sqlCon = new SqlConnection(conTempChart);

            //initialize sql query command
            SqlCommand sqlTempRead = new SqlCommand(sqlTempQuery, sqlCon);
            //SqlCommand sqlAlarmRead = new SqlCommand(sqlAlarmQuery, sqlCon);

            //set up try catch for error handling
            try
            {

                //read temperatures form sql
                sqlCon.Open();
                //Initialize sqlreader
                SqlDataReader tempDataRow = sqlTempRead.ExecuteReader();

                //while data is available, read date and temperature 
                while (tempDataRow.Read() == true)
                {
                    //convert sqldata for chart
                    tempRead = Convert.ToDouble(tempDataRow[2]);
                    tempDate = Convert.ToDateTime(tempDataRow[1]);
                    
                    //Plot temperatur values into chart
                    chartTempAlarm.Series["Temperature"].Points.AddXY(tempDate, tempRead);
                    
                }
                sqlCon.Close();

                

            }
            catch (Exception sqlRead)
            {
                MessageBox.Show("SQL-Error:  " + sqlRead.Message.ToString(), "SQL_Read_Error");
            }
            
         }

        private void chartTempAlarm_Click(object sender, EventArgs e)
        {

        }
    }
}
