namespace PlantTycoon.Domain
{
    public class FlowerFormula
    {
        public FlowerType FlowerA { get; set; }
        public FlowerType FlowerB { get; set; }
        public FlowerType? Result { get; set; }

        public FlowerFormula(FlowerType flowerA, FlowerType flowerB, FlowerType? result = null)
        {
            this.FlowerA = flowerA;
            this.FlowerB = flowerB;
            this.Result = result;
        }
    }
}
