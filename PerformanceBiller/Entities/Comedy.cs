using Newtonsoft.Json.Linq;
using PerformanceBiller.Entities.Abstractions;
using System;


namespace PerformanceBiller.Entities
{
    public class Comedy : PlayGenre
    {
        protected override int Amount => 30000;
        public int CalculatedAmount { get; private set; }
        public override int Calculate(int audience)
        {
            if (audience > 20)
            {
                CalculatedAmount = (10000 + 500 * (audience - 20)) + Amount;
            }

            CalculatedAmount += 300 * audience;

            return CalculatedAmount;
        }
    }
}
