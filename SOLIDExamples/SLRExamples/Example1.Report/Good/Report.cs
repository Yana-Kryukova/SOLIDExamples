
namespace SLRExamples.Example1.Report.Good
{
    /// <summary>
    /// Класс навигации по отчету
    /// </summary>
    internal class Report
    {
        public string Text { get; set; } = "";
        public void GoToFirstPage() =>
            Console.WriteLine("Переход к первой странице");

        public void GoToLastPage() =>
            Console.WriteLine("Переход к последней странице");

        public void GoToPage(int pageNumber) =>
            Console.WriteLine($"Переход к странице {pageNumber}");
    }
    #region Комментарии
    // Решение: вынести каждую обязанность в отдельный компонент(в данном случае в отдельный класс)
    #endregion
}
