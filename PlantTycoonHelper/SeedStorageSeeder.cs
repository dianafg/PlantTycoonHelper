using PlantTycoon.Domain;
using System;

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
            calculator.InitializeEmptySeedStorage();
                
            calculator.SetSeed(Tuple.Create('A', 1, 1), FlowerType.Tahitian, StemType.PipeCactus);
            calculator.SetSeed(Tuple.Create('A', 1, 2), FlowerType.Fourpetal, StemType.TigerFern);
            calculator.SetSeed(Tuple.Create('A', 1, 3), FlowerType.Rosaceae, StemType.Bamboo);
            calculator.SetSeed(Tuple.Create('A', 1, 4), FlowerType.Arthurium, StemType.Bamboo);
            calculator.SetSeed(Tuple.Create('A', 1, 5), FlowerType.Jalapa, StemType.Fern);
            calculator.SetSeed(Tuple.Create('A', 1, 6), FlowerType.Bluestar, StemType.Lemonbush);
            calculator.SetSeed(Tuple.Create('A', 1, 7), FlowerType.Rosaceae, StemType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 1, 8), FlowerType.Jalapa, StemType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 1, 9), FlowerType.Citrus, StemType.RareOak);
            calculator.SetSeed(Tuple.Create('A', 1, 10), FlowerType.Bluestar, StemType.Maranta);

            calculator.SetSeed(Tuple.Create('A', 2, 1), FlowerType.Venomous, StemType.Lemonbush);
            calculator.SetSeed(Tuple.Create('A', 2, 2), FlowerType.Fragrant, StemType.Gladiatus);
            calculator.SetSeed(Tuple.Create('A', 2, 3), FlowerType.Bluestar, StemType.Bamboo);
            calculator.SetSeed(Tuple.Create('A', 2, 4), FlowerType.Mystic, StemType.Bamboo);
            calculator.SetSeed(Tuple.Create('A', 2, 5), FlowerType.Fragrant, StemType.Fern);
            calculator.SetSeed(Tuple.Create('A', 2, 6), FlowerType.Fragrant, StemType.Lemonbush);
            calculator.SetSeed(Tuple.Create('A', 2, 7), FlowerType.Rosaceae, StemType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 2, 8), FlowerType.Fabled, StemType.RareOak);
            calculator.SetSeed(Tuple.Create('A', 2, 9), FlowerType.Rosaceae, StemType.Maple);
            calculator.SetSeed(Tuple.Create('A', 2, 10), FlowerType.Jalapa, StemType.Maranta);

            calculator.SetSeed(Tuple.Create('A', 3, 1), FlowerType.Viola, StemType.Grass);
            calculator.SetSeed(Tuple.Create('A', 3, 2), FlowerType.Viola, StemType.Gladiatus);
            calculator.SetSeed(Tuple.Create('A', 3, 3), FlowerType.Jalapa, StemType.Bamboo);
            calculator.SetSeed(Tuple.Create('A', 3, 4), FlowerType.Viola, StemType.Bamboo);
            calculator.SetSeed(Tuple.Create('A', 3, 5), FlowerType.Fragrant, StemType.Fern);
            calculator.SetSeed(Tuple.Create('A', 3, 6), FlowerType.Citrus, StemType.PipeCactus);
            calculator.SetSeed(Tuple.Create('A', 3, 7), FlowerType.Jalapa, StemType.Ananas);
            calculator.SetSeed(Tuple.Create('A', 3, 8), FlowerType.Blazing, StemType.RareOak);
            calculator.SetSeed(Tuple.Create('A', 3, 9), FlowerType.Rosaceae, StemType.Maranta);
            calculator.SetSeed(Tuple.Create('A', 3, 10), FlowerType.Viola, StemType.Maranta);

            calculator.SetSeed(Tuple.Create('A', 4, 1), FlowerType.Blazing, StemType.Grass);
            calculator.SetSeed(Tuple.Create('A', 4, 2), FlowerType.Aureus, StemType.Gladiatus);
            calculator.SetSeed(Tuple.Create('A', 4, 3), FlowerType.Mystic, StemType.Fanleaf);
            calculator.SetSeed(Tuple.Create('A', 4, 4), FlowerType.Fabled, StemType.Bamboo);
            calculator.SetSeed(Tuple.Create('A', 4, 5), FlowerType.Aureus, StemType.Bamboo);
            calculator.SetSeed(Tuple.Create('A', 4, 6), FlowerType.Viola, StemType.Fern);
            calculator.SetSeed(Tuple.Create('A', 4, 7), 0, 0);
            calculator.SetSeed(Tuple.Create('A', 4, 8), FlowerType.Venus, StemType.RareOak);
            calculator.SetSeed(Tuple.Create('A', 4, 9), FlowerType.Rosaceae, StemType.Lemonbush);
            calculator.SetSeed(Tuple.Create('A', 4, 10), FlowerType.Blazing, StemType.Maranta);



            calculator.SetSeed(Tuple.Create('B', 1, 1), FlowerType.Venus, StemType.Glaber);
            calculator.SetSeed(Tuple.Create('B', 1, 2), FlowerType.Fabled, StemType.Lemonbush);
            calculator.SetSeed(Tuple.Create('B', 1, 3), FlowerType.Baccatus, StemType.Orchid);
            calculator.SetSeed(Tuple.Create('B', 1, 4), FlowerType.Jalapa, StemType.Astera);
            calculator.SetSeed(Tuple.Create('B', 1, 5), FlowerType.Lilia, StemType.Pitcher);
            calculator.SetSeed(Tuple.Create('B', 1, 6), FlowerType.Blazing, StemType.PearCactus);
            calculator.SetSeed(Tuple.Create('B', 1, 7), FlowerType.Bluestar, StemType.Maple);
            calculator.SetSeed(Tuple.Create('B', 1, 8), FlowerType.Venus, StemType.TigerFern);
            calculator.SetSeed(Tuple.Create('B', 1, 9), FlowerType.Painted, StemType.PearCactus);
            calculator.SetSeed(Tuple.Create('B', 1, 10), FlowerType.Daisy, StemType.Lemonbush);

            calculator.SetSeed(Tuple.Create('B', 2, 1), FlowerType.Venus, StemType.Glaber);
            calculator.SetSeed(Tuple.Create('B', 2, 2), FlowerType.Fabled, StemType.Lemonbush);
            calculator.SetSeed(Tuple.Create('B', 2, 3), FlowerType.Baccatus, StemType.Orchid);
            calculator.SetSeed(Tuple.Create('B', 2, 4), FlowerType.Jalapa, StemType.Astera);
            calculator.SetSeed(Tuple.Create('B', 2, 5), FlowerType.Fragrant, StemType.Fanleaf);
            calculator.SetSeed(Tuple.Create('B', 2, 6), FlowerType.Mela, StemType.PearCactus);
            calculator.SetSeed(Tuple.Create('B', 2, 7), FlowerType.Mela, StemType.BallCactus);
            calculator.SetSeed(Tuple.Create('B', 2, 8), FlowerType.Fragrant, StemType.Bamboo);
            calculator.SetSeed(Tuple.Create('B', 2, 9), FlowerType.Arthurium, StemType.PipeCactus);
            calculator.SetSeed(Tuple.Create('B', 2, 10), FlowerType.Viola, StemType.Astera);

            calculator.SetSeed(Tuple.Create('B', 3, 1), FlowerType.Rosaceae, StemType.Fern);
            calculator.SetSeed(Tuple.Create('B', 3, 2), FlowerType.Tahitian, StemType.Weeper);
            calculator.SetSeed(Tuple.Create('B', 3, 3), FlowerType.Painted, StemType.Ridgeball);
            calculator.SetSeed(Tuple.Create('B', 3, 4), FlowerType.Fabled, StemType.Astera);
            calculator.SetSeed(Tuple.Create('B', 3, 5), FlowerType.Aureus, StemType.Orchid);
            calculator.SetSeed(Tuple.Create('B', 3, 6), FlowerType.Fragrant, StemType.PipeCactus);
            calculator.SetSeed(Tuple.Create('B', 3, 7), FlowerType.Jalapa, StemType.PipeCactus);
            calculator.SetSeed(Tuple.Create('B', 3, 8), FlowerType.Venomous, StemType.Bamboo);
            calculator.SetSeed(Tuple.Create('B', 3, 9), FlowerType.Citrus, StemType.Ananas);
            calculator.SetSeed(Tuple.Create('B', 3, 10), FlowerType.Blazing, StemType.Ananas);

            calculator.SetSeed(Tuple.Create('B', 4, 1), FlowerType.Rosaceae, StemType.Fern);
            calculator.SetSeed(Tuple.Create('B', 4, 2), FlowerType.Tahitian, StemType.Weeper);
            calculator.SetSeed(Tuple.Create('B', 4, 3), FlowerType.Rosaceae, StemType.BallCactus);
            calculator.SetSeed(Tuple.Create('B', 4, 4), FlowerType.Tahitian, StemType.Glaber);
            calculator.SetSeed(Tuple.Create('B', 4, 5), FlowerType.Blazing, StemType.Glaber);
            calculator.SetSeed(Tuple.Create('B', 4, 6), FlowerType.Fourpetal, StemType.BallCactus);
            calculator.SetSeed(Tuple.Create('B', 4, 7), FlowerType.Jalapa, StemType.BallCactus);
            calculator.SetSeed(Tuple.Create('B', 4, 8), FlowerType.Arthurium, StemType.PipeCactus);
            calculator.SetSeed(Tuple.Create('B', 4, 9), FlowerType.Mela, StemType.Glaber);
            calculator.SetSeed(Tuple.Create('B', 4, 10), FlowerType.Arthurium, StemType.PearCactus);



            calculator.SetSeed(Tuple.Create('C', 1, 1), FlowerType.Aureus, StemType.TigerFern);
            calculator.SetSeed(Tuple.Create('C', 1, 2), FlowerType.Blazing, StemType.Fanleaf);
            calculator.SetSeed(Tuple.Create('C', 1, 3), FlowerType.Fabled, StemType.Gladiatus);
            calculator.SetSeed(Tuple.Create('C', 1, 4), FlowerType.Viola, StemType.Scandens);
            calculator.SetSeed(Tuple.Create('C', 1, 5), FlowerType.Citrus, StemType.Grass);
            calculator.SetSeed(Tuple.Create('C', 1, 6), FlowerType.Bluestar, StemType.Reptans);
            calculator.SetSeed(Tuple.Create('C', 1, 7), FlowerType.Painted, StemType.Maple);
            calculator.SetSeed(Tuple.Create('C', 1, 8), FlowerType.Blazing, StemType.Weeper);
            calculator.SetSeed(Tuple.Create('C', 1, 9), FlowerType.Baccatus, StemType.Glaber);
            calculator.SetSeed(Tuple.Create('C', 1, 10), FlowerType.Mela, StemType.RareOak);

            calculator.SetSeed(Tuple.Create('C', 2, 1), FlowerType.Aureus, StemType.TigerFern);
            calculator.SetSeed(Tuple.Create('C', 2, 2), FlowerType.Blazing, StemType.Fanleaf);
            calculator.SetSeed(Tuple.Create('C', 2, 3), FlowerType.Fabled, StemType.Gladiatus);
            calculator.SetSeed(Tuple.Create('C', 2, 4), FlowerType.Viola, StemType.Pitcher);
            calculator.SetSeed(Tuple.Create('C', 2, 5), FlowerType.Citrus, StemType.Grass);
            calculator.SetSeed(Tuple.Create('C', 2, 6), FlowerType.Viola, StemType.PearCactus);
            calculator.SetSeed(Tuple.Create('C', 2, 7), FlowerType.Venomous, StemType.Maple);
            calculator.SetSeed(Tuple.Create('C', 2, 8), FlowerType.Tahitian, StemType.Weeper);
            calculator.SetSeed(Tuple.Create('C', 2, 9), FlowerType.Baccatus, StemType.Glaber);
            calculator.SetSeed(Tuple.Create('C', 2, 10), FlowerType.Mela, StemType.RareOak);

            calculator.SetSeed(Tuple.Create('C', 3, 1), FlowerType.Aureus, StemType.Astera);
            calculator.SetSeed(Tuple.Create('C', 3, 2), FlowerType.Arthurium, StemType.BallCactus);
            calculator.SetSeed(Tuple.Create('C', 3, 3), FlowerType.Daisy, StemType.PipeCactus);
            calculator.SetSeed(Tuple.Create('C', 3, 4), FlowerType.Mystic, StemType.Lemonbush);
            calculator.SetSeed(Tuple.Create('C', 3, 5), FlowerType.Tilia, StemType.PearCactus);
            calculator.SetSeed(Tuple.Create('C', 3, 6), FlowerType.Spotted, StemType.Maranta);
            calculator.SetSeed(Tuple.Create('C', 3, 7), FlowerType.Fourpetal, StemType.Maple);
            calculator.SetSeed(Tuple.Create('C', 3, 8), FlowerType.Nox, StemType.Bamboo);
            calculator.SetSeed(Tuple.Create('C', 3, 9), FlowerType.Lilia, StemType.Multiflora);
            calculator.SetSeed(Tuple.Create('C', 3, 10), FlowerType.Tahitian, StemType.Pitcher);

            calculator.SetSeed(Tuple.Create('C', 4, 1), FlowerType.Aureus, StemType.Astera);
            calculator.SetSeed(Tuple.Create('C', 4, 2), FlowerType.Arthurium, StemType.BallCactus);
            calculator.SetSeed(Tuple.Create('C', 4, 3), FlowerType.Daisy, StemType.PipeCactus);
            calculator.SetSeed(Tuple.Create('C', 4, 4), FlowerType.Mystic, StemType.Lemonbush);
            calculator.SetSeed(Tuple.Create('C', 4, 5), FlowerType.Jalapa, StemType.Weeper);
            calculator.SetSeed(Tuple.Create('C', 4, 6), FlowerType.Spotted, StemType.Maranta);
            calculator.SetSeed(Tuple.Create('C', 4, 7), FlowerType.Jalapa, StemType.Weeper);
            calculator.SetSeed(Tuple.Create('C', 4, 8), FlowerType.Nox, StemType.Bamboo);
            calculator.SetSeed(Tuple.Create('C', 4, 9), FlowerType.Citrus, StemType.Multiflora);
            calculator.SetSeed(Tuple.Create('C', 4, 10), FlowerType.Tahitian, StemType.Pitcher);
        }
    }
}
