using Newtonsoft.Json.Linq;
using PerformanceBiller.Entities.Abstractions;
using System;


namespace PerformanceBiller.Entities
{
    public class Comedy : PlayGenre
    {
        protected override int Amount => 30000;
        protected override int AudienceThreshold => 20;

        public Comedy(string type) : base(type)
        {
        }

        public override int CalculateAmount(Performance performance)
        {
            var calculatedAmount = Amount;

            if (performance.Audience > AudienceThreshold)
                calculatedAmount += 10000 + 500 * (performance.Audience - 20);

            calculatedAmount += 300 * performance.Audience;

            return calculatedAmount;
        }

        protected override int CalculateExtraVolumeCredits(Performance performance)
        {
            return performance.Audience / 5;
        }
    }
}
