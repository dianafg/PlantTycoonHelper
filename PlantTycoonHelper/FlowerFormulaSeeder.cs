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

            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Aureus, FlowerType.Mela);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Baccatus, FlowerType.Tahitian);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Blazing, FlowerType.Venomous);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Bluestar, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Citrus, FlowerType.Arthurium);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Daisy, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Fabled, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Fourpetal, FlowerType.Mela);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Fragrant, FlowerType.Venomous);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Jalapa, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Mela, FlowerType.Citrus);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Nox, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Lilia, FlowerType.Tahitian);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Mystic, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Painted, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Rosaceae, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Spotted, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Tahitian, FlowerType.Venus);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Tilia, FlowerType.Lilia);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Venomous, FlowerType.Citrus);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Venus, FlowerType.Venus);
            flowerCalculator.SetFlowerFormula(FlowerType.Arthurium, FlowerType.Viola, FlowerType.Fourpetal);

            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Baccatus, FlowerType.Arthurium);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Blazing, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Bluestar, FlowerType.Viola);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Citrus, FlowerType.Mela);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Daisy, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Fabled, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Fourpetal, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Fragrant, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Jalapa, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Lilia, FlowerType.Arthurium);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Mela, FlowerType.Venomous);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Mystic, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Nox, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Painted, FlowerType.Viola);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Rosaceae, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Spotted, FlowerType.Viola);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Tahitian, FlowerType.Citrus);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Tilia, FlowerType.Venus);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Venomous, FlowerType.Venomous);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Venus, FlowerType.Citrus);
            flowerCalculator.SetFlowerFormula(FlowerType.Aureus, FlowerType.Viola, FlowerType.Fragrant);

            flowerCalculator.SetFlowerFormula(FlowerType.Baccatus, FlowerType.Blazing, FlowerType.Citrus);
            flowerCalculator.SetFlowerFormula(FlowerType.Baccatus, FlowerType.Bluestar, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Baccatus, FlowerType.Citrus, FlowerType.Tahitian);
            flowerCalculator.SetFlowerFormula(FlowerType.Baccatus, FlowerType.Daisy, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Baccatus, FlowerType.Fabled, FlowerType.Mela);
            flowerCalculator.SetFlowerFormula(FlowerType.Baccatus, FlowerType.Fourpetal, FlowerType.Arthurium);
            flowerCalculator.SetFlowerFormula(FlowerType.Baccatus, FlowerType.Fragrant, FlowerType.Citrus);
            flowerCalculator.SetFlowerFormula(FlowerType.Baccatus, FlowerType.Jalapa, FlowerType.Mela);
            flowerCalculator.SetFlowerFormula(FlowerType.Baccatus, FlowerType.Mela, FlowerType.Venus);
            flowerCalculator.SetFlowerFormula(FlowerType.Baccatus, FlowerType.Mystic, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Baccatus, FlowerType.Nox, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Baccatus, FlowerType.Lilia, FlowerType.Baccatus);
            flowerCalculator.SetFlowerFormula(FlowerType.Baccatus, FlowerType.Painted, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Baccatus, FlowerType.Rosaceae, FlowerType.Venomous);
            flowerCalculator.SetFlowerFormula(FlowerType.Baccatus, FlowerType.Spotted, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Baccatus, FlowerType.Tahitian, FlowerType.Lilia);
            flowerCalculator.SetFlowerFormula(FlowerType.Baccatus, FlowerType.Tilia, FlowerType.Tilia);
            flowerCalculator.SetFlowerFormula(FlowerType.Baccatus, FlowerType.Venomous, FlowerType.Venus);
            flowerCalculator.SetFlowerFormula(FlowerType.Baccatus, FlowerType.Venus, FlowerType.Lilia);
            flowerCalculator.SetFlowerFormula(FlowerType.Baccatus, FlowerType.Viola, FlowerType.Venomous);

            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Bluestar, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Citrus, FlowerType.Venomous);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Daisy, FlowerType.Viola);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Fabled, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Fourpetal, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Fragrant, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Jalapa, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Lilia, FlowerType.Citrus);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Mela, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Mela, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Nox, FlowerType.Viola);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Mystic, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Painted, FlowerType.Rosaceae);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Rosaceae, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Spotted, FlowerType.Rosaceae);
            flowerCalculator.SetFlowerFormula(FlowerType.Blazing, FlowerType.Tahitian, FlowerType.Mela);
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
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Lilia, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Mela, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Mystic, FlowerType.Mystic);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Nox, FlowerType.Bluestar);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Painted, FlowerType.Nox);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Rosaceae, FlowerType.Mystic);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Spotted, FlowerType.Daisy);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Tahitian, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Tilia, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Venomous, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Venus, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Bluestar, FlowerType.Viola, FlowerType.Rosaceae);

            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Daisy, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Fabled, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Fourpetal, FlowerType.Venomous);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Fragrant, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Jalapa, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Lilia, FlowerType.Venus);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Mela, FlowerType.Citrus);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Mystic, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Nox, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Painted, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Rosaceae, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Spotted, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Tahitian, FlowerType.Venus);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Tilia, FlowerType.Tahitian);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Venomous, FlowerType.Mela);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Venus, FlowerType.Arthurium);
            flowerCalculator.SetFlowerFormula(FlowerType.Citrus, FlowerType.Viola, FlowerType.Fourpetal);

            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Fabled, FlowerType.Rosaceae);
            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Fourpetal, FlowerType.Viola);
            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Fragrant, FlowerType.Rosaceae);
            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Jalapa, FlowerType.Mystic);
            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Lilia, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Mela, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Mystic, FlowerType.Bluestar);
            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Nox, FlowerType.Nox);
            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Painted, FlowerType.Daisy);
            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Rosaceae, FlowerType.Bluestar);
            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Spotted, FlowerType.Painted);
            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Tahitian, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Tilia, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Venomous, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Venus, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Daisy, FlowerType.Viola, FlowerType.Mystic);

            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Fragrant, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Fourpetal, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Jalapa, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Lilia, FlowerType.Mela);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Mela, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Mystic, FlowerType.Viola);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Nox, FlowerType.Rosaceae);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Painted, FlowerType.Mystic);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Rosaceae, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Spotted, FlowerType.Mystic);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Tahitian, FlowerType.Venomous);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Tilia, FlowerType.Citrus);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Venomous, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Venus, FlowerType.Venomous);
            flowerCalculator.SetFlowerFormula(FlowerType.Fabled, FlowerType.Viola, FlowerType.Jalapa);

            flowerCalculator.SetFlowerFormula(FlowerType.Fourpetal, FlowerType.Fragrant, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Fourpetal, FlowerType.Jalapa, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Fourpetal, FlowerType.Lilia, FlowerType.Citrus);
            flowerCalculator.SetFlowerFormula(FlowerType.Fourpetal, FlowerType.Mela, FlowerType.Venomous);
            flowerCalculator.SetFlowerFormula(FlowerType.Fourpetal, FlowerType.Mystic, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Fourpetal, FlowerType.Nox, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Fourpetal, FlowerType.Painted, FlowerType.Viola);
            flowerCalculator.SetFlowerFormula(FlowerType.Fourpetal, FlowerType.Rosaceae, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Fourpetal, FlowerType.Spotted, FlowerType.Rosaceae);
            flowerCalculator.SetFlowerFormula(FlowerType.Fourpetal, FlowerType.Tahitian, FlowerType.Citrus);
            flowerCalculator.SetFlowerFormula(FlowerType.Fourpetal, FlowerType.Tilia, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Fourpetal, FlowerType.Venomous, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Fourpetal, FlowerType.Venus, FlowerType.Mela);
            flowerCalculator.SetFlowerFormula(FlowerType.Fourpetal, FlowerType.Viola, FlowerType.Fragrant);

            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Fourpetal, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Jalapa, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Lilia, FlowerType.Mela);
            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Mela, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Mystic, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Nox, FlowerType.Viola);
            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Painted, FlowerType.Rosaceae);
            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Rosaceae, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Spotted, FlowerType.Mystic);
            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Tahitian, FlowerType.Mela);
            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Tilia, FlowerType.Citrus);
            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Venomous, FlowerType.Mela);
            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Venus, FlowerType.Venomous);
            flowerCalculator.SetFlowerFormula(FlowerType.Fragrant, FlowerType.Viola, FlowerType.Fabled);

            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Lilia, FlowerType.Venomous);
            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Mystic, FlowerType.Viola);
            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Mela, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Nox, FlowerType.Rosaceae);
            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Painted, FlowerType.Mystic);
            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Rosaceae, FlowerType.Viola);
            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Spotted, FlowerType.Bluestar);
            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Tahitian, FlowerType.Venomous);
            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Tilia, FlowerType.Mela);
            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Venomous, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Venus, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Jalapa, FlowerType.Viola, FlowerType.Jalapa);

            flowerCalculator.SetFlowerFormula(FlowerType.Lilia, FlowerType.Mela, FlowerType.Venus);
            flowerCalculator.SetFlowerFormula(FlowerType.Lilia, FlowerType.Mystic, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Lilia, FlowerType.Nox, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Lilia, FlowerType.Painted, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Lilia, FlowerType.Rosaceae, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Lilia, FlowerType.Spotted, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Lilia, FlowerType.Tahitian, FlowerType.Lilia);
            flowerCalculator.SetFlowerFormula(FlowerType.Lilia, FlowerType.Tilia, FlowerType.Baccatus);
            flowerCalculator.SetFlowerFormula(FlowerType.Lilia, FlowerType.Venomous, FlowerType.Arthurium);
            flowerCalculator.SetFlowerFormula(FlowerType.Lilia, FlowerType.Venus, FlowerType.Tahitian);
            flowerCalculator.SetFlowerFormula(FlowerType.Lilia, FlowerType.Viola, FlowerType.Venomous);

            flowerCalculator.SetFlowerFormula(FlowerType.Mela, FlowerType.Mystic, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Mela, FlowerType.Nox, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Mela, FlowerType.Painted, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Mela, FlowerType.Rosaceae, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Mela, FlowerType.Spotted, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Mela, FlowerType.Tahitian, FlowerType.Arthurium);
            flowerCalculator.SetFlowerFormula(FlowerType.Mela, FlowerType.Tilia, FlowerType.Tahitian);
            flowerCalculator.SetFlowerFormula(FlowerType.Mela, FlowerType.Venomous, FlowerType.Mela);
            flowerCalculator.SetFlowerFormula(FlowerType.Mela, FlowerType.Venus, FlowerType.Arthurium);
            flowerCalculator.SetFlowerFormula(FlowerType.Mela, FlowerType.Viola, FlowerType.Blazing);

            flowerCalculator.SetFlowerFormula(FlowerType.Nox, FlowerType.Painted, FlowerType.Daisy);
            flowerCalculator.SetFlowerFormula(FlowerType.Nox, FlowerType.Rosaceae, FlowerType.Mystic);
            flowerCalculator.SetFlowerFormula(FlowerType.Nox, FlowerType.Spotted, FlowerType.Daisy);
            flowerCalculator.SetFlowerFormula(FlowerType.Nox, FlowerType.Tahitian, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Nox, FlowerType.Tilia, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Nox, FlowerType.Venomous, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Nox, FlowerType.Venus, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Nox, FlowerType.Viola, FlowerType.Mystic);

            flowerCalculator.SetFlowerFormula(FlowerType.Mystic, FlowerType.Nox, FlowerType.Bluestar);
            flowerCalculator.SetFlowerFormula(FlowerType.Mystic, FlowerType.Painted, FlowerType.Nox);
            flowerCalculator.SetFlowerFormula(FlowerType.Mystic, FlowerType.Rosaceae, FlowerType.Rosaceae);
            flowerCalculator.SetFlowerFormula(FlowerType.Mystic, FlowerType.Spotted, FlowerType.Nox);
            flowerCalculator.SetFlowerFormula(FlowerType.Mystic, FlowerType.Tahitian, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Mystic, FlowerType.Tilia, FlowerType.Venomous);
            flowerCalculator.SetFlowerFormula(FlowerType.Mystic, FlowerType.Venomous, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Mystic, FlowerType.Venus, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Mystic, FlowerType.Viola, FlowerType.Rosaceae);

            flowerCalculator.SetFlowerFormula(FlowerType.Painted, FlowerType.Rosaceae, FlowerType.Bluestar);
            flowerCalculator.SetFlowerFormula(FlowerType.Painted, FlowerType.Spotted, FlowerType.Painted);
            flowerCalculator.SetFlowerFormula(FlowerType.Painted, FlowerType.Tahitian, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Painted, FlowerType.Tilia, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Painted, FlowerType.Venomous, FlowerType.Jalapa);
            flowerCalculator.SetFlowerFormula(FlowerType.Painted, FlowerType.Venus, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Painted, FlowerType.Viola, FlowerType.Bluestar);

            flowerCalculator.SetFlowerFormula(FlowerType.Rosaceae, FlowerType.Spotted, FlowerType.Nox);
            flowerCalculator.SetFlowerFormula(FlowerType.Rosaceae, FlowerType.Tahitian, FlowerType.Aureus);
            flowerCalculator.SetFlowerFormula(FlowerType.Rosaceae, FlowerType.Tilia, FlowerType.Venomous);
            flowerCalculator.SetFlowerFormula(FlowerType.Rosaceae, FlowerType.Venomous, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Rosaceae, FlowerType.Venus, FlowerType.Fourpetal);
            flowerCalculator.SetFlowerFormula(FlowerType.Rosaceae, FlowerType.Viola, FlowerType.Viola);

            flowerCalculator.SetFlowerFormula(FlowerType.Spotted, FlowerType.Tahitian, FlowerType.Fragrant);
            flowerCalculator.SetFlowerFormula(FlowerType.Spotted, FlowerType.Tilia, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Spotted, FlowerType.Venomous, FlowerType.Viola);
            flowerCalculator.SetFlowerFormula(FlowerType.Spotted, FlowerType.Venus, FlowerType.Fabled);
            flowerCalculator.SetFlowerFormula(FlowerType.Spotted, FlowerType.Viola, FlowerType.Bluestar);

            flowerCalculator.SetFlowerFormula(FlowerType.Tahitian, FlowerType.Tilia, FlowerType.Baccatus);
            flowerCalculator.SetFlowerFormula(FlowerType.Tahitian, FlowerType.Venomous, FlowerType.Arthurium);
            flowerCalculator.SetFlowerFormula(FlowerType.Tahitian, FlowerType.Venus, FlowerType.Tahitian);
            flowerCalculator.SetFlowerFormula(FlowerType.Tahitian, FlowerType.Viola, FlowerType.Aureus);

            flowerCalculator.SetFlowerFormula(FlowerType.Tilia, FlowerType.Venomous, FlowerType.Venus);
            flowerCalculator.SetFlowerFormula(FlowerType.Tilia, FlowerType.Venus, FlowerType.Lilia);
            flowerCalculator.SetFlowerFormula(FlowerType.Tilia, FlowerType.Viola, FlowerType.Mela);

            flowerCalculator.SetFlowerFormula(FlowerType.Venomous, FlowerType.Viola, FlowerType.Blazing);
            flowerCalculator.SetFlowerFormula(FlowerType.Venomous, FlowerType.Venus, FlowerType.Citrus);

            flowerCalculator.SetFlowerFormula(FlowerType.Venus, FlowerType.Viola, FlowerType.Aureus);
        }
    }
}
