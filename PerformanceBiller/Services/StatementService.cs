using PerformanceBiller.Entities;
using PerformanceBiller.Entities.Abstractions;
using PerformanceBiller.Repositories.Abstractions;

namespace PerformanceBiller.Services
{
    public class StatementService
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public StatementService(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public void GetStatement()
        {
            var invoices = _invoiceRepository.Get();
        }
    }
}