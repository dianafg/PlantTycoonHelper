using PlantTycoon.Data;
using PlantTycoon.Domain;
using System;
using System.Linq;

namespace PlantTycoonHelper
{
    public class SeedSeeder
    {
        private readonly SeedCalculator calculator;

        public SeedSeeder(SeedCalculator seedCalculator)
        {
            this.calculator = seedCalculator;
        }

        public void Reseed()
        {
            calculator.SetSeed(Tuple.Create('A', 1, 1), FlowerType.Arthurium, PlantType.Ananas);
        }
    }

    public class SeedCalculator
    {
        public void SetSeed(Tuple<char, int, int> position, FlowerType flower, PlantType plant)
        {
            using (var dbContext = new PlantTycoonContext())
            {
                //var seed = dbContext.Seeds.FirstOrDefault(x => x.Position == position);
                var seed = new Seed(position, flower, plant);
                dbContext.SaveChanges();
            }
        }

    }
}
