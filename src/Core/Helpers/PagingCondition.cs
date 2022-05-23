using System.Linq.Expressions;

namespace Core.Helpers
{
    public class PagingCondition<T> : IPagingCondition<T> where T : class
    {
        public Expression<Func<T, bool>> Where { get; }
        public string? OrderBy { get; }
        public bool? IsOrderDesc { get; }
        public int? Skip { get; private set; }
        public int? Take { get; private set; }

        public PagingCondition(Expression<Func<T, bool>> where, string orderBy, bool isOrderDesc, int? skip, int? take)
        {
            Where = where;
            OrderBy = orderBy;
            IsOrderDesc = isOrderDesc;
            Skip = skip;
            Take = take;
        }
    }
}
