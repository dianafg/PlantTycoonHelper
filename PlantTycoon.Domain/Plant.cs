namespace PlantTycoon.Domain
{
    public class Plant
    {
        public int Id { get; protected set; }
        public FlowerType Flower { get; protected set; }
        public StemType Stem { get; protected set; }
        public bool InProgress { get; protected set; }

        protected Plant() { }

        public Plant(FlowerType flower, StemType stem, bool inProgress = false)
        {
            this.Flower = flower;
            this.Stem = stem;
            this.InProgress = InProgress;
        }

        public Plant(string flowerName, string stemName, bool inProgress = false)
        {
            this.Flower = flowerName.ToFlowerType() ?? throw new System.InvalidCastException($"Wrong flower name: {flowerName}");
            this.Stem = stemName.ToStemType() ?? throw new System.InvalidCastException($"Wrong stem name: {stemName}");
            this.InProgress = InProgress;
        }
    }
}
