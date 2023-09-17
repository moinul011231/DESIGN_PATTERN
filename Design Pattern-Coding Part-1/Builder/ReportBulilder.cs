using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Coding_Part_1.Builder
{
    public abstract class ReportBuilder
    {
        protected Report reportObject;

        public abstract void SetReportType();

        public abstract void SetReportHeader();

        public abstract void SetReportContent();

        public abstract void SetReportFooter();

        public void CreateNewReport()
        {
            reportObject = new Report();
        }

        public Report GetReport()
        {
            return reportObject;
        }
    }
}
