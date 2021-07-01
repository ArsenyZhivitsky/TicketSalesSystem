using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using TicketSalesSystem.ViewModels;

namespace TicketSalesSystem.Services.Interfaces
{
    public interface IUserService
    {
        Task<IdentityResult> CreateUserAsync(RegisterViewModel model);

        Task SignInUserAsync(RegisterViewModel model);

        Task<SignInResult> PasswordSignInUserAsync(LoginViewModel model);

        Task SignOutUserAsync();
    }
}
