using Domain.Entities.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface ISignInUnitOfWork
    {
        Task SignInUser(RegisterViewModel model);

        Task<SignInResult> PasswordSignInUser(LoginViewModel model);
    }
}
