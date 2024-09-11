using LSPExamples.Example1.Figures.Bad;

namespace LSPExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Square();
            TestRectangleArea(rect);

            Console.Read();
        }

        // Производный класс, который может делать меньше, чем базовый,
        // обычно нельзя подставить вместо базового, и поэтому он нарушает принцип подстановки Лисков.
        public static void TestRectangleArea(Rectangle rect)
        {
            rect.Height = 5;
            rect.Width = 10;
            if (rect.GetArea() != 50)
                throw new Exception("Некорректная площадь!");
        }

        //public static void TestRectangleArea(Rectangle rect)
        //{
        //    if (rect is Square)
        //    {
        //        rect.Height = 5;
        //        if (rect.GetArea() != 25)
        //            throw new Exception("Неправильная площадь!");
        //    }
        //    else if (rect is Rectangle)
        //    {
        //        rect.Height = 5;
        //        rect.Width = 10;
        //        if (rect.GetArea() != 50)
        //            throw new Exception("Неправильная площадь!");
        //    }
        //}
    }
}
