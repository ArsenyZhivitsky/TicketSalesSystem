﻿using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using TicketSalesSystem.Services.Interfaces;
using TicketSalesSystem.ViewModels;

namespace TicketSalesSystem.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserService(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IdentityResult> CreateUserAsync(RegisterViewModel model)
        {
            var user = CreateUserFromModel(model);
            var result = await _userManager.CreateAsync(user, model.Password);

            return await Task.FromResult(result);
        }

        public async Task SignInUserAsync(RegisterViewModel model)
        { 
            var user = CreateUserFromModel(model);
            await _signInManager.SignInAsync(user, false);
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
