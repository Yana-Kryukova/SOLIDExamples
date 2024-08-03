using SLRExamples.Example2.Order.Base;

namespace SLRExamples.Example2.Order.Bad
{
    internal class Order
    {
        public Guid ID { get; private set; }
        public decimal Total { get; private set; }
        public List<Item> Items { get; private set; }
        public User User { get; private set; }
        public void Load() { /*…*/ }
        public void Save() { /*…*/ }
        public void Update() { /*…*/ }
        public void Remove() { /*…*/ }

        /* 
         * Methods that change the property values.
         */
    }

}
