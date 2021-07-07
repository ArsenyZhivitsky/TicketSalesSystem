using DataAccess.EFCore;
using DataAccess.EFCore.Interfaces;
using DataAccess.EFCore.Repositories;
using DataAccess.EFCore.UnitOfWork;
using Domain.Entities;
using Domain.Entities.ViewModels;
using Service.Interfaces;

namespace Service
{
    public class CreateCinemaUnitOfWork : UnitOfWork, ICreateCinemaUnitOfWork
    {
       
        public CreateCinemaUnitOfWork(ApplicationContext context) : base (context)
        {
            Cinemas = new CinemaRepository(context);
        }

        public ICinemaRepository Cinemas { get; private set; }

        public void CreateCinema(CinemaViewModel model)
        {
            var cinema = CreateCinemaFromModel(model);
            Cinemas.Add(cinema);
            Complete();
        }

        Cinema CreateCinemaFromModel(CinemaViewModel model)
        {
            var cinema = new Cinema
            {
                Name = model.Name
            };

            return cinema;
        }

    }
}
