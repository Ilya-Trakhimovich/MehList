using DAL.EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EF.EFContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Mechanism> Mechanisms { get; set; }
        public DbSet<BuildingObject> BuildingObjects { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
