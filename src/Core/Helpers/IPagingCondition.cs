using System.Linq.Expressions;

namespace Core.Helpers
{
    public interface IPagingCondition<T> where T : class
    {
        Expression<Func<T, bool>> Where { get; }
        string? OrderBy { get; }
        bool? IsOrderDesc { get; }
        int? Skip { get; }
        int? Take { get; }
    }
}
