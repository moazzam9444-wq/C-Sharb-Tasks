using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    sealed class SchoolReport  // Another Class Cannot Inherits from this class because its sealed class only we can make object on it 
    {
        public string ReportTitle{ get; set; }

        public SchoolReport(string reportTitle)
        {
            ReportTitle = reportTitle;
        }


        public void DisplayReportTitle()
        {
            Console.WriteLine("Report Title: "+ReportTitle);

        }
    }
}
