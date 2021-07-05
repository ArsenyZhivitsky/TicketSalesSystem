using System.Collections.Generic;
using Domain.Entities.ViewModels;
using Domain.Entities;

namespace Service.FilmsService
{
    public interface IFilmService
    {
        void CreateFilm(FilmViewModel model);

        IEnumerable<Film> GetFilms();

        Film GetFilm(int id);

        string GetFilmName(int id);
    }
}
