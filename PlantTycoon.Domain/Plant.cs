namespace PlantTycoon.Domain
{
    public class Plant
    {
        public int Id { get; protected set; }
        public FlowerType Flower { get; protected set; }
        public StemType Stem { get; protected set; }

        protected Plant() { }

        public Plant(FlowerType flower, StemType stem)
        {
            this.Flower = flower;
            this.Stem = stem;
        }

        public Plant(string flowerName, string stemName)
        {
            this.Flower = flowerName.ToFlowerType() ?? throw new System.InvalidCastException($"Wrong flower name: {flowerName}");
            this.Stem = stemName.ToStemType() ?? throw new System.InvalidCastException($"Wrong stem name: {stemName}");
        }
    }
}
