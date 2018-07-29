﻿using PlantTycoon.Data;
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

            //ReseedFormulas();
            catalog.Reseed();
            //seedSeeder.Reseed();

            //LoopForFlowerOrStemType();

            ReportUntestedPlantFormulasForCurrentPlants();
            ReportUntestedSeedsInStorage();
            ReportUntestedPlants();
        }

        public static List<Plant> CurrentPlants = new List<Plant>
        {
            new Plant(FlowerType.Venomous, StemType.Multiflora),
            new Plant(FlowerType.Spotted, StemType.Reptans),
            new Plant(FlowerType.Fabled, StemType.Ridgeball),
            new Plant(FlowerType.Aureus, StemType.Multiflora),
            new Plant(FlowerType.Arthurium, StemType.Pitcher),

            new Plant(FlowerType.Citrus, StemType.Weeper),
            new Plant(FlowerType.Blazing, StemType.Multiflora),
            new Plant(FlowerType.Mela, StemType.Ridgeball),
            new Plant(FlowerType.Tilia, StemType.Ananas),
            new Plant(FlowerType.Fourpetal, StemType.Multiflora),

            new Plant(FlowerType.Lilia, StemType.Orchid),
            new Plant(FlowerType.Mela, StemType.Weeper),
            new Plant(FlowerType.Tilia, StemType.Glaber),
            new Plant(FlowerType.Blazing, StemType.Ridgeball),
            new Plant(FlowerType.Baccatus, StemType.Gladiatus),


            new Plant(FlowerType.Blazing, StemType.Orchid),
            new Plant(FlowerType.Venus, StemType.Grass),
            new Plant(FlowerType.Painted, StemType.RareOak),
            new Plant(FlowerType.Citrus, StemType.Scandens),
            new Plant(FlowerType.Venomous, StemType.Scandens),
            new Plant(FlowerType.Tilia, StemType.Maranta),

            new Plant(FlowerType.Lilia, StemType.Glaber),
            new Plant(FlowerType.Baccatus, StemType.Astera),
            new Plant(FlowerType.Arthurium, StemType.Weeper),
            new Plant(FlowerType.Tilia, StemType.Fern),
            new Plant(FlowerType.Venomous, StemType.Ridgeball),
            new Plant(FlowerType.Mela, StemType.Multiflora),
            new Plant(FlowerType.Tilia, StemType.Gladiatus),
            new Plant(FlowerType.Fourpetal, StemType.Ridgeball),
            new Plant(FlowerType.Aureus, StemType.Ridgeball),
            new Plant(FlowerType.Citrus, StemType.Multiflora),
            new Plant(FlowerType.Citrus, StemType.Ridgeball),


            //new Plant(FlowerType.Citrus, StemType.Ridgeball),
            //new Plant(FlowerType.Arthurium, StemType.Multiflora),
            //new Plant(FlowerType.Arthurium, StemType.Ridgeball),
            //new Plant(FlowerType.Lilia, StemType.Weeper),

            new Plant(FlowerType.Tahitian, StemType.PipeCactus),
            new Plant(FlowerType.Fourpetal, StemType.TigerFern),
            new Plant(FlowerType.Rosaceae, StemType.Bamboo),
            new Plant(FlowerType.Arthurium, StemType.Bamboo),
            new Plant(FlowerType.Jalapa, StemType.Fern),
            new Plant(FlowerType.Bluestar, StemType.Lemonbush),
            new Plant(FlowerType.Viola, StemType.BallCactus),
            new Plant(FlowerType.Fragrant, StemType.Multiflora),
            new Plant(FlowerType.Citrus, StemType.RareOak),
            new Plant(FlowerType.Bluestar, StemType.Maranta),
    };

        public static void ReportUntestedPlantFormulasForCurrentPlants()
        {
            var plantCalculator = new PlantCalculator();
            var untestedFormulas = plantCalculator.GetUntestedPlantFormulasForCurrentPlants(CurrentPlants)
                .OrderBy(x => x.PlantA.Flower)
                .ThenBy(x => x.PlantA.Stem)
                .ThenBy(x => x.PlantB.Flower)
                .ThenBy(x => x.PlantB.Stem);

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

        public static void ReportUntestedSeedsInStorage()
        {
            var plantCalculator = new PlantCalculator();

            var outFile = File.CreateText("untested_seeds.txt");
            var untestedSeeds = plantCalculator.GetSeedsOfUntestedPlants();
            untestedSeeds.ToList()
                .ForEach(x => outFile.WriteLine(
                    $"{x.Flower.ToString()} {x.Stem.ToString()} " +
                    $"{x.Position?.ToString()}"));
            outFile.Flush();
            outFile.Close();
        }

        public static void ReportUntestedPlants()
        {
            var plantCalculator = new PlantCalculator();

            var outFile = File.CreateText("untested_plants.txt");
            var untestedPlants = plantCalculator.GetUntestedPlants();

            outFile.WriteLine($"Untested plants count: {untestedPlants.Count()}\n");

            var lastFlower = (FlowerType)1;
            untestedPlants.ToList()
                .ForEach(x =>
                {
                    if (x.Flower != lastFlower) outFile.WriteLine($"----------------");
                    lastFlower = x.Flower;
                    outFile.WriteLine($"{x.Flower.ToString()} {x.Stem.ToString()}");
                });

            outFile.WriteLine($"\n----------------------------------------------\n");

            var lastStem = (StemType)1;
            untestedPlants.OrderBy(x => x.Stem).ThenBy(x => x.Flower).ToList()
                .ForEach(x => 
                {
                    if (x.Stem != lastStem) outFile.WriteLine($"----------------");
                    lastStem = x.Stem;
                    outFile.WriteLine($"{x.Flower.ToString()} {x.Stem.ToString()}");
                });

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
