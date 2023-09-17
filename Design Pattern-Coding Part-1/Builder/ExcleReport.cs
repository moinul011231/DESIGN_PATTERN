using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Coding_Part_1.Builder
{
    public class ExcleReport: ReportBuilder
    {
        public override void SetReportContent() => reportObject.ReportContent = "Excle Content";

        public override void SetReportFooter() => reportObject.ReportFooter = "Excle Footer";

        public override void SetReportHeader() => reportObject.ReportHeader = "Excle Header";

        public override void SetReportType() => reportObject.ReportType = "Excle";
    }
}
