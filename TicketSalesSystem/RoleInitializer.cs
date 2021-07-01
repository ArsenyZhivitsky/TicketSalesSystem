using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace TicketSalesSystem
{
    public class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            IConfigurationSection AdminCredentials = configuration.GetSection("AdminCredentials");
            var adminEmail = AdminCredentials.GetSection("Email").Value;
            var password = AdminCredentials.GetSection("Password").Value;

            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if (await roleManager.FindByNameAsync("user") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("user"));
            }
            if (!string.IsNullOrEmpty(adminEmail) && !string.IsNullOrEmpty(password))
            {
                if (await userManager.FindByNameAsync(adminEmail) == null)
                {
                    User admin = new User { Email = adminEmail, UserName = adminEmail };
                    IdentityResult result = await userManager.CreateAsync(admin, password);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(admin, "admin");
                    }
                }
            }
        }
    }
}
