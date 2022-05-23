using Core.EntityTables;
using Core.IRepositories;

namespace Data.EF.Repositories
{
    public class TAppUserRepository : BaseRepository<TAppUser>, ITAppUserRepository
    {
        public TAppUserRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
