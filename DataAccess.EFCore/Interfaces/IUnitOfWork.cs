using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IFilmRepository Films { get; }

        ICinemaRepository Cinemas { get; }
        int Complete();
    }
}
