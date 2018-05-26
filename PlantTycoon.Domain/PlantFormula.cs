namespace PlantTycoon.Domain
{
    public class PlantFormula
    {
        public PlantType PlantA { get; set; }
        public PlantType PlantB { get; set; }

        public PlantFormula(PlantType plantA, PlantType plantB)
        {
            this.PlantA = plantA;
            this.PlantB = plantB;
        }
    }
}
