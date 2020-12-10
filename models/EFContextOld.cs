using Microsoft.EntityFrameworkCore;
using DiConsoleApp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Collections.Generic;
using DiConsoleApp.Services;

namespace DiConsoleApp.Models
{
    public class EFContextOLD : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var startup = new Startup();
            var connectionService = startup.Provider.GetRequiredService<IConnectionService>();
            optionsBuilder.UseNpgsql(connectionService.GetConnectionString());
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