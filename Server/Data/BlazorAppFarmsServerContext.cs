using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorAppFarms.Shared.Models;
using Microsoft.Extensions.Options;

namespace BlazorAppFarms.Server.Data
{
    public class BlazorAppFarmsServerContext : DbContext
    {
        public BlazorAppFarmsServerContext (DbContextOptions<BlazorAppFarmsServerContext> options)
            : base(options)

        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlite(("Data Source=Animals.db") ?? throw new InvalidOperationException("Connection string 'BlazorAppFarmsServerContext' not found."));
        }

        public DbSet<BlazorAppFarms.Shared.Models.Animal> Animal { get; set; } = default!;
    }
}
