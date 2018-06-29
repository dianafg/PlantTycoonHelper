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
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Fern, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Glaber, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Gladiatus, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Grass, PlantType.Gladiatus);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Lemonbush, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Maple, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Maranta, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Multiflora, PlantType.PipeCactus);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Orchid, PlantType.Gladiatus);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.PearCactus, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.PipeCactus, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Pitcher, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.RareOak, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Reptans, PlantType.Astera);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Ridgeball, PlantType.PearCactus);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Scandens, PlantType.Astera);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.TigerFern, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.Ananas, PlantType.Weeper, PlantType.PipeCactus);

            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.BallCactus, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Bamboo, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Fanleaf, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Fern, PlantType.Gladiatus);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Glaber, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Gladiatus, PlantType.Gladiatus);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Grass, PlantType.Orchid);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Lemonbush, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Maple, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Maranta, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Multiflora, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Orchid, PlantType.Astera);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.PearCactus, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.PipeCactus, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Pitcher, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.RareOak, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Reptans, PlantType.Grass);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Ridgeball, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Scandens, PlantType.Orchid);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.TigerFern, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Astera, PlantType.Weeper, PlantType.Maple);

            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Bamboo, PlantType.PipeCactus);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Fanleaf, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Fern, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Glaber, PlantType.Glaber);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Gladiatus, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Grass, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Lemonbush, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Maple, PlantType.PipeCactus);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Maranta, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Multiflora, PlantType.Pitcher);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Orchid, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.PearCactus, PlantType.BallCactus);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.PipeCactus, PlantType.PearCactus);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Pitcher, PlantType.TigerFern);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.RareOak, PlantType.PearCactus);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Reptans, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Ridgeball, PlantType.Pitcher);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Scandens, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.TigerFern, PlantType.Glaber);
            plantCalculator.SetPlantFormula(PlantType.BallCactus, PlantType.Weeper, PlantType.TigerFern);

            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.Fanleaf, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.Fern, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.Glaber, PlantType.PipeCactus);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.Gladiatus, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.Grass, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.Lemonbush, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.Maple, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.Maranta, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.Multiflora, PlantType.BallCactus);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.Orchid, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.PearCactus, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.Pitcher, PlantType.PearCactus);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.PipeCactus, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.RareOak, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.Reptans, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.Ridgeball, PlantType.Glaber);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.Scandens, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.TigerFern, PlantType.PearCactus);
            plantCalculator.SetPlantFormula(PlantType.Bamboo, PlantType.Weeper, PlantType.BallCactus);

            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Fern, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Glaber, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Gladiatus, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Grass, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Lemonbush, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Maple, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Maranta, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Multiflora, PlantType.PearCactus);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Orchid, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.PearCactus, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.PipeCactus, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Pitcher, PlantType.PipeCactus);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.RareOak, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Reptans, PlantType.Gladiatus);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Ridgeball, PlantType.BallCactus);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Scandens, PlantType.Gladiatus);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.TigerFern, PlantType.PipeCactus);
            plantCalculator.SetPlantFormula(PlantType.Fanleaf, PlantType.Weeper, PlantType.PearCactus);

            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Glaber, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Gladiatus, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Grass, PlantType.Astera);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Lemonbush, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Maple, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Maranta, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Multiflora, PlantType.PipeCactus);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Orchid, PlantType.Gladiatus);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.PearCactus, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.PipeCactus, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Pitcher, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.RareOak, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Reptans, PlantType.Orchid);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Ridgeball, PlantType.PipeCactus);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Scandens, PlantType.Astera);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.TigerFern, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Fern, PlantType.Weeper, PlantType.RareOak);

            plantCalculator.SetPlantFormula(PlantType.Glaber, PlantType.Gladiatus, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Glaber, PlantType.Grass, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Glaber, PlantType.Lemonbush, PlantType.PipeCactus);
            plantCalculator.SetPlantFormula(PlantType.Glaber, PlantType.Maple, PlantType.PearCactus);
            plantCalculator.SetPlantFormula(PlantType.Glaber, PlantType.Maranta, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.Glaber, PlantType.Multiflora, PlantType.Pitcher);
            plantCalculator.SetPlantFormula(PlantType.Glaber, PlantType.Orchid, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Glaber, PlantType.PearCactus, PlantType.BallCactus);
            plantCalculator.SetPlantFormula(PlantType.Glaber, PlantType.PipeCactus, PlantType.BallCactus);
            plantCalculator.SetPlantFormula(PlantType.Glaber, PlantType.Pitcher, PlantType.TigerFern);
            plantCalculator.SetPlantFormula(PlantType.Glaber, PlantType.RareOak, PlantType.PearCactus);
            plantCalculator.SetPlantFormula(PlantType.Glaber, PlantType.Reptans, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Glaber, PlantType.Ridgeball, PlantType.Weeper);
            plantCalculator.SetPlantFormula(PlantType.Glaber, PlantType.Scandens, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Glaber, PlantType.TigerFern, PlantType.TigerFern);
            plantCalculator.SetPlantFormula(PlantType.Glaber, PlantType.Weeper, PlantType.Pitcher);

            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.Grass, PlantType.Astera);
            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.Lemonbush, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.Orchid, PlantType.Astera);
            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.Maple, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.Maranta, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.Multiflora, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.PearCactus, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.PipeCactus, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.Pitcher, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.RareOak, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.Reptans, PlantType.Orchid);
            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.Ridgeball, PlantType.PipeCactus);
            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.Scandens, PlantType.Orchid);
            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.TigerFern, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Gladiatus, PlantType.Weeper, PlantType.RareOak);

            plantCalculator.SetPlantFormula(PlantType.Grass, PlantType.Lemonbush, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Grass, PlantType.Maple, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Grass, PlantType.Maranta, PlantType.Gladiatus);
            plantCalculator.SetPlantFormula(PlantType.Grass, PlantType.Multiflora, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Grass, PlantType.Orchid, PlantType.Orchid);
            plantCalculator.SetPlantFormula(PlantType.Grass, PlantType.PearCactus, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Grass, PlantType.PipeCactus, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.Grass, PlantType.Pitcher, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Grass, PlantType.RareOak, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.Grass, PlantType.Reptans, PlantType.Scandens);
            plantCalculator.SetPlantFormula(PlantType.Grass, PlantType.Ridgeball, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Grass, PlantType.Scandens, PlantType.Grass);
            plantCalculator.SetPlantFormula(PlantType.Grass, PlantType.TigerFern, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Grass, PlantType.Weeper, PlantType.Bamboo);

            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.Maple, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.Maranta, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.Multiflora, PlantType.BallCactus);
            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.Orchid, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.PearCactus, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.PipeCactus, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.Pitcher, PlantType.PearCactus);
            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.RareOak, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.Reptans, PlantType.Gladiatus);
            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.Ridgeball, PlantType.BallCactus);
            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.Scandens, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.TigerFern, PlantType.PipeCactus);
            plantCalculator.SetPlantFormula(PlantType.Lemonbush, PlantType.Weeper, PlantType.PearCactus);

            plantCalculator.SetPlantFormula(PlantType.Maple, PlantType.Maranta, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Maple, PlantType.Multiflora, PlantType.Glaber);
            plantCalculator.SetPlantFormula(PlantType.Maple, PlantType.Orchid, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.Maple, PlantType.PearCactus, PlantType.PipeCactus);
            plantCalculator.SetPlantFormula(PlantType.Maple, PlantType.PipeCactus, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.Maple, PlantType.Pitcher, PlantType.BallCactus);
            plantCalculator.SetPlantFormula(PlantType.Maple, PlantType.RareOak, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.Maple, PlantType.Reptans, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Maple, PlantType.Ridgeball, PlantType.Glaber);
            plantCalculator.SetPlantFormula(PlantType.Maple, PlantType.Scandens, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.Maple, PlantType.TigerFern, PlantType.PearCactus);
            plantCalculator.SetPlantFormula(PlantType.Maple, PlantType.Weeper, PlantType.BallCactus);

            plantCalculator.SetPlantFormula(PlantType.Maranta, PlantType.Multiflora, PlantType.PearCactus);
            plantCalculator.SetPlantFormula(PlantType.Maranta, PlantType.Orchid, PlantType.Fern);
            plantCalculator.SetPlantFormula(PlantType.Maranta, PlantType.PearCactus, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Maranta, PlantType.PipeCactus, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Maranta, PlantType.Pitcher, PlantType.PipeCactus);
            plantCalculator.SetPlantFormula(PlantType.Maranta, PlantType.RareOak, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Maranta, PlantType.Reptans, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Maranta, PlantType.Ridgeball, PlantType.PearCactus);
            plantCalculator.SetPlantFormula(PlantType.Maranta, PlantType.Scandens, PlantType.Gladiatus);
            plantCalculator.SetPlantFormula(PlantType.Maranta, PlantType.TigerFern, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.Maranta, PlantType.Weeper, PlantType.PipeCactus);

            plantCalculator.SetPlantFormula(PlantType.Multiflora, PlantType.Orchid, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Multiflora, PlantType.PearCactus, PlantType.TigerFern);
            plantCalculator.SetPlantFormula(PlantType.Multiflora, PlantType.PipeCactus, PlantType.TigerFern);
            plantCalculator.SetPlantFormula(PlantType.Multiflora, PlantType.Pitcher, PlantType.Weeper);
            plantCalculator.SetPlantFormula(PlantType.Multiflora, PlantType.RareOak, PlantType.Glaber);
            plantCalculator.SetPlantFormula(PlantType.Multiflora, PlantType.Reptans, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Multiflora, PlantType.Ridgeball, PlantType.Ridgeball);
            plantCalculator.SetPlantFormula(PlantType.Multiflora, PlantType.Scandens, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Multiflora, PlantType.TigerFern, PlantType.Weeper);
            plantCalculator.SetPlantFormula(PlantType.Multiflora, PlantType.Weeper, PlantType.Multiflora);

            plantCalculator.SetPlantFormula(PlantType.Orchid, PlantType.PearCactus, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Orchid, PlantType.PipeCactus, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Orchid, PlantType.Pitcher, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Orchid, PlantType.RareOak, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.Orchid, PlantType.Reptans, PlantType.Grass);
            plantCalculator.SetPlantFormula(PlantType.Orchid, PlantType.Ridgeball, PlantType.RareOak);
            plantCalculator.SetPlantFormula(PlantType.Orchid, PlantType.Scandens, PlantType.Grass);
            plantCalculator.SetPlantFormula(PlantType.Orchid, PlantType.TigerFern, PlantType.Bamboo);
            plantCalculator.SetPlantFormula(PlantType.Orchid, PlantType.Weeper, PlantType.Maple);

            plantCalculator.SetPlantFormula(PlantType.PearCactus, PlantType.PipeCactus, PlantType.PearCactus);
            plantCalculator.SetPlantFormula(PlantType.PearCactus, PlantType.Pitcher, PlantType.Glaber);
            plantCalculator.SetPlantFormula(PlantType.PearCactus, PlantType.RareOak, PlantType.PipeCactus);
            plantCalculator.SetPlantFormula(PlantType.PearCactus, PlantType.Reptans, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.PearCactus, PlantType.Ridgeball, PlantType.Pitcher);
            plantCalculator.SetPlantFormula(PlantType.PearCactus, PlantType.Scandens, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.PearCactus, PlantType.TigerFern, PlantType.Glaber);
            plantCalculator.SetPlantFormula(PlantType.PearCactus, PlantType.Weeper, PlantType.TigerFern);

            plantCalculator.SetPlantFormula(PlantType.PipeCactus, PlantType.Pitcher, PlantType.Glaber);
            plantCalculator.SetPlantFormula(PlantType.PipeCactus, PlantType.RareOak, PlantType.PipeCactus);
            plantCalculator.SetPlantFormula(PlantType.PipeCactus, PlantType.Reptans, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.PipeCactus, PlantType.Ridgeball, PlantType.TigerFern);
            plantCalculator.SetPlantFormula(PlantType.PipeCactus, PlantType.Scandens, PlantType.Maranta);
            plantCalculator.SetPlantFormula(PlantType.PipeCactus, PlantType.TigerFern, PlantType.BallCactus);
            plantCalculator.SetPlantFormula(PlantType.PipeCactus, PlantType.Weeper, PlantType.Glaber);

            plantCalculator.SetPlantFormula(PlantType.Pitcher, PlantType.RareOak, PlantType.BallCactus);
            plantCalculator.SetPlantFormula(PlantType.Pitcher, PlantType.Reptans, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Pitcher, PlantType.Ridgeball, PlantType.Multiflora);
            plantCalculator.SetPlantFormula(PlantType.Pitcher, PlantType.Scandens, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Pitcher, PlantType.TigerFern, PlantType.Pitcher);
            plantCalculator.SetPlantFormula(PlantType.Pitcher, PlantType.Weeper, PlantType.Weeper);

            plantCalculator.SetPlantFormula(PlantType.RareOak, PlantType.Reptans, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.RareOak, PlantType.Ridgeball, PlantType.TigerFern);
            plantCalculator.SetPlantFormula(PlantType.RareOak, PlantType.TigerFern, PlantType.BallCactus);
            plantCalculator.SetPlantFormula(PlantType.RareOak, PlantType.Scandens, PlantType.Ananas);
            plantCalculator.SetPlantFormula(PlantType.RareOak, PlantType.Weeper, PlantType.Glaber);

            plantCalculator.SetPlantFormula(PlantType.Reptans, PlantType.Ridgeball, PlantType.Ridgeball);
            plantCalculator.SetPlantFormula(PlantType.Reptans, PlantType.Scandens, PlantType.Scandens);
            plantCalculator.SetPlantFormula(PlantType.Reptans, PlantType.TigerFern, PlantType.Fanleaf);
            plantCalculator.SetPlantFormula(PlantType.Reptans, PlantType.Weeper, PlantType.Lemonbush);

            plantCalculator.SetPlantFormula(PlantType.Ridgeball, PlantType.Scandens, PlantType.Maple);
            plantCalculator.SetPlantFormula(PlantType.Ridgeball, PlantType.TigerFern, PlantType.Weeper);
            plantCalculator.SetPlantFormula(PlantType.Ridgeball, PlantType.Weeper, PlantType.Multiflora);

            plantCalculator.SetPlantFormula(PlantType.Scandens, PlantType.TigerFern, PlantType.Lemonbush);
            plantCalculator.SetPlantFormula(PlantType.Scandens, PlantType.Weeper, PlantType.Bamboo);

            plantCalculator.SetPlantFormula(PlantType.TigerFern, PlantType.Weeper, PlantType.Pitcher);
        }
    }
}
