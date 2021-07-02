using Domain.Entities;
using System.Collections.Generic;
using TicketSalesSystem.ViewModels;

namespace TicketSalesSystem.Services.Interfaces
{
    public interface ICinemaService
    {
        void CreateCinema(CinemaViewModel model);

        IEnumerable<Cinema> GetCinemaList();
    }
}
