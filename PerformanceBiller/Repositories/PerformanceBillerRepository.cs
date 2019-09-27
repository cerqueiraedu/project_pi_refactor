using System.Collections.Generic;
using PerformanceBiller.Entities;
using PerformanceBiller.Repositories.Abstractions;
using System.IO;
using Newtonsoft.Json;

namespace PerformanceBiller.Repositories
{
    public abstract class PerformanceBillerRepository<T> where T : class
    {
        protected readonly string _basePath;
        protected T Entity { get; }

        public PerformanceBillerRepository(string basePath, string fileName)
        {
            _basePath = basePath;
            JsonConvert.DeserializeObject<T>(File.ReadAllText($"{_basePath}\\{fileName}"));
        }
    }
}