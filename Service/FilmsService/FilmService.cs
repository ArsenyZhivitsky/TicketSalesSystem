using DataAccess.EFCore.Interfaces;
using Domain.Entities;
using Domain.Entities.ViewModels;
using System.Collections.Generic;

namespace Service.FilmsService
{
    public class FilmService : IFilmService
    {
        //private readonly IUnitOfWork _unitOfWork;
        //public FilmService(IUnitOfWork unitOfWork)
        //{
        //    _unitOfWork = unitOfWork;
        //}

        //public IEnumerable<Film> GetFilms()
        //{
        //    var films = _unitOfWork.Films.GetAll();

        //    return films;
        //}

        //public Film GetFilm(int id)
        //{
        //    var film = _unitOfWork.Films.GetById(id);
        //    return film;
        //}

        //public string GetFilmName(int id)
        //{
        //    var filmName = _unitOfWork.Films.GetById(id).Name;
        //    return filmName;
        //}

       
        public void CreateFilm(FilmViewModel model)
        {
            throw new System.NotImplementedException();
        }

        public Film GetFilm(int id)
        {
            throw new System.NotImplementedException();
        }

        public string GetFilmName(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Film> GetFilms()
        {
            throw new System.NotImplementedException();
        }
    }
}
