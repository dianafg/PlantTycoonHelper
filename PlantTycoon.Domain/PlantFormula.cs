namespace PlantTycoon.Domain
{
    public class PlantFormula
    {
        public int Id { get; protected set; }
        public PlantType PlantA { get; protected set; }
        public PlantType PlantB { get; protected set; }
        public PlantType? Result { get; set; }

        public PlantFormula(PlantType plantA, PlantType plantB, PlantType? result = null)
        {
            this.PlantA = plantA;
            this.PlantB = plantB;
            this.Result = result;
        }
    }
}
