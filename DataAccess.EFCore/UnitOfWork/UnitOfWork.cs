using DataAccess.EFCore.Interfaces;
using DataAccess.EFCore.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Films = new FilmRepository(_context);
            Cinemas = new CinemaRepository(_context);
            Sessions = new SessionRepository(_context);
        }

        public IFilmRepository Films { get; private set; }

        public ICinemaRepository Cinemas { get; private set; }

        public ISessionRepository Sessions { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
