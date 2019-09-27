using Newtonsoft.Json.Linq;
using PerformanceBiller.Entities.Abstractions;
using System;
using System.Collections.Generic;

namespace PerformanceBiller.Entities
{
    public class Invoice
    {
        public Customer Customer { get; private set; }
        public IList<Performance> Performances { get; private set; }

        public Invoice()
        {
            Performances = new List<Performance>();
        }

        public void AddPerformance(Performance performance)
        {
            Performances.Add(performance);
        }
    }
}
