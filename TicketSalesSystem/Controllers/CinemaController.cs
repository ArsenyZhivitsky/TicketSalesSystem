using Domain.Entities.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Service;

namespace TicketSalesSystem.Controllers
{
    public class CinemaController : Controller
    {
        private readonly CreateCinemaUnitOfWork _createCinema;

        public CinemaController(CreateCinemaUnitOfWork createCinema)
        {
            _createCinema = createCinema;
        }

        [HttpGet]
        public IActionResult CreateCinema()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCinema(CinemaViewModel model)
        {
            if (ModelState.IsValid)
            {
                _createCinema.CreateCinema(model);

                return RedirectToAction("Index", "Film");
            }

            return View(model);
        }
    }
}
