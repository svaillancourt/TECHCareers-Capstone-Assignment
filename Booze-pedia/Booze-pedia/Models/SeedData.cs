using Booze_pedia.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booze_pedia.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BoozeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BoozeContext>>()))
            {
                // Look for any movies.
                if (context.Booze.Any())
                {
                    return;   // DB has been seeded
                }

                context.Booze.AddRange(
                    new Booze
                    {
                        Name = "Molson Canadian",
                        Category = "Beer",
                        Description = "Lager",
                        Quantity = 50,
                        Price = 2,
                        InStock = true
                    },

                    new Booze
                    {
                        Name = "Heineken",
                        Category = "Beer",
                        Description = "Lager",
                        Quantity = 100,
                        Price = 3,
                        InStock = true
                    },

                    new Booze
                    {
                        Name = "Bud Light",
                        Category = "Beer",
                        Description = "Lager",
                        Quantity = 50,
                        Price = 2,
                        InStock = true
                    },

                    new Booze
                    {
                        Name = "Johnnie Walker",
                        Category = "Whiskey",
                        Description = "Scotch Wiskey",
                        Quantity = 50,
                        Price = 45,
                        InStock = true
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
