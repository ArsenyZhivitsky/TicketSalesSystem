﻿using DataAccess.EFCore;
using DataAccess.EFCore.Interfaces;
using DataAccess.EFCore.Repositories;
using DataAccess.EFCore.UnitOfWork;
using Domain.Entities;
using System.Collections.Generic;
using Service.Interfaces;

namespace Service
{
    public class GetFilmsUnitOfWork : UnitOfWork, IGetFilmsUnitOfWork
    {
        public GetFilmsUnitOfWork(ApplicationContext context) : base(context)
        {
            Films = new FilmRepository(context);
        }

        public IFilmRepository Films { get; private set; }

        public IEnumerable<Film> GetFilms()
        {
            var films = Films.GetAll();

            return films;
        }
    }
}
