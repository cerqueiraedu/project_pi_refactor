using PerformanceBiller.Entities;
using PerformanceBiller.Repositories.Abstractions;
using System.IO;
using System.Collections.Generic;

namespace PerformanceBiller.Repositories
{
    public class InvoiceRepository : PerformanceBillerRepository<IEnumerable<Invoice>>, IInvoiceRepository
    {
        const string fileName = "invoices.json";
        public InvoiceRepository(string basePath) : base(basePath, fileName)
        {
         
        }
        
        public IEnumerable<Invoice> Get()
        {
            return Entity;
        }
    }
}