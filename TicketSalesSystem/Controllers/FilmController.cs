using Domain.Entities.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Service;
using Service.Interfaces;
using System.Threading.Tasks;

namespace TicketSalesSystem.Controllers

{
    public class FilmController : Controller
    {
        private readonly ICreateFilmUnitOfWork _createFilm;
        private readonly GetFilmsUnitOfWork _getFilms;
        private readonly GetFilmUnitOfWork _getFilm;

        public FilmController(ICreateFilmUnitOfWork createFilm, GetFilmsUnitOfWork getFilms, GetFilmUnitOfWork getFilm)
        {
            _createFilm = createFilm;
            _getFilms = getFilms;
            _getFilm = getFilm;
        }

        public IActionResult Index()
        {
            var films = _getFilms.GetFilms();

            return View(films);
        }

        [HttpGet]
        public IActionResult CreateFilm()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFilm(FilmViewModel model)
        {
            if (ModelState.IsValid)
            {
                _createFilm.CreateFilm(model);

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var film = _getFilm.GetFilm(id.Value);

            if (film == null)
            {
                return NotFound();
            }

            var model = new FilmDetailsViewModel
            {
                Id = film.Id,
                Name = film.Name,
                Description = film.Description
            };

            return View(model);
        }
    }
}
