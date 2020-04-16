using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using VareDatabase.Models;

namespace VareDatabase.DBContext
{
    class VareDataModelContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            ob.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB;Database=testdb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
       
        public DbSet<ItemEntity> Item { get; set; }
        public DbSet<BidEntity> BId { get; set; }
        public DbSet<DescriptionEntity> Description { get; set; }
        public DbSet<TimeEntity> Time { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemEntity>()
                .HasOne(a => a.Time)
                .WithOne(b => b.Item)
                .HasForeignKey<TimeEntity>(e => e.Item);

            modelBuilder.Entity<ItemEntity>()
                .HasOne(a => a.Bid)
                .WithOne(b => b.Item)
                .HasForeignKey<BidEntity>(e => e.Item);

            modelBuilder.Entity<ItemEntity>()
                .HasOne(a => a.Description)
                .WithOne(b => b.Item)
                .HasForeignKey<DescriptionEntity>(e => e.Item);
        }

    }
}