using System;
using System.Collections.Generic;
using System.Text;

namespace PerformanceBiller.Entities.Abstractions
{
    public abstract class PlayGenre
    {
        protected string Type { get; }
        protected abstract int Amount { get; }
        protected abstract int AudienceThreshold { get; }

        protected PlayGenre(string type)
        {
            Type = type;
        }

        public abstract int CalculateAmount(Performance performance);

        public virtual int CalculateVolumeCredits(Performance performance)
        {
            var volumeCredits = Math.Max(performance.Audience - 30, 0);
            volumeCredits += CalculateExtraVolumeCredits(performance);
            return volumeCredits;
        }

        protected virtual int CalculateExtraVolumeCredits(Performance performance) => 0;
    }
}
