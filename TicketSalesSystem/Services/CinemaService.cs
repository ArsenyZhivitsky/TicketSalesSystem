using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using TicketSalesSystem.Services.Interfaces;
using TicketSalesSystem.ViewModels;

namespace TicketSalesSystem.Services
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
