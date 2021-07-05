using DataAccess.EFCore.Interfaces;
using Domain.Entities;

namespace DataAccess.EFCore.Repositories
{
    public class FilmRepository : GenericRepository<Film>, IFilmRepository
    {
        public FilmRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
