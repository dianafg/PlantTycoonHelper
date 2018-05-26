using PlantTycoon.Domain;
using System;

namespace PlantTycoonHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateFlowers();
            Console.ReadLine();

            //var calculator = new Calculator();
            //SeedWithSomeResults(calculator);
        }

        static void SeedWithSomeResults(Calculator calculator)
        {
            calculator.InitializeEmptyFlowerResults();

            calculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Citrus, FlowerType.Fragrant);
            calculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Spotted, FlowerType.Daisy);
            calculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Spotted, FlowerType.Jalapa);

            calculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Fragrant, FlowerType.Aureus);
            calculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Jalapa, FlowerType.Fourpetal);

            calculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Rosaceae, FlowerType.Mystic);
            calculator.SetFlowerFormula(FlowerType.Spotted, FlowerType.Fragrant, FlowerType.Mystic);
            calculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Rosaceae, FlowerType.Jalapa);
            calculator.SetFlowerFormula(FlowerType.Mystic, FlowerType.Spotted, FlowerType.Nox);
        }

        static void CalculateFlowers()
        {
            var calculator = new Calculator();
            var flowerTuples = calculator.CalculateAllOrderedFlowerFormulasWithEmptyResult();
            flowerTuples.ForEach(x => Console.WriteLine($"{x.FlowerA.ToString()} + {x.FlowerB.ToString()}"));
        }
    }
}
