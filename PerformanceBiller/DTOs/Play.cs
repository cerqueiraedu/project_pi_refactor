using PerformanceBiller.Entities.Abstractions;
using System.Collections.Generic;

namespace PerformanceBiller.DTOs
{
    public class Play
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        
        public Play(string name, string type)
        {
           Name = name;
           Type = type;
        }
    }
}