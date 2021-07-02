using Domain.Entities;
using System.Collections.Generic;
using TicketSalesSystem.ViewModels;

namespace TicketSalesSystem.Services.Interfaces
{
    public interface ISessionService
    {
        string GetFilmName(int filmId);

    }
}
