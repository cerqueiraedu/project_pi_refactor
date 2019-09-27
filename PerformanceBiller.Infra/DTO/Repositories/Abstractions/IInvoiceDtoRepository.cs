using System.Collections.Generic;

namespace PerformanceBiller.Infra.DTO.Repositories.Abstractions
{
    public interface IInvoiceDtoRepository
    {
        IEnumerable<Invoice> Get();
    }
}