using System;

namespace DataAccess.EFCore.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
    }
}
