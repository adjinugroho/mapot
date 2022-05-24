using Core.IRepositories;

namespace Core
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> Complete();

        ITAppLogRepository AppLogRepo { get; }
        ITAppUserRepository AppUserRepo { get; }
        ITAppApplicationRepository AppApplicationRepo { get; }
        ITAppUserApplicationRepository AppUserApplicationRepo { get; }
    }
}
