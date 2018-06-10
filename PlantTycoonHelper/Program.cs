using PlantTycoon.Data;
using PlantTycoon.Domain;
using System;
using System.Linq;

//To publish as exe instead of dll:
//dotnet.exe publish -c Debug -r win-x64 -f netcoreapp2.0
//dotnet.exe publish -c Release -r win-x64 -f netcoreapp2.0

namespace PlantTycoonHelper
{
    class Program
    {
        private static FlowerCalculator flowerCalculator;
        private static PlantCalculator plantCalculator;
        private static FlowerFormulaSeeder flowerSeeder;
        private static PlantFormulaSeeder plantSeeder;

        static void Main(string[] args)
        {
            flowerCalculator = new FlowerCalculator();
            plantCalculator = new PlantCalculator();
            flowerSeeder = new FlowerFormulaSeeder(flowerCalculator);
            plantSeeder = new PlantFormulaSeeder(plantCalculator);

            //CalculateFlowers();
            //CalculatePlants();

            ReseedFormulas();

            LoopForFlowerOrPlantType();
        }

        static void LoopForFlowerOrPlantType()
        {
            while (true)
            {
                Console.WriteLine("\nEnter command:");
                var input = Console.ReadLine();
                Console.WriteLine("---------------");
                var parsedInput = ParseFlowerOrPlantInput(input);
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

                            case "AP":  //All plant combinations
                                var allPlantFormulasAF = plantCalculator.ReportAllOrdered();
                                allPlantFormulasAF
                                    .ForEach(x => Console.WriteLine(
                                        $"{x.PlantA.ToString()} + {x.PlantB.ToString()} = {x.Result?.ToString()}{ComposeInProgressString(x.InProgress)}"));
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

                            case "LP":  //List plants
                                var allPlantFormulas = plantCalculator.ReportAllOrdered();
                                var allPlantFormulasWithResult = allPlantFormulas.Where(x => x.Result != null).ToList();
                                var allPlantFormulasWithEmptyResult = allPlantFormulas.Where(x => x.Result == null).ToList();
                                Console.WriteLine("\nWith result: -------");
                                allPlantFormulasWithResult
                                    .ForEach(x => Console.WriteLine(
                                        $"{x.PlantA.ToString()} + {x.PlantB.ToString()} = {x.Result?.ToString()}{ComposeInProgressString(x.InProgress)}"));
                                Console.WriteLine("\nWith no result: -------");
                                allPlantFormulasWithEmptyResult
                                    .ForEach(x => Console.WriteLine($"{x.PlantA.ToString()} + {x.PlantB.ToString()}"));
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

                            case "RP":  //Reverse list plants
                                var resultPlantFormulas = plantCalculator.ReportAllOrderedByResult();
                                resultPlantFormulas 
                                    .ForEach(x => Console.WriteLine($"{x.Result.ToString()} <- {x.PlantA.ToString()} + {x.PlantB.ToString()}"));
                                Console.WriteLine("\nElements with no formula:");
                                var plantTypesWithNoFormula = plantCalculator.ReportPlantTypesWithNoFormula();
                                plantTypesWithNoFormula
                                    .ForEach(x => Console.WriteLine($"{x.ToString()}"));
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

                    case PlantType plantType:
                        var plantFormulas = plantCalculator.ReportForPlantType(plantType);
                        plantFormulas.ForEach(x => Console.WriteLine($"{x.PlantA.ToString()} + {x.PlantB.ToString()} = {x.Result?.ToString()}"));
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

        private static object ParseFlowerOrPlantInput(string input)
        {
            object parsedInput = input.ToFlowerType() as object ?? input.ToPlantType() as object ?? input.ToUpper();
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
            plantSeeder.Reseed();
        }

        static void ListFlowerCombinations()
        {
            var calculator = new FlowerCalculator();
            var flowerTuples = calculator.CalculateAllOrderedFlowerFormulasWithEmptyResult();
            flowerTuples.ForEach(x => Console.WriteLine($"{x.FlowerA.ToString()} + {x.FlowerB.ToString()}"));
        }

        static void ListPlantCombinations()
        {
            var calculator = new PlantCalculator();
            var plantTuples = calculator.CalculateAllOrderedPlantFormulasWithEmptyResult();
            plantTuples.ForEach(x => Console.WriteLine($"{x.PlantA.ToString()} + {x.PlantB.ToString()}"));
        }
    }
}
