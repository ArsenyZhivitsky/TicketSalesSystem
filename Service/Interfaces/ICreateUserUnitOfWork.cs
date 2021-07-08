using Domain.Entities.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface ICreateUserUnitOfWork
    {
        Task<IdentityResult> CreateUser(RegisterViewModel model);
    }
}
