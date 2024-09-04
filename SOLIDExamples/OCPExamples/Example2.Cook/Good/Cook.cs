using OCPExamples.Example2.Cook.Good.Interfaces;

namespace OCPExamples.Example2.Cook.Good
{
    public class Cook
    {
        public string Name { get; set; }

        public Cook(string name)
        {
            this.Name = name;
        }

        public void MakeDinner(IMeal meal)
        {
            meal.Make();
        }
    }
}
