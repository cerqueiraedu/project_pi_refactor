using Newtonsoft.Json.Linq;
using PerformanceBiller.Entities.Abstractions;
using System;

namespace PerformanceBiller.Entities
{
    public class Tragedy : IPlayGenre
    {
        public int Calculate(int audience)
        {
            var thisAmount = 40000;
            if (audience > 30)
            {
                thisAmount += 1000 * (audience - 30);
            }

            return thisAmount;
        }
    }
}
