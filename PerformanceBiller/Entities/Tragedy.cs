using Newtonsoft.Json.Linq;
using PerformanceBiller.Entities.Abstractions;
using System;

namespace PerformanceBiller.Entities
{
    public class Tragedy : PlayGenre
    {
        protected override int Amount => 40000;
        protected override int AudienceThreshold => 30;

        public Tragedy(string type) : base(type)
        {
        }

        public override int CalculateAmount(Performance performance)
        {
            var calculatedAmount = Amount;

            if (performance.Audience > AudienceThreshold)
                calculatedAmount += 1000 * (performance.Audience - 30);
            
            return calculatedAmount;
        }
    }
}
