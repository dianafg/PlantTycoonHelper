using System;
using System.Collections.Generic;
using System.Text;

namespace PlantTycoonHelper.Model
{
    public class FlowerTuple
    {
        public FlowerType FlowerA { get; set; }
        public FlowerType FlowerB { get; set; }
        public FlowerType? Result { get; set; }

        public FlowerTuple(FlowerType flowerA, FlowerType flowerB, FlowerType? result = null)
        {
            this.FlowerA = flowerA;
            this.FlowerB = flowerB;
            this.Result = result;
        }
    }
}
