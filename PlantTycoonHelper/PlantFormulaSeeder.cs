using PlantTycoon.Domain;

namespace PlantTycoonHelper
{
    public class PlantFormulaSeeder
    {
        private readonly PlantCalculator plantCalculator;

        public PlantFormulaSeeder(PlantCalculator plantCalculator)
        {
            this.plantCalculator = plantCalculator;
        }

        public void Reseed()
        {
            plantCalculator.InitializeEmptyPlantResults();

            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Astera, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.BallCactus, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Bamboo, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Fanleaf, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Glaber, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Grass, PlantType.Gladiatus);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Lemonbush, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Maple, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Maranta, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.PearCactus, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.PipeCactus, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.RareOak, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.TigerFern, PlantType.RareOak);

            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.BallCactus, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Bamboo, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Fanleaf, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Fern, PlantType.Gladiatus);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Gladiatus, PlantType.Gladiatus);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Grass, PlantType.Orchid);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Lemonbush, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Maple, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Maranta, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Orchid, PlantType.Astera);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.PipeCactus, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.RareOak, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Reptans, PlantType.Grass);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Scandens, PlantType.Orchid);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.TigerFern, PlantType.Bamboo);

            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Bamboo, PlantType.PipeCactus);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Fanleaf, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Fern, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Glaber, PlantType.Glaber);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Gladiatus, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Lemonbush, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Maple, PlantType.PipeCactus);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Maranta, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Orchid, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.PearCactus, PlantType.BallCactus);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.PipeCactus, PlantType.PearCactus);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.RareOak, PlantType.PearCactus);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Scandens, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.TigerFern, PlantType.Glaber);

            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.Fanleaf, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.Gladiatus, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.Grass, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.Lemonbush, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.Maple, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.Maranta, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.PearCactus, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.PipeCactus, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.RareOak, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.Scandens, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.TigerFern, PlantType.PearCactus);

            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Fern, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Gladiatus, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Lemonbush, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Maple, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Maranta, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Orchid, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.PearCactus, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.PipeCactus, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.RareOak, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Scandens, PlantType.Gladiatus);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.TigerFern, PlantType.PipeCactus);

            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Gladiatus, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Grass, PlantType.Astera);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Lemonbush, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Maple, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Maranta, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Orchid, PlantType.Gladiatus);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Reptans, PlantType.Orchid);

            plantCalculator.SetPlantFormula(PlantType.Glaber, PlantType.Lemonbush, PlantType.PipeCactus);
            plantCalculator.SetPlantFormula(PlantType.Glaber, PlantType.Maple, PlantType.PearCactus);
            plantCalculator.SetPlantFormula(PlantType.Glaber, PlantType.Orchid, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Glaber, PlantType.PearCactus, PlantType.BallCactus);
            plantCalculator.SetPlantFormula(PlantType.Glaber, PlantType.PipeCactus, PlantType.BallCactus);
            plantCalculator.SetPlantFormula(PlantType.Glaber, PlantType.RareOak, PlantType.PearCactus);
            plantCalculator.SetPlantFormula(PlantType.Glaber, PlantType.TigerFern, PlantType.TigerFern);

            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.Lemonbush, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.Orchid, PlantType.Astera);
            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.Maple, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.Maranta, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.PearCactus, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.PipeCactus, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.Reptans, PlantType.Orchid);
            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.Scandens, PlantType.Orchid);
            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.TigerFern, PlantType.Maple);

            plantCalculator.SetPlantFormula(PlantType.Grass, PlantType.Lemonbush, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Grass, PlantType.Maple, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Grass, PlantType.Maranta, PlantType.Gladiatus);
            plantCalculator.SetPlantFormula(PlantType.Grass, PlantType.Reptans, PlantType.Scandens);

            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.Maple, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.Maranta, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.Orchid, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.PearCactus, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.PipeCactus, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.RareOak, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.Reptans, PlantType.Gladiatus);
            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.TigerFern, PlantType.PipeCactus);

            plantCalculator.SetPlantFormula(PlantType.Maple, PlantType.Maranta, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Maple, PlantType.PearCactus, PlantType.PipeCactus);
            plantCalculator.SetPlantFormula(PlantType.Maple, PlantType.PipeCactus, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.Maple, PlantType.RareOak, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.Maple, PlantType.Reptans, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Maple, PlantType.Scandens, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Maple, PlantType.TigerFern, PlantType.PearCactus);

            plantCalculator.SetPlantFormula(PlantType.Maranta, PlantType.Orchid, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Maranta, PlantType.PipeCactus, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Maranta, PlantType.RareOak, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Maranta, PlantType.TigerFern, PlantType.RareOak);

            plantCalculator.SetPlantFormula(PlantType.Orchid, PlantType.PipeCactus, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Orchid, PlantType.Reptans, PlantType.Grass);
            plantCalculator.SetPlantFormula(PlantType.Orchid, PlantType.TigerFern, PlantType.Bamboo);

            plantCalculator.SetPlantFormula(PlantType.PearCactus, PlantType.PipeCactus, PlantType.PearCactus);
            plantCalculator.SetPlantFormula(PlantType.PearCactus, PlantType.RareOak, PlantType.PipeCactus);
            plantCalculator.SetPlantFormula(PlantType.PearCactus, PlantType.TigerFern, PlantType.Glaber);

            plantCalculator.SetPlantFormula(PlantType.PipeCactus, PlantType.RareOak, PlantType.PipeCactus);
            plantCalculator.SetPlantFormula(PlantType.PipeCactus, PlantType.Reptans, true);
            plantCalculator.SetPlantFormula(PlantType.PipeCactus, PlantType.TigerFern, PlantType.BallCactus);

            plantCalculator.SetPlantFormula(PlantType.RareOak, PlantType.TigerFern, PlantType.BallCactus);
            plantCalculator.SetPlantFormula(PlantType.RareOak, PlantType.Scandens, PlantType.Ananas);

            plantCalculator.SetPlantFormula(PlantType.Scandens, PlantType.TigerFern, PlantType.Lemonbush);
        }
    }
}
