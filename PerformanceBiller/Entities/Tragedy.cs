using Newtonsoft.Json.Linq;
using PerformanceBiller.Entities.Abstractions;
using System;

namespace PerformanceBiller.Entities
{
    public class Tragedy : PlayGenre
    {
        protected override int Amount => 40000;
        public int CalculatedAmount { get; private set; }
        public override int Calculate(int audience)
        {
            if (audience > 30)
            {
                CalculatedAmount = (1000 * (audience - 30)) + Amount;
            }

            return CalculatedAmount;
        }
    }
}
