﻿namespace PerformanceBiller.Infra.DTO
{
    public class Performance
    {
        public string PlayId { get; }
        public int Audience { get; }

        public Performance(string playId, int audience)
        {
            PlayId = playId;
            Audience = audience;
        }
    }
}
