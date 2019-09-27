using PerformanceBiller.Entities.Abstractions;
using PerformanceBiller.DTOs;
using PerformanceBiller.Repositories.Abstractions;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PerformanceBiller.Repositories
{
    public class PlayRepository : PerformanceBillerRepository<Dictionary<string, Play>>, IPlayRepository
    {
        const string fileName = "plays.json";

        public PlayRepository(string basePath) : base(basePath, fileName) { }
        
        public Dictionary<string, Play> Get()
        {
            return Entity;
        }
    }
}