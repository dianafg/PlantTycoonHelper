﻿using Microsoft.EntityFrameworkCore;
using PlantTycoon.Domain;

namespace PlantTycoonHelper
{
    public class PlantTycoonContext : DbContext
    {
        public DbSet<FlowerFormula> FlowerFormulas { get; set; }

        public DbSet<PlantFormula> PlantFormulas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=(localdb)\ProjectsV12;Initial Catalog=PlantTycoonHelper;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
            );
        }
    }
}
