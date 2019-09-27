﻿using PerformanceBiller.Entities.Abstractions;
using System.Collections.Generic;

namespace PerformanceBiller.Entities
{
    public class Performance
    {
        public int Audience { get; private set; }
        public PlayGenre Play { get; private set; }

        public Performance(PlayGenre play, int audience)
        {
            Play = play;
            Audience = audience;
        }
    }
}
