using PlantTycoon.Domain;

namespace PlantTycoonHelper
{
    public class FlowerFormulaSeeder
    {
        private readonly FlowerCalculator flowerCalculator;

        public FlowerFormulaSeeder(FlowerCalculator flowerCalculator)
        {
            this.flowerCalculator = flowerCalculator;
        }

        public void Reseed()
        {
            flowerCalculator.InitializeEmptyFlowerResults();

            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Bluestar, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Fabled, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Jalapa, true);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Mela, FlowerType.Citrus);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Venomous, FlowerType.Citrus);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Viola, FlowerType.Fourpetal);

            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Blazing, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Bluestar, FlowerType.Viola);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Citrus, FlowerType.Mela);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Daisy, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Fabled, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Fourpetal, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Fragrant, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Jalapa, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Mela, FlowerType.Venomous);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Mystic, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Nox, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Rosaceae, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Tahitian, true);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Tilia, FlowerType.Venus);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Venomous, FlowerType.Venomous);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Venus, FlowerType.Citrus);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Viola, FlowerType.Fragrant);

            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Bluestar, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Citrus, FlowerType.Venomous);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Daisy, FlowerType.Viola);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Fabled, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Fourpetal, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Fragrant, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Jalapa, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Mela, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Mystic, true);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Painted, FlowerType.Rosaceae);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Rosaceae, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Spotted, FlowerType.Rosaceae);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Tilia, FlowerType.Arthurium);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Venomous, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Venus, FlowerType.Mela);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Viola, FlowerType.Fabled);

            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Citrus, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Daisy, FlowerType.Nox);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Fabled, FlowerType.Viola);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Fourpetal, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Fragrant, FlowerType.Viola);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Jalapa, FlowerType.Rosaceae);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Mystic, FlowerType.Mystic);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Rosaceae, FlowerType.Mystic);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Spotted, FlowerType.Daisy);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Viola, FlowerType.Rosaceae);

            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Daisy, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Fabled, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Fragrant, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Jalapa, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Mela, FlowerType.Citrus);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Mystic, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Nox, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Rosaceae, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Spotted, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Tahitian, true);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Tilia, FlowerType.Tahitian);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Venus, FlowerType.Arthurium);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Viola, FlowerType.Fourpetal);

            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Fabled, FlowerType.Rosaceae);
            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Fourpetal, FlowerType.Viola);
            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Fragrant, FlowerType.Rosaceae);
            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Jalapa, FlowerType.Mystic);
            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Mela, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Mystic, FlowerType.Bluestar);
            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Rosaceae, FlowerType.Bluestar);
            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Spotted, FlowerType.Painted);
            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Viola, FlowerType.Mystic);

            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Fragrant, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Fourpetal, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Jalapa, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Mela, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Mystic, FlowerType.Viola);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Rosaceae, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Spotted, FlowerType.Mystic);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Tilia, FlowerType.Citrus);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Venus, FlowerType.Venomous);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Viola, FlowerType.Jalapa);

            flowerCalculator.SetFlowerFormula(FlowerType.Fourpetal, FlowerType.Fragrant, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Fourpetal, FlowerType.Jalapa, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Fourpetal, FlowerType.Mystic, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Fourpetal, FlowerType.Nox, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Fourpetal, FlowerType.Rosaceae, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Fourpetal, FlowerType.Venus, FlowerType.Mela);
            flowerCalculator.SetFlowerFormula(FlowerType.Fourpetal, FlowerType.Viola, FlowerType.Fragrant);

            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Fourpetal, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Jalapa, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Mela, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Mystic, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Rosaceae, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Spotted, FlowerType.Mystic);
            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Tilia, FlowerType.Citrus);
            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Venomous, true);
            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Venus, FlowerType.Venomous);
            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Viola, FlowerType.Fabled);

            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Mystic, FlowerType.Viola);
            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Mela, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Nox, FlowerType.Rosaceae);
            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Rosaceae, FlowerType.Viola);
            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Spotted, FlowerType.Bluestar);
            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Tahitian, true);
            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Tilia, FlowerType.Mela);
            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Venomous, true);
            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Venus, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Viola, FlowerType.Jalapa);

            flowerCalculator.SetFlowerFormula(FlowerType.Mela, FlowerType.Venomous, FlowerType.Mela);
            flowerCalculator.SetFlowerFormula(FlowerType.Mela, FlowerType.Venus, FlowerType.Arthurium);
            flowerCalculator.SetFlowerFormula(FlowerType.Mela, FlowerType.Viola, FlowerType.Blazing);

            flowerCalculator.SetFlowerFormula(FlowerType.Nox, FlowerType.Rosaceae, FlowerType.Mystic);
            flowerCalculator.SetFlowerFormula(FlowerType.Nox, FlowerType.Venus, FlowerType.Blazing);

            flowerCalculator.SetFlowerFormula(FlowerType.Mela, FlowerType.Venus, FlowerType.Arthurium);

            flowerCalculator.SetFlowerFormula(FlowerType.Mystic, FlowerType.Nox, FlowerType.Bluestar);
            flowerCalculator.SetFlowerFormula(FlowerType.Mystic, FlowerType.Rosaceae, FlowerType.Rosaceae);
            flowerCalculator.SetFlowerFormula(FlowerType.Mystic, FlowerType.Spotted, FlowerType.Nox);
            flowerCalculator.SetFlowerFormula(FlowerType.Mystic, FlowerType.Viola, FlowerType.Rosaceae);

            flowerCalculator.SetFlowerFormula(FlowerType.Painted, FlowerType.Rosaceae, FlowerType.Bluestar);
            flowerCalculator.SetFlowerFormula(FlowerType.Painted, FlowerType.Viola, FlowerType.Bluestar);

            flowerCalculator.SetFlowerFormula(FlowerType.Rosaceae, FlowerType.Spotted, FlowerType.Nox);
            flowerCalculator.SetFlowerFormula(FlowerType.Rosaceae, FlowerType.Tahitian, true);
            flowerCalculator.SetFlowerFormula(FlowerType.Rosaceae, FlowerType.Venomous, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Rosaceae, FlowerType.Viola, FlowerType.Viola);

            flowerCalculator.SetFlowerFormula(FlowerType.Spotted, FlowerType.Viola, FlowerType.Bluestar);

            flowerCalculator.SetFlowerFormula(FlowerType.Tahitian, FlowerType.Viola, FlowerType.Aureus);

            flowerCalculator.SetFlowerFormula(FlowerType.Tilia, FlowerType.Viola, FlowerType.Mela);

            flowerCalculator.SetFlowerFormula(FlowerType.Venomous, FlowerType.Viola, true);
        }
    }
}
