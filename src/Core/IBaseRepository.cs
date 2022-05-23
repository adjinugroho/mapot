using Core.Helpers;

namespace Core
{
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> Fetch();
        Task<IEnumerable<T>> FetchPageData(IPagingCondition<T> condition);
        Task Add(T entity);
        Task AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
