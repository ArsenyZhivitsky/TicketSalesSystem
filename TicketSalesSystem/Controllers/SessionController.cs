using Microsoft.AspNetCore.Mvc;
using Service;

namespace TicketSalesSystem.Controllers
{
    public class SessionController : Controller
    {
        private readonly GetFilmNameUnitOfWork _getFilmName;

        public SessionController(GetFilmNameUnitOfWork getFilmName)
        {
            _getFilmName = getFilmName;
        }

        [HttpGet]
        public IActionResult CreateSession(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmName = _getFilmName.GetFilmName(id.Value);
            //var cinemas = _cinemaService.GetCinemaList();

            ViewBag.FilmName = filmName;
            //ViewBag.Cinemas = cinemas;

            return View();
        }
    }
}
