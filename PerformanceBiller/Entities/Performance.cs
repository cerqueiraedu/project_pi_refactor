using PerformanceBiller.Entities.Abstractions;
using System.Collections.Generic;

namespace PerformanceBiller.Entities
{
    public class Performance
    {
        public int PlayId { get; }
        public int Audience { get; }

        private readonly IPlayGenre Play;

        public Performance(IPlayGenre play, int audience)
        {
            Play = play;
            Audience = audience;
        }

        public int CalculatePlayCost()
        {
            return Play.Calculate(Audience);
        }
    }
}
