using Core;
using Core.Helpers;
using Core.Helpers.System;
using Microsoft.EntityFrameworkCore;

namespace Data.EF
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly ApplicationContext _context;

        public BaseRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IQueryable<T> Fetch()
        {
            return _context.Set<T>();
        }

        public async Task<IEnumerable<T>> FetchPageData(IPagingCondition<T> condition)
        {
            IQueryable<T> data = _context.Set<T>();

            if (condition.Where != null)
            {
                data = data.Where(condition.Where);
            }

            if (!string.IsNullOrEmpty(condition.OrderBy))
            {
                data = data.OrderBy(condition.OrderBy, condition.IsOrderDesc.Value);
            }

            if (condition.Skip.HasValue && condition.Take.HasValue)
            {
                data = data.Skip(condition.Skip.Value).Take(condition.Take.Value);
            }

            return await data.ToListAsync();
        }

        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public async Task AddRange(IEnumerable<T> entities)
        {
            await _context.Set<T>().AddRangeAsync(entities);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            _context.Set<T>().UpdateRange(entities);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }
    }
}
