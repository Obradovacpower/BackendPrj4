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
            using (var context = new VareDataModelContext())
            {
                context.Database.EnsureCreated();
                DummyData dd = new DummyData();
                string[] s = { "shield", "Melee" };
                //Dummiedata.
                if (context.Items.Any())
                {
                    dd.Search(s, context);
                    return;   // DB has been seeded
                }
                dd.InsertDummyData(context);
                context.SaveChanges();
            }
        }
    }
}