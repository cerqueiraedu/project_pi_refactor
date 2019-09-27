using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PerformanceBiller.Repositories;
using PerformanceBiller.Services;
using System.IO;
using System.Linq;
using PerformanceBiller.Entities;
using PerformanceBiller.Infra.DTO.Repositories;
using PerformanceBiller.Infra.Factories;
using PerformanceBiller.Infra.Repositories;
using PerformanceBiller.Repositories.Abstractions;
using Xunit;

namespace PerformanceBiller.Tests
{
    public class StatementTests
    {
        [Fact]
        public void Statement_can_run()
        {
            /*
            var expectedOutput = "Statement for BigCo\n" +
                " Hamlet: $650.00 (55 seats)\n" +
                " As You Like It: $580.00 (35 seats)\n" +
                " Othello: $500.00 (40 seats)\n" +
                "Amount owed is $1,730.00\n" +
                "You earned 47 credits\n";

            var statement = new Statement();

            using (var invoicesFile = File.OpenText("..\\..\\..\\invoices.json"))
            using (var invoicesReader = new JsonTextReader(invoicesFile))
            using (var playsFile = File.OpenText("..\\..\\..\\plays.json"))
            using (var playsReader = new JsonTextReader(playsFile)) {
                var invoices = (JArray) JToken.ReadFrom(invoicesReader);

                var invoice = (JObject) invoices.First;

                var plays = (JObject) JToken.ReadFrom(playsReader);

                var actualResult = statement.Run(invoice, plays);

                Assert.Equal(expectedOutput, actualResult); 
            }*/
        }

        [Fact]
        public void Statement_refactored()
        {
            const string basePath = "..\\..\\..\\";
            IInvoiceRepository invoicerepo = new InvoiceRepository(new PlayDtoRepository(basePath), new InvoiceDtoRepository(basePath));
            var invoices = invoicerepo.Get().ToList();
            var tragedy = invoices.First().Performances.Where(p => p.Play is Tragedy).Sum(p => p.Calculate());
            var hamlet = invoices.First().Performances.Where(p => p.Name == "As You Like It").Sum(p => p.Calculate());

        }
    }
}
