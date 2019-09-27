using PerformanceBiller.Entities;

namespace PerformanceBiller.Builder.Abstractions
{
    public interface IBuildStatement
    {
        IBuildStatement With(Invoice invoice);

        Statement Build();
    }
}
