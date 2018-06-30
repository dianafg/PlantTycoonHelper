using Microsoft.EntityFrameworkCore;
using PlantTycoon.Domain;

namespace PlantTycoon.Data
{
    public class PlantTycoonContext : DbContext
    {
        public DbSet<FlowerFormula> FlowerFormulas { get; set; }

        public DbSet<StemFormula> StemFormulas { get; set; }

        public DbSet<Seed> Seeds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=(localdb)\ProjectsV12;Initial Catalog=PlantTycoonHelper;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Seed>()
                .Ignore(x => x.Position);
        }
    }
}
