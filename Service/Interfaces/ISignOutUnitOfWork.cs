using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface ISignOutUnitOfWork
    {
        Task SignOutUser();
    }
}
