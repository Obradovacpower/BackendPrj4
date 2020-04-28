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
                //Dummiedata.
                if (context.Items.Any())
                {
                    return;   // DB has been seeded
                }
                DummyData dd = new DummyData();
                dd.InsertDummyData(context);
                context.SaveChanges();
            }
        }
    }
}