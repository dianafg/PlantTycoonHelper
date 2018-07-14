using PlantTycoon.Data;
using PlantTycoon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantTycoonHelper
{
    public class PlantCalculator
    {
        protected PlantTycoonContext dbContext { get; set; }
        protected readonly PlantComparer plantComparer = new PlantComparer();
        protected readonly FormulaComparer formulaComparer = new FormulaComparer();
        protected readonly SeedComparer seedComparer = new SeedComparer();

        public IEnumerable<PlantFormula> FilterPlantFormulasOnlyBetweenCurrentPlants(IEnumerable<Plant> currentPlants, IEnumerable<PlantFormula> allFormulas)
        {
            return allFormulas.Where(x => currentPlants.Contains(x.PlantA, plantComparer) && currentPlants.Contains(x.PlantB, plantComparer));
        }

        public IEnumerable<Seed> GetSeedsOfUntestedPlants()
        {
            using (dbContext = new PlantTycoonContext())
            {
                var seedsOfTestedPlants = dbContext.Plants.Select(x => new Seed(Tuple.Create('A', 1, 1), x.Flower, x.Stem));
                var seedsInStorage = dbContext.Seeds.ToList();
                var seedsOfUntestedPlants = seedsInStorage.Except(seedsOfTestedPlants, seedComparer);
                return seedsOfUntestedPlants.ToList();
            }
        }

        public IEnumerable<PlantFormula> GetUntestedPlantFormulasForCurrentPlants(IEnumerable<Plant> currentPlants)
        {
            var formulas = new List<PlantFormula>();
            using (dbContext = new PlantTycoonContext())
            {
                currentPlants.ToList().ForEach(x => formulas.AddRange(GetUntestedPlantFormulasContainingPlant(x)));
            }
            var distinctFormulas = formulas.Distinct(formulaComparer);
            return distinctFormulas;
        }

        protected IEnumerable<PlantFormula> GetUntestedPlantFormulasContainingPlant(Plant plant)
        {
            var formulas = GetPlantFormulasContainingPlant(plant);
            var results = formulas.Select(x => x.Result).Distinct(plantComparer);
            var testedPlants = dbContext.Plants.ToList();
            var untestedResults = results.Except(testedPlants, plantComparer);
            var untestedFormulas = formulas.Where(x => untestedResults.Contains(x.Result, plantComparer));
            return untestedFormulas;
        }

        protected IEnumerable<PlantFormula> GetPlantFormulasContainingPlant(Plant plant)
        {
            var stemCalculator = new StemCalculator();
            var flowerCalculator = new FlowerCalculator();

            var allFlowerFormulasContainingPlant = dbContext.FlowerFormulas.Where(x => x.FlowerA == plant.Flower || x.FlowerB == plant.Flower).ToList();
            allFlowerFormulasContainingPlant.Add(new FlowerFormula(plant.Flower, plant.Flower, plant.Flower));
            var allStemFormulasContainingPlant = dbContext.StemFormulas.Where(x => x.StemA == plant.Stem || x.StemB == plant.Stem).ToList();
            allStemFormulasContainingPlant.Add(new StemFormula(plant.Stem, plant.Stem, plant.Stem));

            var formulas = allFlowerFormulasContainingPlant
                .SelectMany(x => allStemFormulasContainingPlant
                    .Select(y => new PlantFormula
                    {
                        PlantA = plant,
                        PlantB = new Plant(
                            (plant.Flower == x.FlowerA) ? x.FlowerB : x.FlowerA,
                            (plant.Stem == y.StemA) ? y.StemB : y.StemA,
                            false),
                        Result = new Plant(x.Result.Value, y.Result.Value, false)
                    }))
                    .OrderBy(x => x.PlantB.Flower)
                    .ThenBy(x => x.PlantB.Stem);

            return formulas.AsEnumerable();
        }
    }

    public class SeedComparer : IEqualityComparer<Seed>
    {
        public bool Equals(Seed x, Seed y)
        {
            return (x.Flower == y.Flower && x.Stem == y.Stem);
        }

        public int GetHashCode(Seed obj)
        {
            return $"{obj.Flower.ToString()}-{obj.Stem.ToString()}".GetHashCode();
        }
    }

    public class PlantComparer : IEqualityComparer<Plant>
    {
        public bool Equals(Plant x, Plant y)
        {
            return (x.Flower == y.Flower && x.Stem == y.Stem);
        }

        public int GetHashCode(Plant obj)
        {
            return $"{obj.Flower.ToString()}-{obj.Stem.ToString()}".GetHashCode();
        }
    }

    public class FormulaComparer : IEqualityComparer<PlantFormula>
    {
        public bool Equals(PlantFormula x, PlantFormula y)
        {
            return (x.PlantA == y.PlantA && x.PlantB == y.PlantB)
                || (x.PlantA == y.PlantB && x.PlantB == y.PlantA);
        }

        public int GetHashCode(PlantFormula obj)
        {
            return $"{obj.PlantA.Flower.ToString()}-{obj.PlantB.Flower.ToString()}-{obj.PlantA.Stem.ToString()}-{obj.PlantB.Stem.ToString()}".GetHashCode();
        }
    }

    public class PlantFormula
    {
        public Plant PlantA { get; set; }
        public Plant PlantB { get; set; }
        public Plant Result { get; set; }
    }
}

////var allFormulasForFlower = dbContext.FlowerFormulas
////    .Where(x => x.FlowerA == plant.Flower || x.FlowerB == plant.Flower)
////    .OrderBy(x => x.FlowerA)
////    .ThenBy(x => x.FlowerB)
////    .Select(x => x.Result);

////var allFormulasForStem = dbContext.StemFormulas
////    .Where(x => x.StemA == plant.Stem || x.StemB == plant.Stem)
////    .OrderBy(x => x.StemA)
////    .ThenBy(x => x.StemB)
////    .Select(x => x.Result);

//foreach (var currentPlant in currentPlants)
//{
//    var allFlowerCombinations =
//        dbContext.FlowerFormulas
//            .FirstOrDefault(formula =>
//               (formula.FlowerA == plant.Flower && formula.FlowerB == currentPlant.Flower)
//            || (formula.FlowerB == plant.Flower && formula.FlowerA == currentPlant.Flower));

//    var allStemCombinations =
//        dbContext.StemFormulas
//            .FirstOrDefault(formula =>
//               (formula.StemA == plant.Stem && formula.StemB == currentPlant.Stem)
//            || (formula.StemB == plant.Stem && formula.StemA == currentPlant.Stem));
//}


//var allFormulasForFlower = dbContext.FlowerFormulas
//    .Where((x => x.FlowerA == plant.Flower || x.FlowerB == plant.Flower)
//            && ( )
//    )
//    .
//    .OrderBy(x => x.FlowerA)
//    .ThenBy(x => x.FlowerB)
//    .Select(x => x.Result);

//var allFormulaCombinations = allFormulasForFlower.
//    SelectMany(flower => allFormulasForStem.Select(stem => new Plant(flower.Value, stem.Value, false)));
//    //aList.SelectMany(a => bList.Select(b => a + b))


//protected IEnumerable<PlantFormula> GetPlantFormulasContainingPlant(Plant plant)
//{
//    var stemCalculator = new StemCalculator();
//    var flowerCalculator = new FlowerCalculator();

//    var allFlowerFormulasContainingPlant = dbContext.FlowerFormulas.Where(x => x.FlowerA == plant.Flower || x.FlowerB == plant.Flower).ToList();
//    var allStemFormulasContainingPlant = dbContext.StemFormulas.Where(x => x.StemA == plant.Stem || x.StemB == plant.Stem).ToList();

//    var formulas = allFlowerFormulasContainingPlant
//        .SelectMany(x => allStemFormulasContainingPlant
//            .Select(y => new PlantFormula {
//                PlantA = new Plant(x.FlowerA, y.StemA, false),
//                PlantB = new Plant(x.FlowerB, y.StemB, false),
//                Result = new Plant(x.Result.Value, y.Result.Value, false)
//            }));

//    return formulas.AsEnumerable();
//}