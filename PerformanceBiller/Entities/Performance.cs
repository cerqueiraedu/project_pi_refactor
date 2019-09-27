using PerformanceBiller.Entities.Abstractions;

namespace PerformanceBiller.Entities
{
    public class Performance
    {
        public string Name { get; }
        public int Audience { get; }

        public PlayGenre Play { get; }

        public Performance(PlayGenre play, int audience, string name)
        {
            Play = play;
            Audience = audience;
            Name = name;
        }

        public int Calculate() => Play.CalculateAmount(this);

        public int CalculateVolumeCredits() => Play.CalculateVolumeCredits(this);
    }
}
