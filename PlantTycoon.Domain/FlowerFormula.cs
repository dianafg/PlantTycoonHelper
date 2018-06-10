using System;

namespace PlantTycoon.Domain
{
    public class FlowerFormula
    {
        public int Id { get; protected set; }
        public FlowerType FlowerA { get; protected set; }
        public FlowerType FlowerB { get; protected set; }
        public FlowerType? Result { get; set; }
        public bool InProgress { get; set; }

        protected FlowerFormula() { }   //For EF

        public FlowerFormula(FlowerType flowerA, FlowerType flowerB, FlowerType? result = null)
        {
            this.FlowerA = flowerA;
            this.FlowerB = flowerB;
            this.Result = result;
        }

        public static FlowerFormula CreateFromFlowerTypeNames(string flowerTypeNameA, string flowerTypeNameB)
        {
            var flowerTypeA = (FlowerType)Enum.Parse(typeof(FlowerType), flowerTypeNameA);
            var flowerTypeB = (FlowerType)Enum.Parse(typeof(FlowerType), flowerTypeNameB);
            return new FlowerFormula(flowerTypeA, flowerTypeB);
        }

        public static FlowerFormula CreateFromFlowerTypeNames(string flowerTypeNameA, string flowerTypeNameB, string flowerTypeNameResult)
        {
            var flowerTypeResult = (FlowerType)Enum.Parse(typeof(FlowerType), flowerTypeNameResult);
            var flowerFormula = CreateFromFlowerTypeNames(flowerTypeNameA, flowerTypeNameB);
            flowerFormula.Result = flowerTypeResult;
            return flowerFormula;
        }

        public void SetResultAndInProgress(FlowerType? result, bool inProgress)
        {
            //Some consistency checkings for parameter combinations
            if (result == null && inProgress == false)
                throw new InvalidOperationException($"Result can only be null for formulas in progress.");

            if (result != null && inProgress == true)
                throw new InvalidOperationException($"Result must be null for formulas in progress.");

            this.Result = result;
            this.InProgress = inProgress;
        }
    }
}
