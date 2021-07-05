using Domain.Entities.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Service.UserService
{
    public interface IUserService
    {
        Task<IdentityResult> CreateUserAsync(RegisterViewModel model);

        Task SignInUserAsync(RegisterViewModel model);

        Task<SignInResult> PasswordSignInUserAsync(LoginViewModel model);

        Task SignOutUserAsync();
    }
}
