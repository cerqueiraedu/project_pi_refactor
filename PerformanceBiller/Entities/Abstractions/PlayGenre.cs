using System;
using System.Collections.Generic;
using System.Text;

namespace PerformanceBiller.Entities.Abstractions
{
    public abstract class PlayGenre
    {
        protected abstract int Amount { get; }
        public abstract int Calculate(int audience);
    }
}
