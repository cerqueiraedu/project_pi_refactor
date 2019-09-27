using System.Collections.Generic;
using PerformanceBiller.Entities;

namespace PerformanceBiller.Repositories.Abstractions
{
    public interface IInvoiceRepository
    {
        IEnumerable<Invoice> Get();
    }
}