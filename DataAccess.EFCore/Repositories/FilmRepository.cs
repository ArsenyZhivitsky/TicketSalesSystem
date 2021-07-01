using Domain.Entities;
using Domain.Interfaces;

namespace DataAccess.EFCore.Repositories
{
    public class FilmRepository : GenericRepository<Film>, IFilmRepository
    {
        public FilmRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
