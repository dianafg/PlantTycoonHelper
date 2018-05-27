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
        private static FormulaSeeder formulaSeeder;

        static void Main(string[] args)
        {
            flowerCalculator = new FlowerCalculator();
            plantCalculator = new PlantCalculator();
            formulaSeeder = new FormulaSeeder(flowerCalculator, plantCalculator);

            //CalculateFlowers();
            //CalculatePlants();

            ReseedFormulas();

            LoopForFlowerOrPlantType();
        }

        static void LoopForFlowerOrPlantType()
        {
            while (true)
            {
                Console.WriteLine("\nEnter flower or plant type:");
                var input = Console.ReadLine();
                Console.WriteLine("---------------");
                var parsedInput = ParseFlowerOrPlantInput(input);
                switch (parsedInput)
                {
                    case string command:
                        switch (command)
                        {
                            case "LF":  //List flowers
                                var allFlowerFormulas = flowerCalculator.ReportAllOrdered();
                                var allFlowerFormulasWithResult = allFlowerFormulas.Where(x => x.Result != null).ToList();
                                var allFlowerFormulasWithEmptyResult = allFlowerFormulas.Where(x => x.Result == null).ToList();
                                allFlowerFormulas
                                    .ForEach(x => Console.WriteLine($"{x.FlowerA.ToString()} + {x.FlowerB.ToString()} = {x.Result?.ToString()}"));
                                Console.WriteLine("\nWith result: -------");
                                allFlowerFormulasWithResult
                                    .ForEach(x => Console.WriteLine($"{x.FlowerA.ToString()} + {x.FlowerB.ToString()} = {x.Result?.ToString()}"));
                                Console.WriteLine("\nWith no result: -------");
                                allFlowerFormulasWithEmptyResult
                                    .ForEach(x => Console.WriteLine($"{x.FlowerA.ToString()} + {x.FlowerB.ToString()}"));
                                break;

                            case "LP":  //List plants
                                var allPlantFormulas = plantCalculator.ReportAllOrdered();
                                var allPlantFormulasWithResult = allPlantFormulas.Where(x => x.Result != null).ToList();
                                var allPlantFormulasWithEmptyResult = allPlantFormulas.Where(x => x.Result == null).ToList();
                                allPlantFormulas
                                    .ForEach(x => Console.WriteLine($"{x.PlantA.ToString()} + {x.PlantB.ToString()} = {x.Result?.ToString()}"));
                                Console.WriteLine("\nWith result: -------");
                                allPlantFormulasWithResult
                                    .ForEach(x => Console.WriteLine($"{x.PlantA.ToString()} + {x.PlantB.ToString()} = {x.Result?.ToString()}"));
                                Console.WriteLine("\nWith no result: -------");
                                allPlantFormulasWithEmptyResult
                                    .ForEach(x => Console.WriteLine($"{x.PlantA.ToString()} + {x.PlantB.ToString()}"));
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

        private static object ParseFlowerOrPlantInput(string input)
        {
            object parsedInput = input.ToFlowerType() as object ?? input.ToPlantType() as object ?? input.ToUpper();
            return parsedInput;
        }

        static void ReseedFormulas()
        {
            formulaSeeder.ReseedFlowers();
            formulaSeeder.ReseedPlants();
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
