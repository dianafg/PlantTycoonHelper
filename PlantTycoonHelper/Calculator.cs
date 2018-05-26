using PlantTycoon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantTycoonHelper
{
    public class Calculator
    {
        public void AddFlowerResults()
        {

        }

        public List<FlowerFormula> CalculateFlowers()
        {
            var FlowerFormulas = new List<FlowerFormula>();
            foreach (var flowerTypeA in Enum.GetNames(typeof(FlowerType)).OrderBy(x => x))
                foreach (var flowerTypeB in Enum.GetNames(typeof(FlowerType)).OrderBy(x => x).Where(x => x.CompareTo(flowerTypeA) > 0))
                {
                    FlowerFormulas.Add(new FlowerFormula((FlowerType)Enum.Parse(typeof(FlowerType), flowerTypeA), 
                        (FlowerType)Enum.Parse(typeof(FlowerType), flowerTypeB)));
                }
            return FlowerFormulas;
        }

        public void CalculatePlants()
        { }
    }
}
