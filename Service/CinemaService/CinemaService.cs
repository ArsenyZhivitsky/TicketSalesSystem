using DataAccess.EFCore.Interfaces;
using Domain.Entities;
using Domain.Entities.ViewModels;
using System.Collections.Generic;

namespace Service.CinemaService
{
    public class CinemaService : ICinemaService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CinemaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void CreateCinema(CinemaViewModel model)
        {
            var cinema = CreateCinemaFromModel(model);

            _unitOfWork.Cinemas.Add(cinema);
            _unitOfWork.Complete();
        }

        public IEnumerable<Cinema> GetCinemaList()
        {
            var cinemas = _unitOfWork.Cinemas.GetAll();
            return cinemas;
        }

        Cinema CreateCinemaFromModel(CinemaViewModel model)
        {
            var cinema = new Cinema
            {
                Name = model.Name
            };

            return cinema;
        }
    }
}
