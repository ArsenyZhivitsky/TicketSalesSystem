using Domain.Entities;
using Domain.Entities.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Service
{
    public class SignInUnitOfWork
    {
        private readonly SignInManager<User> _signInManager;

        public SignInUnitOfWork(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task SignInUser(RegisterViewModel model)
        {
            var user = CreateUserFromModel(model);
            await _signInManager.SignInAsync(user, false);
        }

        public async Task<SignInResult> PasswordSignInUser(LoginViewModel model)
        {
            var result =
                await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
            return result;
        }

        User CreateUserFromModel(RegisterViewModel model)
        {
            User user = new User
            {
                Email = model.Email,
                UserName = model.Email
            };

            return user;
        }
    }
}
