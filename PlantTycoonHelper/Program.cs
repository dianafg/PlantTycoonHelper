using System;

namespace PlantTycoonHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateFlowers();
            Console.ReadLine();
        }

        static void CalculateFlowers()
        {
            var calculator = new Calculator();
            var flowerTuples = calculator.CalculateFlowers();
            flowerTuples.ForEach(x => Console.WriteLine($"{x.FlowerA.ToString()} + {x.FlowerB.ToString()}"));
        }
    }
}
