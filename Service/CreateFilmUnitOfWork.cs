using DataAccess.EFCore;
using DataAccess.EFCore.Interfaces;
using DataAccess.EFCore.Repositories;
using DataAccess.EFCore.UnitOfWork;
using Domain.Entities;
using Domain.Entities.ViewModels;
using Service.Interfaces;

namespace Service
{
    public class CreateFilmUnitOfWork : UnitOfWork, ICreateFilmUnitOfWork
    {
        public CreateFilmUnitOfWork(ApplicationContext context) : base(context)
        {
            Films = new FilmRepository(context);
        }

        public IFilmRepository Films { get; private set; }

        public void CreateFilm(FilmViewModel model)
        {
            var film = CreateFilmFromModel(model);
            Films.Add(film);
            Complete();
        }

        Film CreateFilmFromModel(FilmViewModel model)
        {
            var film = new Film
            {
                Name = model.Name,
                Description = model.Description
            };

            return film;
        }
    }
}
