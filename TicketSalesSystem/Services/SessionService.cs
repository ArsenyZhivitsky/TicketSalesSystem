using Domain.Interfaces;
using TicketSalesSystem.Services.Interfaces;
using TicketSalesSystem.ViewModels;

namespace TicketSalesSystem.Services
{
    public class SessionService : ISessionService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly ICinemaService _cinemaService;

        public SessionService(IUnitOfWork unitOfWork, ICinemaService cinemaService)
        {
            _unitOfWork = unitOfWork;
            _cinemaService = cinemaService;
        }
        public string GetFilmName(int filmId)
        {
            var filmName = _unitOfWork.Films.GetById(filmId).Name;
            return filmName;
        }
    }
}
