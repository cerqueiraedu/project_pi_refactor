using System.Collections.Generic;

namespace PerformanceBiller.Infra.DTO
{
    public class Invoice
    {
        public string Customer { get; }
        public IList<Performance> Performances { get; }

        public Invoice(string customer)
        {
            Customer = customer;
            Performances = new List<Performance>();
        }
    }
}
