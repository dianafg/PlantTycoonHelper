using PlantTycoon.Data;
using PlantTycoon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantTycoonHelper
{
    public class FlowerCalculator
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
            this.SetFlowerFormula(flowerA, flowerB, result, false);
        }

        public void SetFlowerFormula(FlowerType flowerA, FlowerType flowerB, bool inProgress)
        {
            this.SetFlowerFormula(flowerA, flowerB, null, inProgress);
        }

        private void SetFlowerFormula(FlowerType flowerA, FlowerType flowerB, FlowerType? result, bool inProgress)
        {
            using (var dbContext = new PlantTycoonContext())
            {
                var flowerFormulas = dbContext.FlowerFormulas.Where(x => x.FlowerA == flowerA && x.FlowerB == flowerB
                    || x.FlowerA == flowerB && x.FlowerB == flowerA);

                if (flowerFormulas.Count() != 1)
                    throw new InvalidOperationException($"There should be one and only one formula for those two flowers, but we found {flowerFormulas.Count()}");

                flowerFormulas.First().SetResultAndInProgress(result, inProgress);
                dbContext.SaveChanges();
            }
        }

        public List<FlowerFormula> CalculateAllOrderedFlowerFormulasWithEmptyResult()
        {
            var flowerFormulas = new List<FlowerFormula>();

            var allFlowerTypeNamesOrdered = GetFlowerTypeNamesOrdered();
            allFlowerTypeNamesOrdered
                .ForEach(flowerTypeNameA => GetFlowerTypeNamesOrderedGreaterThan(flowerTypeNameA)
                    .ForEach(flowerTypeNameB => flowerFormulas.Add(FlowerFormula.CreateFromFlowerTypeNames(flowerTypeNameA, flowerTypeNameB))));

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

        public List<FlowerFormula> ReportForFlowerType(FlowerType flowerType)
        {
            using (var dbContext = new PlantTycoonContext())
            {
                var flowerFormulas = dbContext.FlowerFormulas
                    .Where(x => x.FlowerA == flowerType || x.FlowerB == flowerType)
                    .OrderBy(x => x.FlowerA.ToString())
                    .ThenBy(x => x.FlowerB.ToString());
                return flowerFormulas.ToList();
            }
        }

        public List<FlowerFormula> ReportAllOrdered()
        {
            using (var dbContext = new PlantTycoonContext())
            {
                var flowerFormulas = dbContext.FlowerFormulas
                    .OrderBy(x => x.FlowerA.ToString())
                    .ThenBy(x => x.FlowerB.ToString());
                return flowerFormulas.ToList();
            }
        }

        public List<FlowerFormula> ReportAllOrderedByResult()
        {
            using (var dbContext = new PlantTycoonContext())
            {
                var flowerFormulas = dbContext.FlowerFormulas
                    .Where(x => x.Result != null)
                    .OrderBy(x => x.Result.ToString())
                    .ThenBy(x => x.FlowerA.ToString())
                    .ThenBy(x => x.FlowerB.ToString());
                return flowerFormulas.ToList();
            }
        }

        public List<FlowerType?> ReportFlowerTypesWithNoFormula()
        {
            using (var dbContext = new PlantTycoonContext())
            {
                var flowerTypes = Enum.GetValues(typeof(FlowerType)).Cast<FlowerType?>();
                var flowerTypesWithFormula = dbContext.FlowerFormulas
                    .Where(x => x.Result != null)
                    .Select(x => x.Result)
                    .Distinct();

                var flowerTypesWithNoFormula = flowerTypes
                    .Except(flowerTypesWithFormula);

                return flowerTypesWithNoFormula.ToList();
            }
        }
    }
}
