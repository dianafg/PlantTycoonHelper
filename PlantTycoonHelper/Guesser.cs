using PlantTycoon.Data;
using PlantTycoon.Domain;
using System.Collections.Generic;
using System.Linq;

namespace PlantTycoonHelper
{
    public class Guesser
    {
        public static List<Plant> CurrentPlants = new List<Plant>
        {
            new Plant(FlowerType.Fabled, StemType.Reptans),
            new Plant(FlowerType.Spotted, StemType.Reptans),
            new Plant(FlowerType.Jalapa, StemType.Reptans),
            new Plant(FlowerType.Painted, StemType.RareOak),
            new Plant(FlowerType.Viola, StemType.Scandens),

            new Plant(FlowerType.Fourpetal, StemType.Reptans),
            new Plant(FlowerType.Bluestar, StemType.Reptans),
            new Plant(FlowerType.Fragrant, StemType.Scandens),
            new Plant(FlowerType.Rosaceae, StemType.Reptans),
            new Plant(FlowerType.Nox, StemType.Orchid),

            new Plant(FlowerType.Painted, StemType.Ridgeball),
            new Plant(FlowerType.Jalapa, StemType.Scandens),
            new Plant(FlowerType.Daisy, StemType.Grass),
            new Plant(FlowerType.Painted, StemType.Fanleaf),
            new Plant(FlowerType.Nox, StemType.Scandens),

            new Plant(FlowerType.Fragrant, StemType.Scandens),
            new Plant(FlowerType.Venus, StemType.Ridgeball),
            new Plant(FlowerType.Venus, StemType.Grass),
            new Plant(FlowerType.Citrus, StemType.Scandens),
            new Plant(FlowerType.Venomous, StemType.Scandens),
            new Plant(FlowerType.Tilia, StemType.Maranta),

            new Plant(FlowerType.Bluestar, StemType.Scandens),
            new Plant(FlowerType.Daisy, StemType.Scandens),
            new Plant(FlowerType.Mystic, StemType.Scandens),
            new Plant(FlowerType.Spotted, StemType.Astera),
            new Plant(FlowerType.Fragrant, StemType.Reptans),
            new Plant(FlowerType.Viola, StemType.Reptans),
            new Plant(FlowerType.Spotted, StemType.Fern),
            new Plant(FlowerType.Spotted, StemType.Grass),
            new Plant(FlowerType.Painted, StemType.TigerFern),
            new Plant(FlowerType.Painted, StemType.Pitcher),
            new Plant(FlowerType.Painted, StemType.Glaber),
            new Plant(FlowerType.Painted, StemType.BallCactus),
            new Plant(FlowerType.Painted, StemType.Weeper),
            new Plant(FlowerType.Painted, StemType.Multiflora),
            new Plant(FlowerType.Nox, StemType.Reptans),
            new Plant(FlowerType.Mystic, StemType.Reptans),
            new Plant(FlowerType.Daisy, StemType.Reptans),
            new Plant(FlowerType.Blazing, StemType.Reptans),
            new Plant(FlowerType.Painted, StemType.Scandens),
            new Plant(FlowerType.Spotted, StemType.Scandens),
            new Plant(FlowerType.Fragrant, StemType.Scandens),
            new Plant(FlowerType.Blazing, StemType.Scandens),
            new Plant(FlowerType.Fourpetal, StemType.Scandens),
            new Plant(FlowerType.Painted, StemType.Reptans),
            new Plant(FlowerType.Nox, StemType.BallCactus),
            new Plant(FlowerType.Aureus, StemType.Scandens),

            new Plant(FlowerType.Fourpetal, StemType.Scandens),
            new Plant(FlowerType.Painted, StemType.Reptans),
            new Plant(FlowerType.Daisy, StemType.Scandens),
            new Plant(FlowerType.Painted, StemType.Scandens),

            //Bought:
            //14 -> Scandens
        };

        public static IEnumerable<Plant> GetPlantsFromSeedStorage()
        {
            using (var dbContext = new PlantTycoonContext())
            {
                var seedsInStorage = dbContext.Seeds.ToList().Distinct(new SeedComparer());
                var plantsFromSeeds = seedsInStorage.Select(x => new Plant(x.Flower, x.Stem));
                return plantsFromSeeds;
            }
        }

            //new Plant(FlowerType.Tahitian, StemType.PipeCactus),
            //new Plant(FlowerType.Fourpetal, StemType.TigerFern),
            //new Plant(FlowerType.Rosaceae, StemType.Bamboo),
            //new Plant(FlowerType.Arthurium, StemType.Bamboo),
            //new Plant(FlowerType.Jalapa, StemType.Fern),
            //new Plant(FlowerType.Bluestar, StemType.Lemonbush),
            //new Plant(FlowerType.Viola, StemType.BallCactus),
            //new Plant(FlowerType.Fragrant, StemType.Multiflora),
            //new Plant(FlowerType.Citrus, StemType.RareOak),
            //new Plant(FlowerType.Bluestar, StemType.Maranta),

            //new Plant(FlowerType.Venomous, StemType.Lemonbush),
            //new Plant(FlowerType.Fragrant, StemType.Gladiatus),
            //new Plant(FlowerType.Bluestar, StemType.Bamboo),
            //new Plant(FlowerType.Mystic, StemType.Bamboo),
            //new Plant(FlowerType.Fragrant, StemType.Fern),
            //new Plant(FlowerType.Fragrant, StemType.Lemonbush),
            //new Plant(FlowerType.Rosaceae, StemType.Ananas),
            //new Plant(FlowerType.Fabled, StemType.RareOak),
            //new Plant(FlowerType.Rosaceae, StemType.Maple),
            //new Plant(FlowerType.Jalapa, StemType.Maranta),

            //new Plant(FlowerType.Viola, StemType.Grass),
            //new Plant(FlowerType.Viola, StemType.Gladiatus),
            //new Plant(FlowerType.Jalapa, StemType.Bamboo),
            //new Plant(FlowerType.Viola, StemType.Bamboo),
            //new Plant(FlowerType.Fragrant, StemType.Fern),
            //new Plant(FlowerType.Aureus, StemType.Scandens),
            //new Plant(FlowerType.Jalapa, StemType.Ananas),
            //new Plant(FlowerType.Blazing, StemType.RareOak),
            //new Plant(FlowerType.Rosaceae, StemType.Maranta),
            //new Plant(FlowerType.Viola, StemType.Maranta),
    }
}
