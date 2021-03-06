﻿using PlantTycoon.Data;
using PlantTycoon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantTycoonHelper
{
    public class SeedCalculator
    {
        public void InitializeEmptySeedStorage()
        {
            using (var dbContext = new PlantTycoonContext())
            {
                dbContext.Seeds.RemoveRange(dbContext.Seeds.Where(x => 1 == 1));
                dbContext.SaveChanges();
            }
        }

        public void SetSeed(Tuple<char, int, int> position, FlowerType flower, StemType stem)
        {
            using (var dbContext = new PlantTycoonContext())
            {
                //var seed = dbContext.Seeds.FirstOrDefault(x => x.Position == position);
                var seed = new Seed(position, flower, stem);
                dbContext.Seeds.Add(seed);
                dbContext.SaveChanges();
            }
        }

        public List<Seed> ReportSeeds()
        {
            using (var dbContext = new PlantTycoonContext())
            {
                var seeds = dbContext.Seeds
                    .OrderBy(x => x.Flower)
                    .ThenBy(x => x.Stem)
                    .ToList();
                return seeds;
            }
        }

        public List<Seed> ReportSeedsReverse()
        {
            using (var dbContext = new PlantTycoonContext())
            {
                var seeds = dbContext.Seeds
                    .OrderBy(x => x.Stem)
                    .ThenBy(x => x.Flower)
                    .ToList();
                return seeds;
            }
        }
    }
}
