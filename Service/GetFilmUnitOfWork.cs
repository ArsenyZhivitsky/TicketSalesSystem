using DataAccess.EFCore;
using DataAccess.EFCore.Interfaces;
using DataAccess.EFCore.Repositories;
using DataAccess.EFCore.UnitOfWork;
using Domain.Entities;
using Service.Interfaces;

namespace Service
{
    public class GetFilmUnitOfWork : UnitOfWork, IGetFilmUnitOfWork
    {
        public GetFilmUnitOfWork(ApplicationContext context) : base (context)
        {
            Films = new FilmRepository(context);
        }
        public IFilmRepository Films { get; private set; }

        public Film GetFilm(int id)
        {
            var film = Films.GetById(id);

            return film;
        }
    }
}
