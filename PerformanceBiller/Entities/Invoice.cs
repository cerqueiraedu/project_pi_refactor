using System.Collections.Generic;
using System.Linq;

namespace PerformanceBiller.Entities
{
    public class Invoice
    {
        public Customer Customer { get; }
        public int CalculatedAmount { get; private set; }
        public int VolumeCredits { get; private set; }
        public IList<Performance> Performances { get; }

        public Invoice(Customer customer)
        {
            Customer = customer;
            Performances = new List<Performance>();
        }

        public void AddPerformance(Performance performance)
        {
            Performances.Add(performance);
        }

        public Invoice CalculateAmount()
        {
            CalculatedAmount = Performances.Sum(p => p.Calculate());
            return this;
        }
        public Invoice CalculateVolumeCredits()
        {
            VolumeCredits = Performances.Sum(p => p.CalculateVolumeCredits());
            return this;
        }
    }
}
