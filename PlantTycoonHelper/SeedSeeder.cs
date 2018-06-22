using PlantTycoon.Data;
using PlantTycoon.Domain;
using System;
using System.Linq;

namespace PlantTycoonHelper
{
    public class SeedStorageSeeder
    {
        private readonly SeedCalculator calculator;

        public SeedStorageSeeder(SeedCalculator seedCalculator)
        {
            this.calculator = seedCalculator;
        }

        public void Reseed()
        {
            calculator.SetSeed(Tuple.Create('A', 1, 1), FlowerType.Fourpetal, PlantType.Grass);
            calculator.SetSeed(Tuple.Create('A', 1, 2), FlowerType.Fourpetal, PlantType.Gladiatus);
            calculator.SetSeed(Tuple.Create('A', 1, 3), FlowerType.Rosaceae, PlantType.Bamboo);
            calculator.SetSeed(Tuple.Create('A', 1, 4), FlowerType.Arthurium, PlantType.Bamboo);
            calculator.SetSeed(Tuple.Create('A', 1, 5), FlowerType.Jalapa, PlantType.Fern);
            calculator.SetSeed(Tuple.Create('A', 1, 6), FlowerType.Bluestar, PlantType.Lemonbush);
            calculator.SetSeed(Tuple.Create('A', 1, 7), FlowerType.Rosaceae, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 1, 8), FlowerType.Jalapa, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 1, 9), FlowerType.Citrus, PlantType.RareOak);
            calculator.SetSeed(Tuple.Create('A', 1, 10), FlowerType.Bluestar, PlantType.Maranta);

            calculator.SetSeed(Tuple.Create('A', 2, 1), FlowerType.Fragrant, PlantType.Grass);
            calculator.SetSeed(Tuple.Create('A', 2, 2), FlowerType.Fragrant, PlantType.Gladiatus);
            calculator.SetSeed(Tuple.Create('A', 2, 3), FlowerType.Bluestar, PlantType.Bamboo);
            calculator.SetSeed(Tuple.Create('A', 2, 4), FlowerType.Mystic, PlantType.Bamboo);
            calculator.SetSeed(Tuple.Create('A', 2, 5), FlowerType.Fragrant, PlantType.Fern);
            calculator.SetSeed(Tuple.Create('A', 2, 6), FlowerType.Fragrant, PlantType.Lemonbush);
            calculator.SetSeed(Tuple.Create('A', 2, 7), FlowerType.Rosaceae, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 2, 8), FlowerType.Fabled, PlantType.RareOak);
            calculator.SetSeed(Tuple.Create('A', 2, 9), FlowerType.Rosaceae, PlantType.Maple);
            calculator.SetSeed(Tuple.Create('A', 2, 10), FlowerType.Jalapa, PlantType.Maranta);

            calculator.SetSeed(Tuple.Create('A', 3, 1), FlowerType.Arthurium, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 3, 2), FlowerType.Arthurium, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 3, 3), FlowerType.Arthurium, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 3, 4), FlowerType.Arthurium, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 3, 5), FlowerType.Arthurium, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 3, 6), FlowerType.Arthurium, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 3, 7), FlowerType.Arthurium, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 3, 8), FlowerType.Arthurium, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 3, 9), FlowerType.Arthurium, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 3, 10), FlowerType.Arthurium, PlantType.Ananas);

            calculator.SetSeed(Tuple.Create('A', 4, 1), FlowerType.Arthurium, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 4, 2), FlowerType.Arthurium, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 4, 3), FlowerType.Arthurium, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 4, 4), FlowerType.Arthurium, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 4, 5), FlowerType.Arthurium, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 4, 6), FlowerType.Arthurium, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 4, 7), FlowerType.Arthurium, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 4, 8), FlowerType.Arthurium, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 4, 9), FlowerType.Arthurium, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 4, 10), FlowerType.Arthurium, PlantType.Ananas);
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
