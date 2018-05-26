using PlantTycoon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantTycoonHelper
{
    public class Calculator
    {
        public void InitializeEmptyFlowerResults()
        {
            var flowerFormulas = CalculateFlowers();
            using (var dbContext = new PlantTycoonContext())
            {
                dbContext.FlowerFormulas.RemoveRange(dbContext.FlowerFormulas.Where(x => 1 == 1));
                dbContext.FlowerFormulas.AddRange(flowerFormulas);
                dbContext.SaveChanges();
            }
        }

        public void SetFlowerFormula(FlowerType flowerA, FlowerType flowerB, FlowerType result)
        {
            using (var dbContext = new PlantTycoonContext())
            {
                var flowerFormula = dbContext.FlowerFormulas.First(x => x.FlowerA == flowerA && x.FlowerB == flowerB);
                flowerFormula.Result = result;
                dbContext.SaveChanges();
            }
        }

        public List<FlowerFormula> CalculateFlowers()
        {
            var flowerFormulas = new List<FlowerFormula>();
            foreach (var flowerTypeA in Enum.GetNames(typeof(FlowerType)).OrderBy(x => x))
                foreach (var flowerTypeB in Enum.GetNames(typeof(FlowerType)).OrderBy(x => x).Where(x => x.CompareTo(flowerTypeA) > 0))
                {
                    flowerFormulas.Add(new FlowerFormula((FlowerType)Enum.Parse(typeof(FlowerType), flowerTypeA), 
                        (FlowerType)Enum.Parse(typeof(FlowerType), flowerTypeB)));
                }
            return flowerFormulas;
        }

        public void CalculatePlants()
        { }
    }
}
