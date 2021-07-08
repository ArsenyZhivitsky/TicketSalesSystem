using Domain.Entities;
using System.Collections.Generic;

namespace Service.Interfaces
{
    public interface IGetFilmsUnitOfWork
    {
        IEnumerable<Film> GetFilms();
    }
}
