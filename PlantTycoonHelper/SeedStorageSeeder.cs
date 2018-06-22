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

            calculator.SetSeed(Tuple.Create('A', 3, 1), FlowerType.Viola, PlantType.Grass);
            calculator.SetSeed(Tuple.Create('A', 3, 2), FlowerType.Viola, PlantType.Gladiatus);
            calculator.SetSeed(Tuple.Create('A', 3, 3), FlowerType.Jalapa, PlantType.Bamboo);
            calculator.SetSeed(Tuple.Create('A', 3, 4), FlowerType.Viola, PlantType.Bamboo);
            calculator.SetSeed(Tuple.Create('A', 3, 5), FlowerType.Fragrant, PlantType.Fern);
            calculator.SetSeed(Tuple.Create('A', 3, 6), FlowerType.Mystic, PlantType.Lemonbush);
            calculator.SetSeed(Tuple.Create('A', 3, 7), FlowerType.Jalapa, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 3, 8), FlowerType.Blazing, PlantType.RareOak);
            calculator.SetSeed(Tuple.Create('A', 3, 9), FlowerType.Rosaceae, PlantType.Maranta);
            calculator.SetSeed(Tuple.Create('A', 3, 10), FlowerType.Viola, PlantType.Maranta);

            calculator.SetSeed(Tuple.Create('A', 4, 1), FlowerType.Blazing, PlantType.Grass);
            calculator.SetSeed(Tuple.Create('A', 4, 2), FlowerType.Aureus, PlantType.Gladiatus);
            calculator.SetSeed(Tuple.Create('A', 4, 3), FlowerType.Mystic, PlantType.Fanleaf);
            calculator.SetSeed(Tuple.Create('A', 4, 4), FlowerType.Fabled, PlantType.Bamboo);
            calculator.SetSeed(Tuple.Create('A', 4, 5), FlowerType.Viola, PlantType.Fern);
            calculator.SetSeed(Tuple.Create('A', 4, 6), FlowerType.Viola, PlantType.Fern);
            calculator.SetSeed(Tuple.Create('A', 4, 7), FlowerType.Fabled, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 4, 8), FlowerType.Venus, PlantType.RareOak);
            calculator.SetSeed(Tuple.Create('A', 4, 9), FlowerType.Rosaceae, PlantType.Maranta);
            calculator.SetSeed(Tuple.Create('A', 4, 10), FlowerType.Blazing, PlantType.Maranta);



            calculator.SetSeed(Tuple.Create('B', 1, 1), FlowerType.Venus, PlantType.Glaber);
            calculator.SetSeed(Tuple.Create('B', 1, 2), FlowerType.Fabled, PlantType.Lemonbush);
            calculator.SetSeed(Tuple.Create('B', 1, 3), FlowerType.Baccatus, PlantType.Orchid);
            calculator.SetSeed(Tuple.Create('B', 1, 4), FlowerType.Jalapa, PlantType.Astera);
            calculator.SetSeed(Tuple.Create('B', 1, 5), FlowerType.Lilia, PlantType.Pitcher);
            calculator.SetSeed(Tuple.Create('B', 1, 6), FlowerType.Blazing, PlantType.PearCactus);
            calculator.SetSeed(Tuple.Create('B', 1, 7), FlowerType.Bluestar, PlantType.Maple);
            calculator.SetSeed(Tuple.Create('B', 1, 8), FlowerType.Venus, PlantType.TigerFern);
            calculator.SetSeed(Tuple.Create('B', 1, 9), FlowerType.Mela, PlantType.Fanleaf);
            calculator.SetSeed(Tuple.Create('B', 1, 10), FlowerType.Fourpetal, PlantType.Maple);

            calculator.SetSeed(Tuple.Create('B', 2, 1), FlowerType.Venus, PlantType.Glaber);
            calculator.SetSeed(Tuple.Create('B', 2, 2), FlowerType.Fabled, PlantType.Lemonbush);
            calculator.SetSeed(Tuple.Create('B', 2, 3), FlowerType.Baccatus, PlantType.Orchid);
            calculator.SetSeed(Tuple.Create('B', 2, 4), FlowerType.Jalapa, PlantType.Astera);
            calculator.SetSeed(Tuple.Create('B', 2, 5), FlowerType.Fabled, PlantType.Orchid);
            calculator.SetSeed(Tuple.Create('B', 2, 6), FlowerType.Mela, PlantType.PearCactus);
            calculator.SetSeed(Tuple.Create('B', 2, 7), FlowerType.Bluestar, PlantType.Maple);
            calculator.SetSeed(Tuple.Create('B', 2, 8), FlowerType.Viola, PlantType.Maranta);
            calculator.SetSeed(Tuple.Create('B', 2, 9), FlowerType.Mela, PlantType.RareOak);
            calculator.SetSeed(Tuple.Create('B', 2, 10), FlowerType.Viola, PlantType.Astera);

            calculator.SetSeed(Tuple.Create('B', 3, 1), FlowerType.Rosaceae, PlantType.Fern);
            calculator.SetSeed(Tuple.Create('B', 3, 2), FlowerType.Blazing, PlantType.Weeper);
            calculator.SetSeed(Tuple.Create('B', 3, 3), FlowerType.Fourpetal, PlantType.TigerFern);
            calculator.SetSeed(Tuple.Create('B', 3, 4), FlowerType.Fabled, PlantType.Astera);
            calculator.SetSeed(Tuple.Create('B', 3, 5), FlowerType.Aureus, PlantType.Orchid);
            calculator.SetSeed(Tuple.Create('B', 3, 6), FlowerType.Fragrant, PlantType.PipeCactus);
            calculator.SetSeed(Tuple.Create('B', 3, 7), FlowerType.Jalapa, PlantType.PipeCactus);
            calculator.SetSeed(Tuple.Create('B', 3, 8), FlowerType.Tahitian, PlantType.PearCactus);
            calculator.SetSeed(Tuple.Create('B', 3, 9), FlowerType.Citrus, PlantType.Ananas);
            calculator.SetSeed(Tuple.Create('B', 3, 10), FlowerType.Blazing, PlantType.Ananas);

            calculator.SetSeed(Tuple.Create('B', 4, 1), FlowerType.Rosaceae, PlantType.Fern);
            calculator.SetSeed(Tuple.Create('B', 4, 2), FlowerType.Blazing, PlantType.Weeper);
            calculator.SetSeed(Tuple.Create('B', 4, 3), FlowerType.Jalapa, PlantType.Orchid);
            calculator.SetSeed(Tuple.Create('B', 4, 4), FlowerType.Tahitian, PlantType.Glaber);
            calculator.SetSeed(Tuple.Create('B', 4, 5), FlowerType.Blazing, PlantType.Glaber);
            calculator.SetSeed(Tuple.Create('B', 4, 6), FlowerType.Fourpetal, PlantType.BallCactus);
            calculator.SetSeed(Tuple.Create('B', 4, 7), FlowerType.Jalapa, PlantType.BallCactus);
            calculator.SetSeed(Tuple.Create('B', 4, 8), FlowerType.Arthurium, PlantType.PipeCactus);
            calculator.SetSeed(Tuple.Create('B', 4, 9), FlowerType.Mela, PlantType.Glaber);
            calculator.SetSeed(Tuple.Create('B', 4, 10), FlowerType.Jalapa, PlantType.Fern);



            calculator.SetSeed(Tuple.Create('C', 1, 1), FlowerType.Aureus, PlantType.TigerFern);
            calculator.SetSeed(Tuple.Create('C', 1, 2), FlowerType.Blazing, PlantType.Fanleaf);
            calculator.SetSeed(Tuple.Create('C', 1, 3), FlowerType.Fabled, PlantType.Gladiatus);
            calculator.SetSeed(Tuple.Create('C', 1, 4), FlowerType.Viola, PlantType.Scandens);
            calculator.SetSeed(Tuple.Create('C', 1, 5), FlowerType.Citrus, PlantType.Grass);
            calculator.SetSeed(Tuple.Create('C', 1, 6), FlowerType.Bluestar, PlantType.Reptans);
            calculator.SetSeed(Tuple.Create('C', 1, 7), FlowerType.Painted, PlantType.Maple);
            calculator.SetSeed(Tuple.Create('C', 1, 8), FlowerType.Fourpetal, PlantType.Maple);
            calculator.SetSeed(Tuple.Create('C', 1, 9), FlowerType.Baccatus, PlantType.Glaber);
            calculator.SetSeed(Tuple.Create('C', 1, 10), FlowerType.Mela, PlantType.RareOak);

            calculator.SetSeed(Tuple.Create('C', 2, 1), FlowerType.Aureus, PlantType.TigerFern);
            calculator.SetSeed(Tuple.Create('C', 2, 2), FlowerType.Blazing, PlantType.Fanleaf);
            calculator.SetSeed(Tuple.Create('C', 2, 3), FlowerType.Fabled, PlantType.Gladiatus);
            calculator.SetSeed(Tuple.Create('C', 2, 4), FlowerType.Viola, PlantType.Scandens);
            calculator.SetSeed(Tuple.Create('C', 2, 5), FlowerType.Citrus, PlantType.Grass);
            calculator.SetSeed(Tuple.Create('C', 2, 6), FlowerType.Bluestar, PlantType.Reptans);
            calculator.SetSeed(Tuple.Create('C', 2, 7), FlowerType.Painted, PlantType.Maple);
            calculator.SetSeed(Tuple.Create('C', 2, 8), FlowerType.Fourpetal, PlantType.Maple);
            calculator.SetSeed(Tuple.Create('C', 2, 9), FlowerType.Baccatus, PlantType.Glaber);
            calculator.SetSeed(Tuple.Create('C', 2, 10), FlowerType.Mela, PlantType.RareOak);

            calculator.SetSeed(Tuple.Create('C', 3, 1), FlowerType.Aureus, PlantType.Astera);
            calculator.SetSeed(Tuple.Create('C', 3, 2), FlowerType.Arthurium, PlantType.BallCactus);
            calculator.SetSeed(Tuple.Create('C', 3, 3), FlowerType.Daisy, PlantType.PipeCactus);
            calculator.SetSeed(Tuple.Create('C', 3, 4), FlowerType.Mystic, PlantType.Lemonbush);
            calculator.SetSeed(Tuple.Create('C', 3, 5), FlowerType.Tilia, PlantType.PearCactus);
            calculator.SetSeed(Tuple.Create('C', 3, 6), FlowerType.Spotted, PlantType.Maranta);
            calculator.SetSeed(Tuple.Create('C', 3, 7), FlowerType.Venomous, PlantType.Maple);
            calculator.SetSeed(Tuple.Create('C', 3, 8), FlowerType.Nox, PlantType.Bamboo);
            calculator.SetSeed(Tuple.Create('C', 3, 9), FlowerType.Lilia, PlantType.Multiflora);
            calculator.SetSeed(Tuple.Create('C', 3, 10), FlowerType.Tahitian, PlantType.Pitcher);

            calculator.SetSeed(Tuple.Create('C', 4, 1), FlowerType.Aureus, PlantType.Astera);
            calculator.SetSeed(Tuple.Create('C', 4, 2), FlowerType.Arthurium, PlantType.BallCactus);
            calculator.SetSeed(Tuple.Create('C', 4, 3), FlowerType.Daisy, PlantType.PipeCactus);
            calculator.SetSeed(Tuple.Create('C', 4, 4), FlowerType.Mystic, PlantType.Lemonbush);
            calculator.SetSeed(Tuple.Create('C', 4, 5), FlowerType.Tilia, PlantType.PearCactus);
            calculator.SetSeed(Tuple.Create('C', 4, 6), FlowerType.Spotted, PlantType.Maranta);
            calculator.SetSeed(Tuple.Create('C', 4, 7), FlowerType.Venomous, PlantType.Maple);
            calculator.SetSeed(Tuple.Create('C', 4, 8), FlowerType.Nox, PlantType.Bamboo);
            calculator.SetSeed(Tuple.Create('C', 4, 9), FlowerType.Lilia, PlantType.Multiflora);
            calculator.SetSeed(Tuple.Create('C', 4, 10), FlowerType.Tahitian, PlantType.Pitcher);
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
