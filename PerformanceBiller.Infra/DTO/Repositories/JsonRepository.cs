using System.IO;
using Newtonsoft.Json;

namespace PerformanceBiller.Infra.DTO.Repositories
{
    public abstract class JsonRepository<T> where T : class
    {
        protected readonly string BasePath;
        protected T Entity { get; }

        protected JsonRepository(string basePath, string fileName)
        {
            BasePath = basePath;
            Entity = JsonConvert.DeserializeObject<T>(File.ReadAllText($"{BasePath}\\{fileName}"));
        }
    }
}