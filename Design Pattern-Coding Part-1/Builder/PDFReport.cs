﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Coding_Part_1.Builder
{
    public class PDFReport : ReportBuilder
    {
        public override void SetReportContent() => reportObject.ReportContent = "PDF Content";
       
        public override void SetReportFooter() => reportObject.ReportFooter = "PDF Footer";

        public override void SetReportHeader() => reportObject.ReportHeader = "PDF Header";

        public override void SetReportType() => reportObject.ReportType = "PDF";
    }

}
