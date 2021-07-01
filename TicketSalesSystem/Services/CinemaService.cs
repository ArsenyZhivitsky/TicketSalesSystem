using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
