using DataAccess.EFCore.Interfaces;
using Domain.Entities;

namespace DataAccess.EFCore.Repositories
{
    public class SessionRepository : GenericRepository<Session>, ISessionRepository
    {
        public SessionRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
