using DataAccess.EFCore;
using DataAccess.EFCore.Interfaces;
using DataAccess.EFCore.Repositories;
using DataAccess.EFCore.UnitOfWork;

namespace Service
{
    public class GetFilmNameUnitOfWork : UnitOfWork
    {
        public GetFilmNameUnitOfWork(ApplicationContext context) : base(context)
        {
            Films = new FilmRepository(context);
        }

        public IFilmRepository Films { get; private set; }

        public string GetFilmName(int id)
        {
            var filmName = Films.GetById(id).Name;

            return filmName;
        }
    }
}
