using System.Collections.Generic;
using PerformanceBiller.Infra.DTO.Repositories.Abstractions;

namespace PerformanceBiller.Infra.DTO.Repositories
{
    public class PlayDtoRepository : JsonRepository<Dictionary<string, Play>>, IPlayDtoRepository
    {
        private const string FileName = "plays.json";

        public PlayDtoRepository(string basePath) : base(basePath, FileName) { }
        
        public Dictionary<string, Play> Get()
        {
            return Entity;
        }
    }
}