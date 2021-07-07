﻿using DataAccess.EFCore;
using DataAccess.EFCore.Interfaces;
using DataAccess.EFCore.Repositories;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service.Interfaces;

namespace Service.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IFilmRepository, FilmRepository>();
            services.AddScoped<ICinemaRepository, CinemaRepository>();
            services.AddScoped<ISessionRepository, SessionRepository>();

            return services;
        }

        public static IServiceCollection AddUnitOfWorks(this IServiceCollection services)
        {
            services.AddScoped<CreateUserUnitOfWork>();
            services.AddScoped<SignInUnitOfWork>();
            services.AddScoped<SignOutUnitOfWork>();
            services.AddScoped<ICreateCinemaUnitOfWork, CreateCinemaUnitOfWork>();
            services.AddScoped<ICreateFilmUnitOfWork, CreateFilmUnitOfWork>();
            services.AddScoped<GetFilmsUnitOfWork>();
            services.AddScoped<GetFilmUnitOfWork>();
            services.AddScoped<GetFilmNameUnitOfWork>();

            return services;
        }

        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
           services.AddDbContext<ApplicationContext>(options =>
           options.UseSqlServer(
               configuration.GetConnectionString("DefaultConnection"),
               b => b.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));

            return services;
        }

        public static IServiceCollection AddIdentityToApplication(this IServiceCollection services)
        {
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationContext>();

            return services;
        }
    }
}
