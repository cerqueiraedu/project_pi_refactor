using PerformanceBiller.DTOs;
using System.Collections.Generic;

namespace PerformanceBiller.Repositories.Abstractions
{
    public interface IPlayRepository
    {
        Dictionary<string, Play> Get();
    }
}