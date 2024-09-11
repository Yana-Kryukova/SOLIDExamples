using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPExamples.Example1.Worker.Good
{

    public interface IWorker
    {
        void Work();
    }

    public interface IBreakable
    {
        void TakeBreak();
    }

    public interface IClockable
    {
        void ClockIn();
        void ClockOut();
    }

    public class WorkerGood : IWorker, IBreakable, IClockable
    {
        public void Work()
        {
            Console.WriteLine("Working...");
        }

        public void TakeBreak()
        {
            Console.WriteLine("Taking a break...");
        }

        public void ClockIn()
        {
            Console.WriteLine("Clocking in...");
        }

        public void ClockOut()
        {
            Console.WriteLine("Clocking out...");
        }
    }

    public class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Working...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IWorker worker = new WorkerGood();
            IWorker robot = new Robot();

            worker.Work();
            if (worker is IBreakable breakableWorker)
            {
                breakableWorker.TakeBreak();
            }

            robot.Work();
        }
    }
}
