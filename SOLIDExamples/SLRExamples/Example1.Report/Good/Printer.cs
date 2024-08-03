
namespace SLRExamples.Example1.Report.Good
{
    /// <summary>
    /// Класс печати отчета
    /// </summary>
    internal class Printer
    {
        public void PrintReport(Report report)
        {
            Console.WriteLine("Печать отчета");
            Console.WriteLine(report.Text);
        }
    }
    #region Комментарии
    // Теперь печать вынесена в отдельный класс Printer,
    // который через метод Print получает объект отчета и выводит его текст на консоль.
    #endregion

}
