using CarParadise.Models.UserAndTopics;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarParadise.Web.Common
{
    public static class ApplicationBuilderAuthExtensions
    {
        private const string DefaultAdminPassword = "admin123";
        private const string DefaultLecturerPassword = "user123";

        private static readonly IdentityRole[] roles =
        {
            new IdentityRole("Administrator"),
            new IdentityRole("User")
        };

        // TODO: Use a dictionary (string -> User) for roles and users
        public static async void SeedDatabase(this IApplicationBuilder app)
        {
            var serviceFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
            var scope = serviceFactory.CreateScope();
            using (scope)
            {
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();

                foreach (var role in roles)
                {
                    if (!await roleManager.RoleExistsAsync(role.Name))
                    {
                        await roleManager.CreateAsync(role);
                    }
                }

                var admin = await userManager.FindByNameAsync("admin");
                if (admin == null)
                {
                    admin = new User()
                    {
                        UserName = "admin",
                        Email = "admin@example.com"
                    };

                    await userManager.CreateAsync(admin, DefaultAdminPassword);
                    await userManager.AddToRoleAsync(admin, roles[0].Name);
                }

                var user = await userManager.FindByNameAsync("user");
                if (user == null)
                {
                    user = new User()
                    {
                        UserName = "User",
                        Email = "user@example.com"
                    };

                    await userManager.CreateAsync(user, DefaultLecturerPassword);
                    await userManager.AddToRoleAsync(user, roles[1].Name);
                }
            }
        }
    }
}
