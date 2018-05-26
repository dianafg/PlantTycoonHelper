using PlantTycoonHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlantTycoonHelper
{
    public class Calculator
    {
        public void AddFlowerResults()
        {

        }

        public List<FlowerTuple> CalculateFlowers()
        {
            var flowerTuples = new List<FlowerTuple>();
            foreach (var flowerTypeA in Enum.GetNames(typeof(FlowerType)).OrderBy(x => x))
                foreach (var flowerTypeB in Enum.GetNames(typeof(FlowerType)).OrderBy(x => x).Where(x => x.CompareTo(flowerTypeA) > 0))
                {
                    flowerTuples.Add(new FlowerTuple((FlowerType)Enum.Parse(typeof(FlowerType), flowerTypeA), 
                        (FlowerType)Enum.Parse(typeof(FlowerType), flowerTypeB)));
                }
            return flowerTuples;
        }

        public void CalculatePlants()
        { }
    }
}
