using SLRExamples.Example2.Order.Base;

namespace SLRExamples.Example2.Order.Good
{
    internal class Order
    {
        public Guid ID { get; private set; }
        public decimal Total { get; private set; }
        public List<Item> Items { get; private set; }
        public User User { get; private set; }

        /* 
         * Methods which changes the properties value
         */
    }
}
