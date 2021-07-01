using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSalesSystem.Services;
using TicketSalesSystem.Services.Interfaces;
using TicketSalesSystem.ViewModels;

namespace TicketSalesSystem.Controllers
{
    public class CinemaController : Controller
    {
        private readonly ICinemaService _cinemaService;

        public CinemaController(ICinemaService cinemaService)
        {
            _cinemaService = cinemaService;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

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
                _cinemaService.CreateCinema(model);

                return RedirectToAction("Index", "Film");
            }

            return View(model);
        }
    }
}
