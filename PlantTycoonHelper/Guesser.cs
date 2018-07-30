using PlantTycoon.Data;
using PlantTycoon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlantTycoonHelper
{
    public class Guesser
    {
        //public HashSet<Plant> PlantsFromSeedStorage { get; protected set; }

        public static List<Plant> CurrentPlants = new List<Plant>
        {
            new Plant(FlowerType.Venomous, StemType.Multiflora),
            new Plant(FlowerType.Spotted, StemType.Reptans),
            new Plant(FlowerType.Fabled, StemType.Ridgeball),
            new Plant(FlowerType.Aureus, StemType.Multiflora),
            new Plant(FlowerType.Lilia, StemType.Glaber),

            new Plant(FlowerType.Citrus, StemType.Weeper),
            new Plant(FlowerType.Blazing, StemType.Multiflora),
            new Plant(FlowerType.Fourpetal, StemType.Ridgeball),
            new Plant(FlowerType.Tilia, StemType.Fern),
            new Plant(FlowerType.Mela, StemType.Multiflora),

            new Plant(FlowerType.Venus, StemType.Pitcher),
            new Plant(FlowerType.Mela, StemType.Weeper),
            new Plant(FlowerType.Tilia, StemType.Glaber),
            new Plant(FlowerType.Blazing, StemType.Ridgeball),
            new Plant(FlowerType.Baccatus, StemType.Astera),


            new Plant(FlowerType.Blazing, StemType.Orchid),
            new Plant(FlowerType.Venus, StemType.Grass),
            new Plant(FlowerType.Painted, StemType.RareOak),
            new Plant(FlowerType.Citrus, StemType.Scandens),
            new Plant(FlowerType.Venomous, StemType.Scandens),
            new Plant(FlowerType.Tilia, StemType.Maranta),

            new Plant(FlowerType.Arthurium, StemType.Weeper),
            new Plant(FlowerType.Tilia, StemType.Gladiatus),
            new Plant(FlowerType.Aureus, StemType.Ridgeball),
            new Plant(FlowerType.Citrus, StemType.Multiflora),
            new Plant(FlowerType.Citrus, StemType.Ridgeball),
            new Plant(FlowerType.Venomous, StemType.Ridgeball),
            new Plant(FlowerType.Mela, StemType.Ridgeball),
            new Plant(FlowerType.Tilia, StemType.Astera),


            //new Plant(FlowerType.Arthurium, StemType.Multiflora),
            //new Plant(FlowerType.Arthurium, StemType.Ridgeball),
            //new Plant(FlowerType.Lilia, StemType.Weeper),
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
