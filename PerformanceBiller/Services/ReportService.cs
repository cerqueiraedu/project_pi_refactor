using System.Collections.Generic;
using System.Linq;
using PerformanceBiller.Builder.Abstractions;
using PerformanceBiller.Entities;

namespace PerformanceBiller.Services
{
    public class ReportService
    {
        private readonly IBuildReport _reportBuilder;

        public ReportService(IBuildReport reportBuilder)
        {
            _reportBuilder = reportBuilder;
        }

        public IEnumerable<string> GetReports(IEnumerable<Statement> statements)
        {
            return statements.Select(s => _reportBuilder.With(s).Build());
        }
    }
}