using Domain.Entities.ViewModels;

namespace Service.Interfaces
{
    public interface ICreateCinemaUnitOfWork
    {
        void CreateCinema(CinemaViewModel model);
    }
}
