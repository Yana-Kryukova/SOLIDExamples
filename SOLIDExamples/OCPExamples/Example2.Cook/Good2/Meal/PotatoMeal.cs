using OCPExamples.Example2.Cook.Good2.Base;

namespace OCPExamples.Example2.Cook.Good2.Meal
{
    class PotatoMeal : MealBase
    {
        protected override void Cook()
        {
            Console.WriteLine("Ставим почищенную картошку на огонь");
            Console.WriteLine("Варим около 30 минут");
            Console.WriteLine("Сливаем остатки воды, разминаем варенный картофель в пюре");
        }

        protected override void FinalSteps()
        {
            Console.WriteLine("Посыпаем пюре специями и зеленью");
            Console.WriteLine("Картофельное пюре готово");
        }

        protected override void Prepare()
        {
            Console.WriteLine("Чистим и моем картошку");
        }
    }
}
