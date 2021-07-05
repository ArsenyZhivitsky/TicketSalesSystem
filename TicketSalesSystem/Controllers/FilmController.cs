using Domain.Entities;
using Domain.Entities.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Service.FilmsService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TicketSalesSystem.Controllers

{
    public class FilmController : Controller
    {
        private readonly IFilmService _filmService;

        public FilmController(IFilmService filmService)
        {
            _filmService = filmService;
        }

        public IActionResult Index()
        {
            //var films = _filmService.GetFilms();
            var films = new List<Film>();

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
                _filmService.CreateFilm(model);

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

            var film = _filmService.GetFilm(id.Value);

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
            //return RedirectToAction("Index");
        }
    }
}
