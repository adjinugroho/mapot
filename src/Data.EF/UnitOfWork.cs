using Core;
using Core.IRepositories;
using Data.EF.Repositories;

namespace Data.EF
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationContext _context;

        public ITAppLogRepository AppLogRepo { get; private set; }
        public ITAppUserRepository AppUserRepo { get; private set; }
        public ITAppApplicationRepository AppApplicationRepo { get; private set; }
        public ITAppUserApplicationRepository AppUserApplicationRepo { get; private set; }

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            AppLogRepo = new TAppLogRepository(_context);
            AppUserRepo = new TAppUserRepository(_context);
            AppApplicationRepo = new TAppApplicationRepository(_context);
            AppUserApplicationRepo = new TAppUserApplicationRepository(_context);
        }

        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
