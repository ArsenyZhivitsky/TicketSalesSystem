using DataAccess.EFCore.Interfaces;
using Domain.Entities;

namespace DataAccess.EFCore.Repositories
{
    public class CinemaRepository : GenericRepository<Cinema>, ICinemaRepository
    {
        public CinemaRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
