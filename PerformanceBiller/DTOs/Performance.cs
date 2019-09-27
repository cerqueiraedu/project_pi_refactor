using PerformanceBiller.Entities.Abstractions;
using System.Collections.Generic;

namespace PerformanceBiller.DTOs
{
    public class Performance
    {
        public string PlayId { get; private set; }
        public int Audience { get; private set; }
        public Performance(int audience)
        {
            Audience = audience;
        }
    }
}
