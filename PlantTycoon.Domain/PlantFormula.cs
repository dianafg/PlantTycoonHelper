using System;

namespace PlantTycoon.Domain
{
    public class PlantFormula
    {
        public int Id { get; protected set; }
        public PlantType PlantA { get; protected set; }
        public PlantType PlantB { get; protected set; }
        public PlantType? Result { get; set; }
        public bool InProgress { get; set; }

        protected PlantFormula() { }   //For EF

        public PlantFormula(PlantType plantA, PlantType plantB, PlantType? result = null)
        {
            this.PlantA = plantA;
            this.PlantB = plantB;
            this.Result = result;
        }

        public static PlantFormula CreateFromPlantTypeNames(string plantTypeNameA, string plantTypeNameB)
        {
            var plantTypeA = (PlantType)Enum.Parse(typeof(PlantType), plantTypeNameA);
            var plantTypeB = (PlantType)Enum.Parse(typeof(PlantType), plantTypeNameB);
            return new PlantFormula(plantTypeA, plantTypeB);
        }

        public static PlantFormula CreateFromPlantTypeNames(string plantTypeNameA, string plantTypeNameB, string plantTypeNameResult)
        {
            var plantTypeResult = (PlantType)Enum.Parse(typeof(PlantType), plantTypeNameResult);
            var plantFormula = CreateFromPlantTypeNames(plantTypeNameA, plantTypeNameB);
            plantFormula.Result = plantTypeResult;
            return plantFormula;
        }

        public void SetResultAndInProgress(PlantType? result, bool inProgress)
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
