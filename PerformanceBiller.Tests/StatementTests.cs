using System.Globalization;
using System.Linq;
using PerformanceBiller.Services;
using PerformanceBiller.Builder;
using PerformanceBiller.Builder.Abstractions;
using PerformanceBiller.Infra.DTO.Repositories;
using PerformanceBiller.Infra.Repositories;
using PerformanceBiller.Repositories.Abstractions;
using Xunit;

namespace PerformanceBiller.Tests
{
    public class StatementTests
    {
        [Fact]
        public void Statement_refactored()
        {
            const string expectedResult = "Statement for BigCo\r\n" +
                                          " Hamlet: $650.00 (55 seats)\r\n" +
                                          " As You Like It: $580.00 (35 seats)\r\n" +
                                          " Othello: $500.00 (40 seats)\r\n" +
                                          "Amount owed is $1,730.00\r\n" +
                                          "You earned 47 credits\r\n";

            const string basePath = "..\\..\\..\\";

            IInvoiceRepository invoiceRepository = new InvoiceRepository(new PlayDtoRepository(basePath), new InvoiceDtoRepository(basePath));
            IBuildStatement statementBuilder = new StatementBuilder();

            var statementService = new StatementService(invoiceRepository, statementBuilder);
            var statements = statementService
                .GetStatements()
                .ToList();

            IBuildReport reportBuilder = new ReportBuilder(new CultureInfo("en-US"));

            var reportService = new ReportService(reportBuilder);
            var reports = reportService
                .GetReports(statements)
                .ToList();

            Assert.Equal(expectedResult, reports.First());
        }
    }
}
