using Core.EntityTables;
using Core.IRepositories;

namespace Data.EF.Repositories
{
    public class TAppApplicationRepository : BaseRepository<TAppApplication>, ITAppApplicationRepository
    {
        public TAppApplicationRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
