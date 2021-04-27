using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ArduinoAlarmSystem
{
    class PDF
    {
        public DataTable dataTable = new DataTable();



        public void  CreatePDF()

        {
           
            using (SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["Alarm"].ConnectionString)) // Sql connection
            {
                string sqlQuery = "Select * from Alarms";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn))
                {
                    SqlDataAdapter dr = new SqlDataAdapter(cmd);
                    dr.Fill(dataTable);
                }
            }

            foreach (DataRow dr in dataTable.Rows) //Finds all values 
            {
           
                int col1 = (int)dr[0]; //Values in AlarmId
                DateTime col2 = (DateTime)dr[1]; //Values in  DateAndTime
                int col3 = (int)dr[2];//Values in  ConfigId
                int col4 = (int)dr[3];//Values in  BatteryVoltage
                int col5 = (int)dr[4];//Values in  BatteryAlam
                string col6 = (string)dr[5];//Values in  MotionAlarm
                double col7 = (double)dr[6];//Values in  TempFloat
                string col8 = (string)dr[7];//Values in  AlarmDiscription

            }


            Document document = new Document(); //Creates new document 
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("D:\\PDF ALARMS.pdf", FileMode.Create)); //Where to store // This could fail because of store location
            document.Open();

            iTextSharp.text.Font textType1 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 20, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK); //Texttype
            Paragraph par1 = new Paragraph("Alarm values", textType1); //paragraph 1
            par1.Alignment = Element.ALIGN_CENTER; //location of text
            document.Add(par1);  //Add text to documetnt

            Paragraph par2 = new Paragraph("                                                                       ", textType1); //Space under headline
            document.Add(par2);
               

            PdfPTable table = new PdfPTable(dataTable.Columns.Count);
            table.WidthPercentage = 100;

            
            for (int k = 0; k < dataTable.Columns.Count; k++) //set column names and location of these
            {
                PdfPCell cell = new PdfPCell(new Phrase(dataTable.Columns[k].ColumnName));

                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER; //Cell placement
                cell.VerticalAlignment = PdfPCell.ALIGN_CENTER; //Cell placement
                cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 0, 0); //Set textcolor to red

                table.AddCell(cell); //Adds table to document
            }

           
            for (int i = 0; i < dataTable.Rows.Count; i++) //Adds value from dataTable into pdf document
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(dataTable.Rows[i][j].ToString()));

                   
                    cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT; //Value location in cells
                    cell.VerticalAlignment = PdfPCell.ALIGN_LEFT; //Value location in cells

                    table.AddCell(cell); //add value
                }
            }

            document.Add(table); //Add to document
            document.Close(); 
        }













































        //lage en egen metode for å skrive inn verdier

        //Document AlarmHistory = new Document(PageSize.A4, 20f, 20f, 30f, 30f);
        //    PdfWriter alarmPDF = PdfWriter.GetInstance(AlarmHistory, new FileStream("E:\\PDF ALARMS.pdf", FileMode.Create)); //Saving location
        //    AlarmHistory.Open();

        //    iTextSharp.text.Font textType1 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 20, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLUE); //Texttype
        //    Paragraph par1 = new Paragraph("Alarm values", textType1); //paragraph 1
        //    par1.Alignment = Element.ALIGN_CENTER;
        //    AlarmHistory.Add(par1);
        //    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //    iTextSharp.text.Font textType2 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 12, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK); //Texttype 2
        //    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            


        //    AlarmHistory.Close();
        //}


    }
}
