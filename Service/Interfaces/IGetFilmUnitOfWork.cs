using Domain.Entities;

namespace Service.Interfaces
{
    public interface IGetFilmUnitOfWork
    {
        Film GetFilm(int id);
    }
}
