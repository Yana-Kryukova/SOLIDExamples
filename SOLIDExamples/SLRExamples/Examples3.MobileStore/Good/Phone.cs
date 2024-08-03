
namespace SLRExamples.Examples2.MobileStore.Good
{
    internal class Phone
    {
        public string Model { get; }
        public int Price { get; }
        public Phone(string model, int price)
        {
            Model = model;
            Price = price;
        }
    }
}
