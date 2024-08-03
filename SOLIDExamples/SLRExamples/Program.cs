using SLRExamples.Examples2.MobileStore.Good;
using SLRExamples.Exercise.Bad;

namespace SLRExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MobileStore store = new MobileStore(
                new ConsolePhoneReader(), new GeneralPhoneBinder(),
                new GeneralPhoneValidator(), new TextPhoneSaver());
            store.Process();

            Employee employee = new Employee
            {
                EmployeeId = 1,
                Name = "John Doe",
                Position = "Software Developer"
                // Other employee data can be initialized here
            };

            DateTime startDate = DateTime.Today.AddDays(-7); // Example start date
            DateTime endDate = DateTime.Today; // Example end date

            // Calculate salary
            decimal salary = employee.CalculateSalary(startDate, endDate);

            Console.WriteLine($"Employee {employee.Name} earned ${salary}.");
        }
    }
}
