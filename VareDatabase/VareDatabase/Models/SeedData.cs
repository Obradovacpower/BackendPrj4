using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using VareDatabase.DBContext;

namespace VareDatabase.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VareDataModelContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<VareDataModelContext>>()))
            {
                //Dummiedata.
                if (context.Item.Any())
                {
                    return;   // DB has been seeded
                }

                context.Item.AddRange(
                    new ItemEntity
                    {
                        ItemId =  5,
                        Type = "jonas' gamle legendary skjold fra Arch Age"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}