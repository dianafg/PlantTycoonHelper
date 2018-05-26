namespace PlantTycoon.Domain
{
    public class FlowerFormula
    {
        public int Id { get; protected set; }
        public FlowerType FlowerA { get; protected set; }
        public FlowerType FlowerB { get; protected set; }
        public FlowerType? Result { get; set; }

        protected FlowerFormula() { }   //For EF

        public FlowerFormula(FlowerType flowerA, FlowerType flowerB, FlowerType? result = null)
        {
            this.FlowerA = flowerA;
            this.FlowerB = flowerB;
            this.Result = result;
        }
    }
}
