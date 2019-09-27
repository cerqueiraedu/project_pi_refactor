using System.Globalization;
using System.Linq;
using System.Text;
using PerformanceBiller.Builder.Abstractions;
using PerformanceBiller.Entities;

namespace PerformanceBiller.Builder
{
    public class ReportBuilder : IBuildReport
    {
        private Statement _statement;
        private readonly StringBuilder _builder;
        private readonly CultureInfo _cultureInfo;

        public ReportBuilder(CultureInfo cultureInfo)
        {
            _cultureInfo = cultureInfo;
            _builder = new StringBuilder();
        }

        public IBuildReport With(Statement statement)
        {
            _statement = statement;
            return this;
        }

        public string Build()
        {
            _builder.AppendLine($"Statement for {_statement.Invoice.Customer.Name}");

            _statement
                .Invoice
                .Performances
                .ToList()
                .ForEach(p => 
                {
                    _builder
                        .AppendLine($" {p.Name}: {(p.Calculate() / 100).ToString("C", _cultureInfo)} ({p.Audience} seats)");
                });

            _builder.AppendLine($"Amount owed is {(_statement.TotalAmount / 100).ToString("C", _cultureInfo)}");
            _builder.AppendLine($"You earned {_statement.TotalExtraCredits} credits");
            
            return _builder.ToString();
        }
    }
}
