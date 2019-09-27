using System.Collections.Generic;
using PerformanceBiller.Infra.DTO.Repositories.Abstractions;

namespace PerformanceBiller.Infra.DTO.Repositories
{
    public class InvoiceDtoRepository : JsonRepository<IEnumerable<Invoice>>, IInvoiceDtoRepository
    {
        private const string FileName = "invoices.json";

        public InvoiceDtoRepository(string basePath) : base(basePath, FileName)
        {
         
        }
        
        public IEnumerable<Invoice> Get()
        {
            return Entity;
        }
    }
}