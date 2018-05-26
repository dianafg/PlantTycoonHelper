using PlantTycoon.Domain;

namespace PlantTycoonHelper
{
    public class FormulaSeeder
    {
        private readonly FlowerCalculator flowerCalculator;
        private readonly PlantCalculator plantCalculator;

        public FormulaSeeder(FlowerCalculator flowerCalculator, PlantCalculator plantCalculator)
        {
            this.flowerCalculator = flowerCalculator;
            this.plantCalculator = plantCalculator;
        }

        public void ReseedFlowers()
        {
            flowerCalculator.InitializeEmptyFlowerResults();

            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Citrus, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Jalapa, FlowerType.Rosaceae);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Rosaceae, FlowerType.Mystic);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Spotted, FlowerType.Daisy);

            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Daisy, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Fragrant, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Jalapa, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Nox, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Rosaceae, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Spotted, FlowerType.Jalapa);

            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Mystic, FlowerType.Viola);

            flowerCalculator.SetFlowerFormula(FlowerType.Spotted, FlowerType.Fragrant, FlowerType.Mystic);
            flowerCalculator.SetFlowerFormula(FlowerType.Spotted, FlowerType.Mystic, FlowerType.Nox);
            flowerCalculator.SetFlowerFormula(FlowerType.Spotted, FlowerType.Rosaceae, FlowerType.Nox);

            flowerCalculator.SetFlowerFormula(FlowerType.Rosaceae, FlowerType.Aureus, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Rosaceae, FlowerType.Fragrant, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Rosaceae, FlowerType.Jalapa, FlowerType.Viola);
        }

        public void ReseedPlants()
        {
            plantCalculator.InitializeEmptyPlantResults();

            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Astera, PlantType.Fern);

            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.BallCactus, PlantType.Lemongrass);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Fern, PlantType.Gladiatus);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Maple, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Maranta, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Reptans, PlantType.Grass);

            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Fern, PlantType.Bamboo);

            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Gladiatus, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Maple, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Maranta, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Orchid, PlantType.Gladiatus);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Reptans, PlantType.Orchid);

            plantCalculator.SetPlantFormula(PlantType.Grass, PlantType.Lemongrass, PlantType.Fern);

            plantCalculator.SetPlantFormula(PlantType.Lemongrass, PlantType.Maple, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Lemongrass, PlantType.Reptans, PlantType.Gladiatus);

            plantCalculator.SetPlantFormula(PlantType.Maple, PlantType.Reptans, PlantType.Fern);
        }
    }
}
