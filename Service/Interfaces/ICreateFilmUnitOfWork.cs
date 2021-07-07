using Domain.Entities.ViewModels;

namespace Service.Interfaces
{
    public interface ICreateFilmUnitOfWork
    {
        void CreateFilm(FilmViewModel model);
    }
}
