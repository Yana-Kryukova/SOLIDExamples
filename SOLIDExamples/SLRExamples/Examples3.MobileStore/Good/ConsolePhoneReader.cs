using SLRExamples.Examples2.MobileStore.Good.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLRExamples.Examples2.MobileStore.Good
{
    internal class ConsolePhoneReader : IPhoneReader
    {
        public string?[] GetInputData()
        {
            Console.WriteLine("Введите модель:");
            string? model = Console.ReadLine();
            Console.WriteLine("Введите цену:");
            string? price = Console.ReadLine();
            return new string?[] { model, price };
        }
    }
}
