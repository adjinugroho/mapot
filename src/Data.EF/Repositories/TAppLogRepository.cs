using Core.EntityTables;
using Core.IRepositories;

namespace Data.EF.Repositories
{
    public class TAppLogRepository : BaseRepository<TAppLog>, ITAppLogRepository
    {
        public TAppLogRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
