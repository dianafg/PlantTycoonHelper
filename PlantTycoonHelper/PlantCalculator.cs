using PlantTycoon.Data;
using PlantTycoon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantTycoonHelper
{
    public class PlantCalculator
    {
        public void InitializeEmptyPlantResults()
        {
            var plantFormulas = CalculateAllOrderedPlantFormulasWithEmptyResult();
            using (var dbContext = new PlantTycoonContext())
            {
                dbContext.PlantFormulas.RemoveRange(dbContext.PlantFormulas.Where(x => 1 == 1));
                dbContext.PlantFormulas.AddRange(plantFormulas);
                dbContext.SaveChanges();
            }
        }

        public void SetPlantFormula(PlantType plantA, PlantType plantB, PlantType result)
        {
            using (var dbContext = new PlantTycoonContext())
            {
                var plantFormulas = dbContext.PlantFormulas.Where(x => x.PlantA == plantA && x.PlantB == plantB
                    || x.PlantA == plantB && x.PlantB == plantA);

                if (plantFormulas.Count() != 1)
                    throw new InvalidOperationException($"There should be one and only one formula for those two plants, but we found {plantFormulas.Count()}");

                plantFormulas.First().Result = result;
                dbContext.SaveChanges();
            }
        }

        public List<PlantFormula> CalculateAllOrderedPlantFormulasWithEmptyResult()
        {
            var plantFormulas = new List<PlantFormula>();

            var allPlantTypeNamesOrdered = GetPlantTypeNamesOrdered();
            allPlantTypeNamesOrdered
                .ForEach(plantTypeNameA => GetPlantTypeNamesOrderedGreaterThan(plantTypeNameA)
                    .ForEach(plantTypeNameB => plantFormulas.Add(PlantFormula.CreateFromPlantTypeNames(plantTypeNameA, plantTypeNameB))));

            return plantFormulas;
        }

        protected List<string> GetPlantTypeNamesOrdered()
        {
            return Enum.GetNames(typeof(PlantType)).OrderBy(x => x).ToList();
        }

        protected List<string> GetPlantTypeNamesOrderedGreaterThan(string cutPlantTypeName)
        {
            return Enum.GetNames(typeof(PlantType)).OrderBy(x => x).Where(x => x.CompareTo(cutPlantTypeName) > 0).ToList();
        }

        public List<PlantFormula> ReportForPlantType(PlantType plantType)
        {
            using (var dbContext = new PlantTycoonContext())
            {
                var plantFormulas = dbContext.PlantFormulas
                    .Where(x => x.PlantA == plantType || x.PlantB == plantType)
                    .OrderBy(x => x.PlantA.ToString())
                    .ThenBy(x => x.PlantB.ToString());
                return plantFormulas.ToList();
            }
        }
        public List<PlantFormula> ReportAllOrdered()
        {
            using (var dbContext = new PlantTycoonContext())
            {
                var plantFormulas = dbContext.PlantFormulas
                    .OrderBy(x => x.PlantA.ToString())
                    .ThenBy(x => x.PlantB.ToString());
                return plantFormulas.ToList();
            }
        }
    }
}
