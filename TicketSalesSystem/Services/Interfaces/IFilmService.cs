using TicketSalesSystem.ViewModels;
using System.Threading.Tasks;
using System.Collections.Generic;
using Domain.Entities;

namespace TicketSalesSystem.Services
{
    public interface IFilmService
    {
        void CreateFilm(FilmViewModel model);

        IEnumerable<Film> GetFilms();

        Film GetFilm(int id);

        string GetFilmName(int id);
    }
}
