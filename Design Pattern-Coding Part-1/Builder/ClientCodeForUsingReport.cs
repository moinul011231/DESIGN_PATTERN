using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Coding_Part_1.Builder
{
    public static class ClientCodeForUsingReport
    {
        public static void UseBuilderCode()
        {
            Console.WriteLine("Creating PDF...");
            PDFReport pdfReport = new PDFReport();
            ReportDirector reportDirector = new ReportDirector();
            Report report = reportDirector.MakeReport(pdfReport);
            report.DisplayReport();

            Console.WriteLine("\n---------------------------------------\n");
            Console.WriteLine("Creating Excel...");
            ExcleReport excelReport = new ExcleReport();
            report = reportDirector.MakeReport(excelReport);
            report.DisplayReport();

        }
    }
}
