using OCPExamples.Example2.Cook.Good;
using OCPExamples.Example2.Cook.Good.Meal;
using OCPExamples.Exercise.Bad;

namespace OCPExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cook bob = new Cook("Bob");
            bob.MakeDinner(new PotatoMeal());
            Console.WriteLine();
            bob.MakeDinner(new SaladMeal());
        }


        ReportGenerator reportGenerator = new ReportGenerator();

        List<string> data = new List<string> { "Data1", "Data2", "Data3" };

        // Generating reports for different output formats
        reportGenerator.GenerateReport(data, ReportFormat.PDF);
            reportGenerator.GenerateReport(data, ReportFormat.Excel);
            reportGenerator.GenerateReport(data, ReportFormat.CSV);
    }
}
