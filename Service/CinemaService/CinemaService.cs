using DataAccess.EFCore.Interfaces;
using Domain.Entities;
using Domain.Entities.ViewModels;
using System.Collections.Generic;

namespace Service.CinemaService
{
    public class CinemaService : ICinemaService
    {
        //private readonly IUnitOfWork _unitOfWork;

        //public CinemaService(IUnitOfWork unitOfWork)
        //{
        //    _unitOfWork = unitOfWork;
        //}


        //public IEnumerable<Cinema> GetCinemaList()
        //{
        //    var cinemas = _unitOfWork.Cinemas.GetAll();
        //    return cinemas;
        //}

        public void CreateCinema(CinemaViewModel model)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Cinema> GetCinemaList()
        {
            throw new System.NotImplementedException();
        }
    }
}
