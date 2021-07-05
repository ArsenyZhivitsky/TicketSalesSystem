using Domain.Interfaces;
using Domain.Entities;
using System.Collections.Generic;
using Domain.Entities.ViewModels;

namespace Service.FilmsService
{
    public class FilmService : IFilmService
    {
        private readonly IUnitOfWork _unitOfWork;
        public FilmService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void CreateFilm(FilmViewModel model)
        {
            var film = CreateFilmFromModel(model);

            _unitOfWork.Films.Add(film);
            _unitOfWork.Complete();
        }

        public IEnumerable<Film> GetFilms()
        {
            var films = _unitOfWork.Films.GetAll();

            return films;
        }

        public Film GetFilm(int id)
        {
            var film = _unitOfWork.Films.GetById(id);
            return film;
        }

        public string GetFilmName(int id)
        {
            var filmName = _unitOfWork.Films.GetById(id).Name;
            return filmName;
        }

        Film CreateFilmFromModel(FilmViewModel model)
        {
            Film film = new Film
            {
                Name = model.Name,
                Description = model.Description
            };

            return film;
        }

    }
}
