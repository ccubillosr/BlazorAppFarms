using System;
using System.Collections.Generic;
using BlazorAppFarms.Shared.Models;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using SQLitePCL;

namespace BlazorAppFarms.Shared.Data
{
    public class AnimalStoreContext : DbContext
    {
        public AnimalStoreContext(DbContextOptions<AnimalStoreContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorAppFarms.Shared.Models.Animal> Animals { get; set; } = default!;
    }

}
