using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(p => p.Id);

            //modelBuilder.Entity<Product>()
            //  .HasOne(p => p.Brand)
            //  .WithMany(b => b.Products)
            //  .HasForeignKey(p => p.BrandId)
            //  .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Product>()
            //    .HasOne(p => p.ProuctTypeId)
            //    .WithMany(t => t.Products)
            //    .HasForeignKey(p => p.ProuctTypeId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //// Brand configuration
            //modelBuilder.Entity<Brand>()
            //    .HasMany(b => b.Products)
            //    .WithOne(p => p.Brand)
            //    .HasForeignKey(p => p.BrandId);

            //// ProductType configuration
            //modelBuilder.Entity<ProductType>()
            //    .HasMany(t => t.Products)
            //    .WithOne(p => p.ProuctTypeId)
            //    .HasForeignKey(p => p.ProuctTypeId);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Product>()
            .HasOne(p => p.ProductType)          // One ProductType for each Product
            .WithMany()                          // One ProductType can be associated with many Products
            .HasForeignKey(p => p.ProuctTypeId);

            //Seed data for Brand

            modelBuilder.Entity<Brand>().HasData(
               new Brand { Id = 1, Name = "Brand A", Description = "Description for Brand A", LogoUrl = "http://example.com/logo1.png" },
               new Brand { Id = 2, Name = "Brand B", Description = "Description for Brand B", LogoUrl = "http://example.com/logo2.png" }
           );

           // Seed data for ProductType
           modelBuilder.Entity<ProductType>().HasData(
               new ProductType { Id = 1, Name = "Electronics", Description = "Electronics products" },
               new ProductType { Id = 2, Name = "Clothing", Description = "Clothing products" }
           );

            // Seed data for Product
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Description = "High performance laptop",
                    Price = 1200.99m,
                    StockQuantity = 50,
                    ProuctTypeId = 1, // Electronics
                    BrandId = 1 // Brand A
                },
                new Product
                {
                    Id = 2,
                    Name = "T-Shirt",
                    Description = "Comfortable cotton t-shirt",
                    Price = 19.99m,
                    StockQuantity = 200,
                    ProuctTypeId = 2, // Clothing
                    BrandId = 2 // Brand B
                }
            );
        }
    }
}
