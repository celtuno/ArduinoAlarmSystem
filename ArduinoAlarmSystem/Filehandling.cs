using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbeidskrav_1___Gruppe_4
{
    class Filehandling
    {
        public string filename = Directory.GetCurrentDirectory() + "\\intervals";
        public double tempHigh, tempLow;
        public int intervals;

        public void Filereader(double tempHigh, double tempLow)
        {
            StreamWriter sw = new StreamWriter(filename);
        }

        public void Filewriter()
        {
            StreamReader sr = new StreamReader(filename);
        }
    }
}
