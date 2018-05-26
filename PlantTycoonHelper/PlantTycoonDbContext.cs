using Microsoft.EntityFrameworkCore;
using PlantTycoon.Domain;

namespace PlantTycoonHelper
{
    public class PlantTycoonDbContext : DbContext
    {
        public DbSet<FlowerFormula> FlowerFormulas { get; set; }

        public DbSet<PlantFormula> PlantFormulas { get; set; }

        public PlantTycoonDbContext() : base()
        { }
    }
}
