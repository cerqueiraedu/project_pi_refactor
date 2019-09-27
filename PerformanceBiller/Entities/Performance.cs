using System;
using PerformanceBiller.Entities.Abstractions;
using System.Collections.Generic;

namespace PerformanceBiller.Entities
{
    public class Performance
    {
        public string Name { get; private set; }
        public int Audience { get; private set; }
        public int CalculatedAmount { get; private set; }
        public int VolumeCredits { get; private set; }

        public PlayGenre Play { get; private set; }

        public Performance(PlayGenre play, int audience, string name)
        {
            Play = play;
            Audience = audience;
            Name = name;
        }

        public int Calculate()
        {
            CalculatedAmount = Play.CalculateAmount(this);
            return CalculatedAmount;
        }

        public int CalculateVolumeCredits()
        {
            VolumeCredits = Play.CalculateVolumeCredits(this);
            return VolumeCredits;
        }
    }
}
