using System.Collections.Generic;
using System.Linq;
using PerformanceBiller.Builder.Abstractions;
using PerformanceBiller.Entities;
using PerformanceBiller.Repositories.Abstractions;

namespace PerformanceBiller.Services
{
    public class StatementService
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IBuildStatement _statementBuilder;

        public StatementService(IInvoiceRepository invoiceRepository, IBuildStatement statementBuilder)
        {
            _invoiceRepository = invoiceRepository;
            _statementBuilder = statementBuilder;
        }

        public IEnumerable<Statement> GetStatements()
        {
            var invoices = _invoiceRepository.Get();
            return invoices.Select(i => _statementBuilder.With(i).Build());
        }
    }
}