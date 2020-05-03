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
            ob.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;TrustServerCertificate=False;MultiSubnetFailover=False;database=testDB;");
        }
        //Seb: @"Data Source=localhost,1433;Database=vareDatabase;User ID=SA;Password=SecPass1;"
        //Erm: @"Data Source=(localdb)\MSSQLLocalDB;TrustServerCertificate=False;MultiSubnetFailover=False;database=testDB;"
        //Gus: @"Data Source=localhost,1433;Database=vareDatabase;User ID=SA;Password=Password1!;"

        public DbSet<ItemEntity> Items { get; set; }
        public DbSet<BidEntity> Bids { get; set; }
        public DbSet<ImageEntity> Images { get; set; }
        public DbSet<TagEntity> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<BidEntity>()
                .HasOne(a => a.Item)
                .WithMany(b => b.Bids)
                .HasForeignKey(e => e.ItemId);

            modelBuilder.Entity<ImageEntity>()
                .HasOne(a => a.Item)
                .WithMany(b => b.Images)
                .HasForeignKey(e => e.ItemId);

            modelBuilder.Entity<TagEntity>()
                .HasOne(a => a.Item)
                .WithMany(b => b.Tags)
                .HasForeignKey(b => b.ItemId);
        }
    }
}