using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace TheCodingClub2.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CodeDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CodeDbContext>>()))
            {
                // Look for any movies.
                if (context.User.Any())
                {
                    return;   // DB has been seeded
                }

                context.User.AddRange(
                    new User
                    {
                        UserID = 1,
                        fName = "John",
                        lName = "Jacobs",
                        userName = "jjschmidt123",
                        passWord = "123abc456"
                    },

                    new User
                    {
                        UserID = 2,
                        fName = "Jessica",
                        lName = "Johnson",
                        userName = "jjbeast333",
                        passWord = "123def456"
                    },

                    new User
                    {
                        UserID = 1,
                        fName = "Jeff",
                        lName = "Babb",
                        userName = "jbabbWizard",
                        passWord = "123thewiz"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}