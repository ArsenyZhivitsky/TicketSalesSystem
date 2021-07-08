using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Service.Interfaces;

namespace Service
{
    public class SignOutUnitOfWork : ISignOutUnitOfWork
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
