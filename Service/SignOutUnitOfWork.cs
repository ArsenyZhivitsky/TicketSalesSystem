using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Service
{
    public class SignOutUnitOfWork
    {
        private readonly SignInManager<User> _signInManager;

        public SignOutUnitOfWork(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task SignOutUser()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
