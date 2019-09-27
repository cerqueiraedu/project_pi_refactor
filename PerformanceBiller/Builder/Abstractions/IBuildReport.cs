using PerformanceBiller.Entities;

namespace PerformanceBiller.Builder.Abstractions
{
    public interface IBuildReport
    {
        IBuildReport With(Statement statement);

        string Build();
    }
}
