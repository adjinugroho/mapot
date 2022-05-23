using Core.EntityTables;
using Core.IRepositories;

namespace Data.EF.Repositories
{
    public class TAppUserApplicationRepository : BaseRepository<TAppUserApplication>, ITAppUserApplicationRepository
    {
        public TAppUserApplicationRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
