namespace PerformanceBiller.Entities
{
    public class Customer
    {
        public string Name { get; }
        public Customer(string name)
        {
            Name = name;
        }
    }
}