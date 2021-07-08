using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace TicketSalesSystem.Controllers
{
    public class SessionController : Controller
    {
        private readonly IGetFilmNameUnitOfWork _getFilmName;

        public SessionController(IGetFilmNameUnitOfWork getFilmName)
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
