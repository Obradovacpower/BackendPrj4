using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using VareDatabase.Models;

namespace VareDatabase.DBContext
{
    public class VareDataModelContext : DbContext
    {
        public VareDataModelContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            ob.UseSqlServer(@"Data Source=localhost,1433;Database=vareDatabase;User ID=SA;Password=Password1!;");
        }
        //Seb: @"Data Source=localhost,1433;Database=vareDatabase;User ID=SA;Password=SecPass1;"
        //Erm: @"Data Source=(localdb)\MSSQLLocalDB;TrustServerCertificate=False;MultiSubnetFailover=False;database=testDB;"
        //Gus: @"Data Source=localhost,1433;Database=vareDatabase;User ID=SA;Password=Password1!;"

        public DbSet<ItemEntity> Item { get; set; }
        public DbSet<BidEntity> Bid { get; set; }
        public DbSet<DescriptionEntity> Description { get; set; }
        public DbSet<TimeEntity> Time { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemEntity>()
                .HasOne(a => a.Time)
                .WithOne(b => b.Item)
                .HasForeignKey<TimeEntity>(e => e.ItemId);

            modelBuilder.Entity<ItemEntity>()
                .HasOne(a => a.Bid)
                .WithOne(b => b.Item)
                .HasForeignKey<BidEntity>(e => e.ItemId);

            modelBuilder.Entity<ItemEntity>()
                .HasOne(a => a.Description)
                .WithOne(b => b.Item)
                .HasForeignKey<DescriptionEntity>(e => e.ItemId);
        }

    }
}