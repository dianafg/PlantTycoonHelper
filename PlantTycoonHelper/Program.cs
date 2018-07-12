using PlantTycoon.Data;
using PlantTycoon.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//To publish as exe instead of dll:
//dotnet.exe publish -c Debug -r win-x64 -f netcoreapp2.0
//dotnet.exe publish -c Release -r win-x64 -f netcoreapp2.0

namespace PlantTycoonHelper
{
    class Program
    {
        private static FlowerCalculator flowerCalculator;
        private static StemCalculator stemCalculator;
        private static SeedCalculator seedCalculator;
        private static FlowerFormulaSeeder flowerSeeder;
        private static StemFormulaSeeder stemSeeder;
        private static SeedStorageSeeder seedSeeder;
        private static Catalog catalog;

        static void Main(string[] args)
        {
            flowerCalculator = new FlowerCalculator();
            stemCalculator = new StemCalculator();
            seedCalculator = new SeedCalculator();
            flowerSeeder = new FlowerFormulaSeeder(flowerCalculator);
            stemSeeder = new StemFormulaSeeder(stemCalculator);
            seedSeeder = new SeedStorageSeeder(seedCalculator);
            catalog = new Catalog();

            //CalculateFlowers();
            //CalculateStems();

            //ReseedFormulas();

            //LoopForFlowerOrStemType();

            ReportUntestedPlantFormulasForCurrentPlants();
        }

        public static List<Plant> CurrentPlants = new List<Plant>
        {
            new Plant(FlowerType.Fourpetal, StemType.Gladiatus),
            new Plant(FlowerType.Bluestar, StemType.PearCactus),
            new Plant(FlowerType.Daisy, StemType.Grass),
            new Plant(FlowerType.Bluestar, StemType.Ridgeball),
            new Plant(FlowerType.Daisy, StemType.TigerFern),

            new Plant(FlowerType.Mystic, StemType.RareOak),
            new Plant(FlowerType.Bluestar, StemType.Reptans),
            new Plant(FlowerType.Bluestar, StemType.Maple),
            new Plant(FlowerType.Bluestar, StemType.Ridgeball),
            new Plant(FlowerType.Painted, StemType.Ridgeball),

            new Plant(FlowerType.Bluestar, StemType.Lemonbush),
            new Plant(FlowerType.Mela, StemType.Maple),
            new Plant(FlowerType.Jalapa, StemType.BallCactus),
            new Plant(FlowerType.Venomous, StemType.Fern),
            new Plant(FlowerType.Viola, StemType.RareOak)
        };

        public static void ReportUntestedPlantFormulasForCurrentPlants()
        {
            var plantCalculator = new PlantCalculator();
            var untestedFormulas = plantCalculator.GetUntestedPlantFormulasForCurrentPlants(CurrentPlants);

            var outFileFull = File.CreateText("formulasFull.txt");
            untestedFormulas.ToList()
                .ForEach(x => outFileFull.WriteLine(
                    $"{x.PlantA.Flower.ToString()} {x.PlantA.Stem.ToString()} " +
                    $"+ {x.PlantB.Flower.ToString()} {x.PlantB.Stem.ToString()} " +
                    $"= {x.Result.Flower.ToString()} {x.Result.Stem.ToString()}"));
            outFileFull.Flush();
            outFileFull.Close();

            var outFile = File.CreateText("formulas.txt");
            var filteredFormulas = plantCalculator.FilterPlantFormulasOnlyBetweenCurrentPlants(CurrentPlants, untestedFormulas);
            filteredFormulas.ToList()
                .ForEach(x => outFile.WriteLine(
                    $"{x.PlantA.Flower.ToString()} {x.PlantA.Stem.ToString()} " +
                    $"+ {x.PlantB.Flower.ToString()} {x.PlantB.Stem.ToString()} " +
                    $"= {x.Result.Flower.ToString()} {x.Result.Stem.ToString()}"));
            outFile.Flush();
            outFile.Close();
        }

        static void LoopForFlowerOrStemType()
        {
            while (true)
            {
                Console.WriteLine("\nEnter command:");
                var input = Console.ReadLine();
                Console.WriteLine("---------------");
                var parsedInput = ParseFlowerOrStemInput(input);
                switch (parsedInput)
                {
                    case string command:
                        switch (command)
                        {
                            case "AF":  //All flower combinations
                                var allFlowerFormulasAF = flowerCalculator.ReportAllOrdered();
                                allFlowerFormulasAF
                                    .ForEach(x => Console.WriteLine(
                                        $"{x.FlowerA.ToString()} + {x.FlowerB.ToString()} = {x.Result?.ToString()}{ComposeInProgressString(x.InProgress)}"));
                                break;

                            case "AP":  //All stem combinations
                                var allStemFormulasAF = stemCalculator.ReportAllOrdered();
                                allStemFormulasAF
                                    .ForEach(x => Console.WriteLine(
                                        $"{x.StemA.ToString()} + {x.StemB.ToString()} = {x.Result?.ToString()}{ComposeInProgressString(x.InProgress)}"));
                                break;

                            case "LF":  //List flowers
                                var allFlowerFormulas = flowerCalculator.ReportAllOrdered();
                                var allFlowerFormulasWithResult = allFlowerFormulas.Where(x => x.Result != null || x.InProgress).ToList();
                                var allFlowerFormulasWithEmptyResult = allFlowerFormulas.Where(x => x.Result == null && x.InProgress == false).ToList();
                                Console.WriteLine("\nWith result: -------");
                                allFlowerFormulasWithResult
                                    .ForEach(x => Console.WriteLine(
                                        $"{x.FlowerA.ToString()} + {x.FlowerB.ToString()} = {x.Result?.ToString()}{ComposeInProgressString(x.InProgress)}"));
                                Console.WriteLine("\nWith no result: -------");
                                allFlowerFormulasWithEmptyResult
                                    .ForEach(x => Console.WriteLine($"{x.FlowerA.ToString()} + {x.FlowerB.ToString()}"));
                                break;

                            case "LP":  //List stems
                                var allStemFormulas = stemCalculator.ReportAllOrdered();
                                var allStemFormulasWithResult = allStemFormulas.Where(x => x.Result != null || x.InProgress).ToList();
                                var allStemFormulasWithEmptyResult = allStemFormulas.Where(x => x.Result == null && x.InProgress == false).ToList();
                                Console.WriteLine("\nWith result: -------");
                                allStemFormulasWithResult
                                    .ForEach(x => Console.WriteLine(
                                        $"{x.StemA.ToString()} + {x.StemB.ToString()} = {x.Result?.ToString()}{ComposeInProgressString(x.InProgress)}"));
                                Console.WriteLine("\nWith no result: -------");
                                allStemFormulasWithEmptyResult
                                    .ForEach(x => Console.WriteLine($"{x.StemA.ToString()} + {x.StemB.ToString()}"));
                                break;

                            case "RF":  //Reverse list flowers
                                var resultFlowerFormulas = flowerCalculator.ReportAllOrderedByResult();
                                resultFlowerFormulas
                                    .ForEach(x => Console.WriteLine($"{x.Result.ToString()} <- {x.FlowerA.ToString()} + {x.FlowerB.ToString()}"));
                                Console.WriteLine("\nElements with no formula:");
                                var flowerTypesWithNoFormula = flowerCalculator.ReportFlowerTypesWithNoFormula();
                                flowerTypesWithNoFormula
                                    .ForEach(x => Console.WriteLine($"{x.ToString()}"));
                                break;

                            case "RP":  //Reverse list stems
                                var resultStemFormulas = stemCalculator.ReportAllOrderedByResult();
                                resultStemFormulas 
                                    .ForEach(x => Console.WriteLine($"{x.Result.ToString()} <- {x.StemA.ToString()} + {x.StemB.ToString()}"));
                                Console.WriteLine("\nElements with no formula:");
                                var stemTypesWithNoFormula = stemCalculator.ReportStemTypesWithNoFormula();
                                stemTypesWithNoFormula
                                    .ForEach(x => Console.WriteLine($"{x.ToString()}"));
                                break;

                            case "SS":  //Seed Storage
                                var seeds = seedCalculator.ReportSeeds();
                                seeds
                                    .ForEach(x => Console.WriteLine($"{x.Flower.ToString()} {x.Stem.ToString()}"));
                                break;

                            case "RS":  //Reverse seed Storage
                                var seedsReverse = seedCalculator.ReportSeedsReverse();
                                seedsReverse
                                    .ForEach(x => Console.WriteLine($"{x.Flower.ToString()} {x.Stem.ToString()}"));
                                break;

                            case "UPDATE":  //Update formulas
                                ReseedFormulas();
                                break;

                            default:
                                Console.WriteLine("Wrong input");
                                break;
                        }
                        break;

                    case FlowerType flowerType:
                        var flowerFormulas = flowerCalculator.ReportForFlowerType(flowerType);
                        flowerFormulas.ForEach(x => Console.WriteLine($"{x.FlowerA.ToString()} + {x.FlowerB.ToString()} = {x.Result?.ToString()}"));
                        break;

                    case StemType stemType:
                        var stemFormulas = stemCalculator.ReportForStemType(stemType);
                        stemFormulas.ForEach(x => Console.WriteLine($"{x.StemA.ToString()} + {x.StemB.ToString()} = {x.Result?.ToString()}"));
                        break;

                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }

        private static string ComposeInProgressString(bool inProgress)
        {
            return (inProgress) ? "(P)" : string.Empty;
        }

        private static object ParseFlowerOrStemInput(string input)
        {
            object parsedInput = input.ToFlowerType() as object ?? input.ToStemType() as object ?? input.ToUpper();
            return parsedInput;
        }

        static void ReseedFormulas()
        {
            //TODO: it's time to rethink dbContext scopes. Use UnitOfWork.
            using (var dbContext = new PlantTycoonContext())
            {
                PlantTycoonDbInitializer.Initialize(dbContext);
            }

            flowerSeeder.Reseed();
            stemSeeder.Reseed();
            seedSeeder.Reseed();
            catalog.Reseed();
        }

        static void ListFlowerCombinations()
        {
            var calculator = new FlowerCalculator();
            var flowerTuples = calculator.CalculateAllOrderedFlowerFormulasWithEmptyResult();
            flowerTuples.ForEach(x => Console.WriteLine($"{x.FlowerA.ToString()} + {x.FlowerB.ToString()}"));
        }

        static void ListStemCombinations()
        {
            var calculator = new StemCalculator();
            var stemTuples = calculator.CalculateAllOrderedStemFormulasWithEmptyResult();
            stemTuples.ForEach(x => Console.WriteLine($"{x.StemA.ToString()} + {x.StemB.ToString()}"));
        }
    }
}
