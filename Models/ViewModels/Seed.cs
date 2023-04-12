using Intex2A.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Intex2A.Models.ViewModels
{
    public class Seed
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
                var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                // Create roles
                var roles = new List<IdentityRole>
                {
                    new IdentityRole { Name = "Admin" },
                    new IdentityRole { Name = "User" }
                };

                foreach (var role in roles)
                {
                    if (!await roleManager.RoleExistsAsync(role.Name))
                    {
                        await roleManager.CreateAsync(role);
                    }
                }

                // Create users and assign them to roles
                var users = new List<IdentityUser>
                {
                    new IdentityUser { UserName = "spencercheng2000@gmail.com", Email = "spencercheng2000@gmail.com" },
                    new IdentityUser { UserName = "user@example.com", Email = "user@example.com" }
                };

                foreach (var user in users)
                {
                    if (await userManager.FindByNameAsync(user.UserName) == null)
                    {
                        await userManager.CreateAsync(user, "Password123!");
                        await userManager.AddToRoleAsync(user, user.UserName == "admin@example.com" ? "Admin" : "User");
                    }
                }
            }
        }
    }
}
