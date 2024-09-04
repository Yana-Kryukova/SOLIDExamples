using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPExamples.Exercise.Bad
{
    using System;
    using System.Collections.Generic;

    // Enum to represent different report formats
    public enum ReportFormat
    {
        PDF,
        Excel,
        CSV
    }

    // Class responsible for generating reports
    public class ReportGenerator
    {
        public void GenerateReport(List<string> data, ReportFormat format)
        {
            switch (format)
            {
                case ReportFormat.PDF:
                    GeneratePDFReport(data);
                    break;
                case ReportFormat.Excel:
                    GenerateExcelReport(data);
                    break;
                case ReportFormat.CSV:
                    GenerateCSVReport(data);
                    break;
                default:
                    throw new ArgumentException("Invalid report format");
            }
        }

        private void GeneratePDFReport(List<string> data)
        {
            // Code to generate PDF report
            Console.WriteLine("Generating PDF report...");
        }

        private void GenerateExcelReport(List<string> data)
        {
            // Code to generate Excel report
            Console.WriteLine("Generating Excel report...");
        }

        private void GenerateCSVReport(List<string> data)
        {
            // Code to generate CSV report
            Console.WriteLine("Generating CSV report...");
        }
    }
}