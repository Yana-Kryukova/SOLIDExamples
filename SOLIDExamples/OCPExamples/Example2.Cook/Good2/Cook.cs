using OCPExamples.Example2.Cook.Good2.Base;

namespace OCPExamples.Example2.Cook.Good2
{
    class Cook
    {
        public string Name { get; set; }

        public Cook(string name)
        {
            this.Name = name;
        }

        public void MakeDinner(MealBase[] menu)
        {
            foreach (MealBase meal in menu)
                meal.Make();
        }
    }
}
