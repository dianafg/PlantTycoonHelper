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

            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Bluestar, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Jalapa, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Viola, FlowerType.Fabled);

            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Citrus, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Daisy, FlowerType.Nox);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Fourpetal, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Jalapa, FlowerType.Rosaceae);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Rosaceae, FlowerType.Mystic);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Spotted, FlowerType.Daisy);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Fragrant, FlowerType.Viola);

            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Daisy, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Fragrant, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Jalapa, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Nox, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Rosaceae, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Spotted, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Viola, FlowerType.Fourpetal);

            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Spotted, FlowerType.Painted);

            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Fragrant, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Rosaceae, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Spotted, FlowerType.Mystic);

            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Mystic, FlowerType.Viola);
            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Nox, FlowerType.Rosaceae);
            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Spotted, FlowerType.Bluestar);

            flowerCalculator.SetFlowerFormula(FlowerType.Nox, FlowerType.Rosaceae, FlowerType.Mystic);

            flowerCalculator.SetFlowerFormula(FlowerType.Spotted, FlowerType.Fragrant, FlowerType.Mystic);
            flowerCalculator.SetFlowerFormula(FlowerType.Spotted, FlowerType.Mystic, FlowerType.Nox);
            flowerCalculator.SetFlowerFormula(FlowerType.Spotted, FlowerType.Rosaceae, FlowerType.Nox);
            flowerCalculator.SetFlowerFormula(FlowerType.Spotted, FlowerType.Viola, FlowerType.Bluestar);

            flowerCalculator.SetFlowerFormula(FlowerType.Painted, FlowerType.Rosaceae, FlowerType.Bluestar);

            flowerCalculator.SetFlowerFormula(FlowerType.Rosaceae, FlowerType.Aureus, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Rosaceae, FlowerType.Fragrant, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Rosaceae, FlowerType.Jalapa, FlowerType.Viola);
        }

        public void ReseedPlants()
        {
            plantCalculator.InitializeEmptyPlantResults();

            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Astera, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Maple, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Maranta, PlantType.Maranta);

            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.BallCactus, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Bamboo, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Fanleaf, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Fern, PlantType.Gladiatus);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Gladiatus, PlantType.Gladiatus);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Grass, PlantType.Orchid);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Lemonbush, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Maple, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Maranta, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Reptans, PlantType.Grass);

            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Fern, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Gladiatus, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Lemonbush, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Maranta, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Orchid, PlantType.Lemonbush);

            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.Maranta, PlantType.Lemonbush);

            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Gladiatus, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Lemonbush, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Maranta, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Orchid, PlantType.Fern);

            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Gladiatus, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Grass, PlantType.Astera);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Maple, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Maranta, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Orchid, PlantType.Gladiatus);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Reptans, PlantType.Orchid);

            plantCalculator.SetPlantFormula(PlantType.Grass, PlantType.Lemonbush, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Grass, PlantType.Maranta, PlantType.Gladiatus);

            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.Maple, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.Maranta, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.Reptans, PlantType.Gladiatus);

            plantCalculator.SetPlantFormula(PlantType.Maple, PlantType.Reptans, PlantType.Fern);
        }
    }
}
