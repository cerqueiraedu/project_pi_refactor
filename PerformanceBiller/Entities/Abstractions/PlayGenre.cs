using System;
using System.Collections.Generic;
using System.Text;

namespace PerformanceBiller.Entities.Abstractions
{
    public interface IPlayGenre
    {
        int Calculate(int audience);
    }
}
