using Domain.Entities;
using Domain.Entities.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Service.Interfaces;

namespace Service
{
    public class CreateUserUnitOfWork  : ICreateUserUnitOfWork
    {
        private readonly UserManager<User> _userManager;

        public CreateUserUnitOfWork(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> CreateUser(RegisterViewModel model)
        {
            var user = CreateUserFromModel(model);
            var result = await _userManager.CreateAsync(user, model.Password);

            return result;
        }

        User CreateUserFromModel(RegisterViewModel model)
        {
            var user = new User
            {
                Email = model.Email,
                UserName = model.Email
            };

            return user;
        }
    }
}
