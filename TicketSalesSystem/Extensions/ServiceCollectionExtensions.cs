using DataAccess.EFCore.Interfaces;
using DataAccess.EFCore.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Service;

namespace TicketSalesSystem.Extensions
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
            services.AddScoped<CreateCinemaUnitOfWork>();
            services.AddScoped<CreateFilmUnitOfWork>();
            services.AddScoped<GetFilmsUnitOfWork>();
            services.AddScoped<GetFilmUnitOfWork>();
            services.AddScoped<GetFilmNameUnitOfWork>();

            return services;
        }
    }
}
