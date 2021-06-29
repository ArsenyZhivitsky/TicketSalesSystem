using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace DataAccess.EFCore
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {

        }

        public DbSet<Film> Films { get; set; }
    }
}
