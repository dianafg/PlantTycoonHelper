using PlantTycoon.Data;
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
            var flowerFormulas = CalculateAllOrderedFlowerFormulasWithEmptyResult();
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
                var flowerFormulas = dbContext.FlowerFormulas.Where(x => x.FlowerA == flowerA && x.FlowerB == flowerB
                    || x.FlowerA == flowerB && x.FlowerB == flowerA);

                if (flowerFormulas.Count() != 1)
                    throw new InvalidOperationException($"There should be one and only one formula for those two flowers, but we found {flowerFormulas.Count()}");

                flowerFormulas.First().Result = result;
                dbContext.SaveChanges();
            }
        }

        public List<FlowerFormula> CalculateAllOrderedFlowerFormulasWithEmptyResult()
        {
            var flowerFormulas = new List<FlowerFormula>();
            
            //foreach (var flowerTypeAName in Enum.GetNames(typeof(FlowerType)).OrderBy(x => x))
            //    foreach (var flowerTypeBName in Enum.GetNames(typeof(FlowerType)).OrderBy(x => x).Where(x => x.CompareTo(flowerTypeAName) > 0))
            //    {
            //        flowerFormulas.Add(new FlowerFormula((FlowerType)Enum.Parse(typeof(FlowerType), flowerTypeAName), 
            //            (FlowerType)Enum.Parse(typeof(FlowerType), flowerTypeBName)));
            //    }
            //return flowerFormulas;

            var allFlowerTypeNamesOrdered = GetFlowerTypeNamesOrdered();
            allFlowerTypeNamesOrdered
                .ForEach(flowerTypeNameA => GetFlowerTypeNamesOrderedGreaterThan(flowerTypeNameA)
                    .ForEach(flowerTypeNameB => flowerFormulas.Add(CreateFlowerFormulaFromFlowerTypeNames(flowerTypeNameA, flowerTypeNameB))));

            return flowerFormulas;
        }

        protected List<string> GetFlowerTypeNamesOrdered()
        {
            return Enum.GetNames(typeof(FlowerType)).OrderBy(x => x).ToList();
        }

        protected List<string> GetFlowerTypeNamesOrderedGreaterThan(string cutFlowerTypeName)
        {
            return Enum.GetNames(typeof(FlowerType)).OrderBy(x => x).Where(x => x.CompareTo(cutFlowerTypeName) > 0).ToList();
        }

        protected FlowerFormula CreateFlowerFormulaFromFlowerTypeNames(string flowerTypeNameA, string flowerTypeNameB)
        {
            var flowerTypeA = (FlowerType)Enum.Parse(typeof(FlowerType), flowerTypeNameA);
            var flowerTypeB = (FlowerType)Enum.Parse(typeof(FlowerType), flowerTypeNameB);
            return new FlowerFormula(flowerTypeA, flowerTypeB);
        }

        protected FlowerFormula CreateFlowerFormulaFromFlowerTypeNames(string flowerTypeNameA, string flowerTypeNameB, string flowerTypeNameResult)
        {
            var flowerTypeResult = (FlowerType)Enum.Parse(typeof(FlowerType), flowerTypeNameResult);
            var flowerFormula = CreateFlowerFormulaFromFlowerTypeNames(flowerTypeNameA, flowerTypeNameB);
            flowerFormula.Result = flowerTypeResult;
            return flowerFormula;
        }
    }
}
