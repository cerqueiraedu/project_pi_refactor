using Newtonsoft.Json.Linq;
using PerformanceBiller.Entities.Abstractions;
using System;

namespace PerformanceBiller.Entities
{
    public class Comedy : IPlayGenre
    {
        public int Calculate(int audience)
        {
            var thisAmount = 30000;
            if (audience > 20)
            {
                thisAmount += 10000 + 500 * (audience - 20);
            }
            thisAmount += 300 * audience;

            return thisAmount;
        }
    }
}
