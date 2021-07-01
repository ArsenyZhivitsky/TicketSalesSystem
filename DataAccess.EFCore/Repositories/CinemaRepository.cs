using Domain.Entities;
using Domain.Interfaces;

namespace DataAccess.EFCore.Repositories
{
    public class CinemaRepository : GenericRepository<Cinema>, ICinemaRepository
    {
        public CinemaRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
