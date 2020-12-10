using Microsoft.EntityFrameworkCore;
using DiConsoleApp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace DiConsoleApp.Models
{
    public class EFContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            optionsBuilder.UseNpgsql(configuration.GetConnectionString("Connectionstring"));
        }
 
        public DbSet<DiConsoleApp.Models.Product> Products { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
              modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.id);
            });
         }
 
    }
}