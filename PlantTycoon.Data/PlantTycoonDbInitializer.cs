using Microsoft.EntityFrameworkCore;

namespace PlantTycoon.Data
{
    public static class PlantTycoonDbInitializer
    {
        public static void Initialize(PlantTycoonContext context)
        {
            context.Database.Migrate();
            context.SaveChanges();
        }
    }
}
