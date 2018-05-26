using PlantTycoon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

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
                                var flowerFormulasWithEmptyResult = new List<FlowerFormula>();
                                var flowerTypes = Enum.GetValues(typeof(FlowerType));
                                foreach (var flowerType in flowerTypes)
                                {
                                    var flowerFormulasByFlowerType = flowerCalculator.ReportForFlowerType((FlowerType)flowerType);
                                    flowerFormulasWithEmptyResult.AddRange(flowerFormulasByFlowerType.Where(x => x.Result == null));
                                }
                                flowerFormulasWithEmptyResult
                                    .ForEach(x => Console.WriteLine($"{x.FlowerA.ToString()} + {x.FlowerB.ToString()} = {x.Result?.ToString()}"));
                                break;

                            case "LP":  //List plants
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
            object parsedInput = input.ToFlowerType() as object ?? input.ToPlantType() as object ?? input;
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
