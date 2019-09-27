using PerformanceBiller.Builder.Abstractions;
using PerformanceBiller.Entities;

namespace PerformanceBiller.Builder
{
    public class StatementBuilder : IBuildStatement
    {
        private Invoice _invoice;

        public IBuildStatement With(Invoice invoice)
        {
            _invoice = invoice;
            return this;
        }

        public Statement Build()
        {
            return new Statement(_invoice);
        }
    }
}
