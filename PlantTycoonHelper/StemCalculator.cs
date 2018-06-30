using PlantTycoon.Data;
using PlantTycoon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantTycoonHelper
{
    public class StemCalculator
    {
        public void InitializeEmptyStemResults()
        {
            var stemFormulas = CalculateAllOrderedStemFormulasWithEmptyResult();
            using (var dbContext = new PlantTycoonContext())
            {
                dbContext.StemFormulas.RemoveRange(dbContext.StemFormulas.Where(x => 1 == 1));
                dbContext.StemFormulas.AddRange(stemFormulas);
                dbContext.SaveChanges();
            }
        }

        public void SetStemFormula(StemType stemA, StemType stemB, StemType result)
        {
            this.SetStemFormula(stemA, stemB, result, false);
        }

        public void SetStemFormula(StemType stemA, StemType stemB, bool inProgress)
        {
            this.SetStemFormula(stemA, stemB, null, inProgress);
        }

        private void SetStemFormula(StemType stemA, StemType stemB, StemType? result, bool inProgress)
        {
            using (var dbContext = new PlantTycoonContext())
            {
                var stemFormulas = dbContext.StemFormulas.Where(x => x.StemA == stemA && x.StemB == stemB
                    || x.StemA == stemB && x.StemB == stemA);

                if (stemFormulas.Count() != 1)
                    throw new InvalidOperationException($"There should be one and only one formula for those two stems, but we found {stemFormulas.Count()}");

                stemFormulas.First().SetResultAndInProgress(result, inProgress);
                dbContext.SaveChanges();
            }
        }

        public List<StemFormula> CalculateAllOrderedStemFormulasWithEmptyResult()
        {
            var stemFormulas = new List<StemFormula>();

            var allStemTypeNamesOrdered = GetStemTypeNamesOrdered();
            allStemTypeNamesOrdered
                .ForEach(stemTypeNameA => GetStemTypeNamesOrderedGreaterThan(stemTypeNameA)
                    .ForEach(stemTypeNameB => stemFormulas.Add(StemFormula.CreateFromStemTypeNames(stemTypeNameA, stemTypeNameB))));

            return stemFormulas;
        }

        protected List<string> GetStemTypeNamesOrdered()
        {
            return Enum.GetNames(typeof(StemType)).OrderBy(x => x).ToList();
        }

        protected List<string> GetStemTypeNamesOrderedGreaterThan(string cutStemTypeName)
        {
            return Enum.GetNames(typeof(StemType)).OrderBy(x => x).Where(x => x.CompareTo(cutStemTypeName) > 0).ToList();
        }

        public List<StemFormula> ReportForStemType(StemType stemType)
        {
            using (var dbContext = new PlantTycoonContext())
            {
                var stemFormulas = dbContext.StemFormulas
                    .Where(x => x.StemA == stemType || x.StemB == stemType)
                    .OrderBy(x => x.StemA.ToString())
                    .ThenBy(x => x.StemB.ToString());
                return stemFormulas.ToList();
            }
        }
        public List<StemFormula> ReportAllOrdered()
        {
            using (var dbContext = new PlantTycoonContext())
            {
                var stemFormulas = dbContext.StemFormulas
                    .OrderBy(x => x.StemA.ToString())
                    .ThenBy(x => x.StemB.ToString());
                return stemFormulas.ToList();
            }
        }

        public List<StemFormula> ReportAllOrderedByResult()
        {
            using (var dbContext = new PlantTycoonContext())
            {
                var stemFormulas = dbContext.StemFormulas
                    .Where(x => x.Result != null)
                    .OrderBy(x => x.Result.ToString())
                    .ThenBy(x => x.StemA.ToString())
                    .ThenBy(x => x.StemB.ToString());
                return stemFormulas.ToList();
            }
        }

        public List<StemType?> ReportStemTypesWithNoFormula()
        {
            using (var dbContext = new PlantTycoonContext())
            {
                var stemTypes = Enum.GetValues(typeof(StemType)).Cast<StemType?>();
                var stemTypesWithFormula = dbContext.StemFormulas
                    .Where(x => x.Result != null)
                    .Select(x => x.Result)
                    .Distinct();

                var stemTypesWithNoFormula = stemTypes
                    .Except(stemTypesWithFormula);

                return stemTypesWithNoFormula.ToList();
            }
        }
    }
}
