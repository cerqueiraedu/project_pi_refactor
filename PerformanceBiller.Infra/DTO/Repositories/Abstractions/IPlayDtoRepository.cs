using System.Collections.Generic;

namespace PerformanceBiller.Infra.DTO.Repositories.Abstractions
{
    public interface IPlayDtoRepository
    {
        Dictionary<string, Play> Get();
    }
}