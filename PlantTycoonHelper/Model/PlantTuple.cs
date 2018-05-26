using System;
using System.Collections.Generic;
using System.Text;

namespace PlantTycoonHelper.Model
{
    public class PlantTuple
    {
        public PlantType PlantA { get; set; }
        public PlantType PlantB { get; set; }

        public PlantTuple(PlantType plantA, PlantType plantB)
        {
            this.PlantA = plantA;
            this.PlantB = plantB;
        }
    }
}
