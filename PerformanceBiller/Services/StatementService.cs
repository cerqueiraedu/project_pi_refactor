using PerformanceBiller.Entities;
using PerformanceBiller.Entities.Abstractions;
using PerformanceBiller.Repositories.Abstractions;


namespace PerformanceBiller.Services
{
    public class StatementService
    {
        private readonly IPlayRepository _playRepository;
        private readonly IInvoiceRepository _invoiceRepository;

        public StatementService(IPlayRepository playRepository, IInvoiceRepository invoiceRepository)
        {
            _playRepository = playRepository;
            _invoiceRepository = invoiceRepository;
        }

        public void GetStatement()
        {
            var plays = _playRepository.Get();
            var invoice = _invoiceRepository.Get();
        }
    }
}