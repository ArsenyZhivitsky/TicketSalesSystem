using Microsoft.AspNetCore.Mvc;
using Service.FilmsService;

namespace TicketSalesSystem.Controllers
{
    public class SessionController : Controller
    {
        private readonly IFilmService _filmService;
        //private readonly ICinemaService _cinemaService;
        //private readonly ISessionService _sessionService;

        public SessionController(IFilmService filmService)//, ICinemaService cinemaService)
        {
            _filmService = filmService;
            //_cinemaService = cinemaService;
            //_sessionService = sessionService;
        }

        [HttpGet]
        public IActionResult CreateSession(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmName = _filmService.GetFilmName(id.Value);
            //var cinemas = _cinemaService.GetCinemaList();

            ViewBag.FilmName = filmName;
            //ViewBag.Cinemas = cinemas;

            return View();
        }
    }
}
