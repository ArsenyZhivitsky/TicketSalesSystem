using Domain.Entities;
using Domain.Entities.ViewModels;
using System.Collections.Generic;

namespace Service.CinemaService
{
    public interface ICinemaService
    {
        void CreateCinema(CinemaViewModel model);

        IEnumerable<Cinema> GetCinemaList();
    }
}
