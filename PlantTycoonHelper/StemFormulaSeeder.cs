using PlantTycoon.Domain;

namespace PlantTycoonHelper
{
    public class StemFormulaSeeder
    {
        private readonly StemCalculator stemCalculator;

        public StemFormulaSeeder(StemCalculator stemCalculator)
        {
            this.stemCalculator = stemCalculator;
        }

        public void Reseed()
        {
            stemCalculator.InitializeEmptyStemResults();

            stemCalculator.SetStemFormula(StemType.Ananas, StemType.Astera, StemType.Fern);
            stemCalculator.SetStemFormula(StemType.Ananas, StemType.BallCactus, StemType.Maple);
            stemCalculator.SetStemFormula(StemType.Ananas, StemType.Bamboo, StemType.Fanleaf);
            stemCalculator.SetStemFormula(StemType.Ananas, StemType.Fanleaf, StemType.Maranta);
            stemCalculator.SetStemFormula(StemType.Ananas, StemType.Fern, StemType.Ananas);
            stemCalculator.SetStemFormula(StemType.Ananas, StemType.Glaber, StemType.Maple);
            stemCalculator.SetStemFormula(StemType.Ananas, StemType.Gladiatus, StemType.Fern);
            stemCalculator.SetStemFormula(StemType.Ananas, StemType.Grass, StemType.Gladiatus);
            stemCalculator.SetStemFormula(StemType.Ananas, StemType.Lemonbush, StemType.Fanleaf);
            stemCalculator.SetStemFormula(StemType.Ananas, StemType.Maple, StemType.Lemonbush);
            stemCalculator.SetStemFormula(StemType.Ananas, StemType.Maranta, StemType.Maranta);
            stemCalculator.SetStemFormula(StemType.Ananas, StemType.Multiflora, StemType.PipeCactus);
            stemCalculator.SetStemFormula(StemType.Ananas, StemType.Orchid, StemType.Gladiatus);
            stemCalculator.SetStemFormula(StemType.Ananas, StemType.PearCactus, StemType.Bamboo);
            stemCalculator.SetStemFormula(StemType.Ananas, StemType.PipeCactus, StemType.Bamboo);
            stemCalculator.SetStemFormula(StemType.Ananas, StemType.Pitcher, StemType.RareOak);
            stemCalculator.SetStemFormula(StemType.Ananas, StemType.RareOak, StemType.Lemonbush);
            stemCalculator.SetStemFormula(StemType.Ananas, StemType.Reptans, StemType.Astera);
            stemCalculator.SetStemFormula(StemType.Ananas, StemType.Ridgeball, StemType.PearCactus);
            stemCalculator.SetStemFormula(StemType.Ananas, StemType.Scandens, StemType.Astera);
            stemCalculator.SetStemFormula(StemType.Ananas, StemType.TigerFern, StemType.RareOak);
            stemCalculator.SetStemFormula(StemType.Ananas, StemType.Weeper, StemType.PipeCactus);

            stemCalculator.SetStemFormula(StemType.Astera, StemType.BallCactus, StemType.Lemonbush);
            stemCalculator.SetStemFormula(StemType.Astera, StemType.Bamboo, StemType.Maranta);
            stemCalculator.SetStemFormula(StemType.Astera, StemType.Fanleaf, StemType.Ananas);
            stemCalculator.SetStemFormula(StemType.Astera, StemType.Fern, StemType.Gladiatus);
            stemCalculator.SetStemFormula(StemType.Astera, StemType.Glaber, StemType.Bamboo);
            stemCalculator.SetStemFormula(StemType.Astera, StemType.Gladiatus, StemType.Gladiatus);
            stemCalculator.SetStemFormula(StemType.Astera, StemType.Grass, StemType.Orchid);
            stemCalculator.SetStemFormula(StemType.Astera, StemType.Lemonbush, StemType.Ananas);
            stemCalculator.SetStemFormula(StemType.Astera, StemType.Maple, StemType.Maranta);
            stemCalculator.SetStemFormula(StemType.Astera, StemType.Maranta, StemType.Fern);
            stemCalculator.SetStemFormula(StemType.Astera, StemType.Multiflora, StemType.RareOak);
            stemCalculator.SetStemFormula(StemType.Astera, StemType.Orchid, StemType.Astera);
            stemCalculator.SetStemFormula(StemType.Astera, StemType.PearCactus, StemType.Lemonbush);
            stemCalculator.SetStemFormula(StemType.Astera, StemType.PipeCactus, StemType.Fanleaf);
            stemCalculator.SetStemFormula(StemType.Astera, StemType.Pitcher, StemType.Maple);
            stemCalculator.SetStemFormula(StemType.Astera, StemType.RareOak, StemType.Fanleaf);
            stemCalculator.SetStemFormula(StemType.Astera, StemType.Reptans, StemType.Grass);
            stemCalculator.SetStemFormula(StemType.Astera, StemType.Ridgeball, StemType.RareOak);
            stemCalculator.SetStemFormula(StemType.Astera, StemType.Scandens, StemType.Orchid);
            stemCalculator.SetStemFormula(StemType.Astera, StemType.TigerFern, StemType.Bamboo);
            stemCalculator.SetStemFormula(StemType.Astera, StemType.Weeper, StemType.Maple);

            stemCalculator.SetStemFormula(StemType.BallCactus, StemType.Bamboo, StemType.PipeCactus);
            stemCalculator.SetStemFormula(StemType.BallCactus, StemType.Fanleaf, StemType.RareOak);
            stemCalculator.SetStemFormula(StemType.BallCactus, StemType.Fern, StemType.Bamboo);
            stemCalculator.SetStemFormula(StemType.BallCactus, StemType.Glaber, StemType.Glaber);
            stemCalculator.SetStemFormula(StemType.BallCactus, StemType.Gladiatus, StemType.Bamboo);
            stemCalculator.SetStemFormula(StemType.BallCactus, StemType.Grass, StemType.Fanleaf);
            stemCalculator.SetStemFormula(StemType.BallCactus, StemType.Lemonbush, StemType.RareOak);
            stemCalculator.SetStemFormula(StemType.BallCactus, StemType.Maple, StemType.PipeCactus);
            stemCalculator.SetStemFormula(StemType.BallCactus, StemType.Maranta, StemType.Maple);
            stemCalculator.SetStemFormula(StemType.BallCactus, StemType.Multiflora, StemType.Pitcher);
            stemCalculator.SetStemFormula(StemType.BallCactus, StemType.Orchid, StemType.Lemonbush);
            stemCalculator.SetStemFormula(StemType.BallCactus, StemType.PearCactus, StemType.BallCactus);
            stemCalculator.SetStemFormula(StemType.BallCactus, StemType.PipeCactus, StemType.PearCactus);
            stemCalculator.SetStemFormula(StemType.BallCactus, StemType.Pitcher, StemType.TigerFern);
            stemCalculator.SetStemFormula(StemType.BallCactus, StemType.RareOak, StemType.PearCactus);
            stemCalculator.SetStemFormula(StemType.BallCactus, StemType.Reptans, StemType.Maranta);
            stemCalculator.SetStemFormula(StemType.BallCactus, StemType.Ridgeball, StemType.Pitcher);
            stemCalculator.SetStemFormula(StemType.BallCactus, StemType.Scandens, StemType.Fanleaf);
            stemCalculator.SetStemFormula(StemType.BallCactus, StemType.TigerFern, StemType.Glaber);
            stemCalculator.SetStemFormula(StemType.BallCactus, StemType.Weeper, StemType.TigerFern);

            stemCalculator.SetStemFormula(StemType.Bamboo, StemType.Fanleaf, StemType.Lemonbush);
            stemCalculator.SetStemFormula(StemType.Bamboo, StemType.Fern, StemType.Fanleaf);
            stemCalculator.SetStemFormula(StemType.Bamboo, StemType.Glaber, StemType.PipeCactus);
            stemCalculator.SetStemFormula(StemType.Bamboo, StemType.Gladiatus, StemType.Maranta);
            stemCalculator.SetStemFormula(StemType.Bamboo, StemType.Grass, StemType.Ananas);
            stemCalculator.SetStemFormula(StemType.Bamboo, StemType.Lemonbush, StemType.Bamboo);
            stemCalculator.SetStemFormula(StemType.Bamboo, StemType.Maple, StemType.Maple);
            stemCalculator.SetStemFormula(StemType.Bamboo, StemType.Maranta, StemType.Lemonbush);
            stemCalculator.SetStemFormula(StemType.Bamboo, StemType.Multiflora, StemType.BallCactus);
            stemCalculator.SetStemFormula(StemType.Bamboo, StemType.Orchid, StemType.Ananas);
            stemCalculator.SetStemFormula(StemType.Bamboo, StemType.PearCactus, StemType.RareOak);
            stemCalculator.SetStemFormula(StemType.Bamboo, StemType.Pitcher, StemType.PearCactus);
            stemCalculator.SetStemFormula(StemType.Bamboo, StemType.PipeCactus, StemType.RareOak);
            stemCalculator.SetStemFormula(StemType.Bamboo, StemType.RareOak, StemType.Maple);
            stemCalculator.SetStemFormula(StemType.Bamboo, StemType.Reptans, StemType.Fern);
            stemCalculator.SetStemFormula(StemType.Bamboo, StemType.Ridgeball, StemType.Glaber);
            stemCalculator.SetStemFormula(StemType.Bamboo, StemType.Scandens, StemType.Fern);
            stemCalculator.SetStemFormula(StemType.Bamboo, StemType.TigerFern, StemType.PearCactus);
            stemCalculator.SetStemFormula(StemType.Bamboo, StemType.Weeper, StemType.BallCactus);

            stemCalculator.SetStemFormula(StemType.Fanleaf, StemType.Fern, StemType.Maranta);
            stemCalculator.SetStemFormula(StemType.Fanleaf, StemType.Glaber, StemType.RareOak);
            stemCalculator.SetStemFormula(StemType.Fanleaf, StemType.Gladiatus, StemType.Ananas);
            stemCalculator.SetStemFormula(StemType.Fanleaf, StemType.Grass, StemType.Fern);
            stemCalculator.SetStemFormula(StemType.Fanleaf, StemType.Lemonbush, StemType.Lemonbush);
            stemCalculator.SetStemFormula(StemType.Fanleaf, StemType.Maple, StemType.Bamboo);
            stemCalculator.SetStemFormula(StemType.Fanleaf, StemType.Maranta, StemType.Fanleaf);
            stemCalculator.SetStemFormula(StemType.Fanleaf, StemType.Multiflora, StemType.PearCactus);
            stemCalculator.SetStemFormula(StemType.Fanleaf, StemType.Orchid, StemType.Fern);
            stemCalculator.SetStemFormula(StemType.Fanleaf, StemType.PearCactus, StemType.Maple);
            stemCalculator.SetStemFormula(StemType.Fanleaf, StemType.PipeCactus, StemType.Maple);
            stemCalculator.SetStemFormula(StemType.Fanleaf, StemType.Pitcher, StemType.PipeCactus);
            stemCalculator.SetStemFormula(StemType.Fanleaf, StemType.RareOak, StemType.Bamboo);
            stemCalculator.SetStemFormula(StemType.Fanleaf, StemType.Reptans, StemType.Gladiatus);
            stemCalculator.SetStemFormula(StemType.Fanleaf, StemType.Ridgeball, StemType.BallCactus);
            stemCalculator.SetStemFormula(StemType.Fanleaf, StemType.Scandens, StemType.Gladiatus);
            stemCalculator.SetStemFormula(StemType.Fanleaf, StemType.TigerFern, StemType.PipeCactus);
            stemCalculator.SetStemFormula(StemType.Fanleaf, StemType.Weeper, StemType.PearCactus);

            stemCalculator.SetStemFormula(StemType.Fern, StemType.Glaber, StemType.Maple);
            stemCalculator.SetStemFormula(StemType.Fern, StemType.Gladiatus, StemType.Fern);
            stemCalculator.SetStemFormula(StemType.Fern, StemType.Grass, StemType.Astera);
            stemCalculator.SetStemFormula(StemType.Fern, StemType.Lemonbush, StemType.Maranta);
            stemCalculator.SetStemFormula(StemType.Fern, StemType.Maple, StemType.Fanleaf);
            stemCalculator.SetStemFormula(StemType.Fern, StemType.Maranta, StemType.Ananas);
            stemCalculator.SetStemFormula(StemType.Fern, StemType.Multiflora, StemType.PipeCactus);
            stemCalculator.SetStemFormula(StemType.Fern, StemType.Orchid, StemType.Gladiatus);
            stemCalculator.SetStemFormula(StemType.Fern, StemType.PearCactus, StemType.Bamboo);
            stemCalculator.SetStemFormula(StemType.Fern, StemType.PipeCactus, StemType.Lemonbush);
            stemCalculator.SetStemFormula(StemType.Fern, StemType.Pitcher, StemType.RareOak);
            stemCalculator.SetStemFormula(StemType.Fern, StemType.RareOak, StemType.Lemonbush);
            stemCalculator.SetStemFormula(StemType.Fern, StemType.Reptans, StemType.Orchid);
            stemCalculator.SetStemFormula(StemType.Fern, StemType.Ridgeball, StemType.PipeCactus);
            stemCalculator.SetStemFormula(StemType.Fern, StemType.Scandens, StemType.Astera);
            stemCalculator.SetStemFormula(StemType.Fern, StemType.TigerFern, StemType.Maple);
            stemCalculator.SetStemFormula(StemType.Fern, StemType.Weeper, StemType.RareOak);

            stemCalculator.SetStemFormula(StemType.Glaber, StemType.Gladiatus, StemType.Bamboo);
            stemCalculator.SetStemFormula(StemType.Glaber, StemType.Grass, StemType.Lemonbush);
            stemCalculator.SetStemFormula(StemType.Glaber, StemType.Lemonbush, StemType.PipeCactus);
            stemCalculator.SetStemFormula(StemType.Glaber, StemType.Maple, StemType.PearCactus);
            stemCalculator.SetStemFormula(StemType.Glaber, StemType.Maranta, StemType.RareOak);
            stemCalculator.SetStemFormula(StemType.Glaber, StemType.Multiflora, StemType.Pitcher);
            stemCalculator.SetStemFormula(StemType.Glaber, StemType.Orchid, StemType.Lemonbush);
            stemCalculator.SetStemFormula(StemType.Glaber, StemType.PearCactus, StemType.BallCactus);
            stemCalculator.SetStemFormula(StemType.Glaber, StemType.PipeCactus, StemType.BallCactus);
            stemCalculator.SetStemFormula(StemType.Glaber, StemType.Pitcher, StemType.TigerFern);
            stemCalculator.SetStemFormula(StemType.Glaber, StemType.RareOak, StemType.PearCactus);
            stemCalculator.SetStemFormula(StemType.Glaber, StemType.Reptans, StemType.Fanleaf);
            stemCalculator.SetStemFormula(StemType.Glaber, StemType.Ridgeball, StemType.Weeper);
            stemCalculator.SetStemFormula(StemType.Glaber, StemType.Scandens, StemType.Fanleaf);
            stemCalculator.SetStemFormula(StemType.Glaber, StemType.TigerFern, StemType.TigerFern);
            stemCalculator.SetStemFormula(StemType.Glaber, StemType.Weeper, StemType.Pitcher);

            stemCalculator.SetStemFormula(StemType.Gladiatus, StemType.Grass, StemType.Astera);
            stemCalculator.SetStemFormula(StemType.Gladiatus, StemType.Lemonbush, StemType.Maranta);
            stemCalculator.SetStemFormula(StemType.Gladiatus, StemType.Orchid, StemType.Astera);
            stemCalculator.SetStemFormula(StemType.Gladiatus, StemType.Maple, StemType.Fanleaf);
            stemCalculator.SetStemFormula(StemType.Gladiatus, StemType.Maranta, StemType.Ananas);
            stemCalculator.SetStemFormula(StemType.Gladiatus, StemType.Multiflora, StemType.RareOak);
            stemCalculator.SetStemFormula(StemType.Gladiatus, StemType.PearCactus, StemType.Lemonbush);
            stemCalculator.SetStemFormula(StemType.Gladiatus, StemType.PipeCactus, StemType.Lemonbush);
            stemCalculator.SetStemFormula(StemType.Gladiatus, StemType.Pitcher, StemType.Maple);
            stemCalculator.SetStemFormula(StemType.Gladiatus, StemType.RareOak, StemType.Fanleaf);
            stemCalculator.SetStemFormula(StemType.Gladiatus, StemType.Reptans, StemType.Orchid);
            stemCalculator.SetStemFormula(StemType.Gladiatus, StemType.Ridgeball, StemType.PipeCactus);
            stemCalculator.SetStemFormula(StemType.Gladiatus, StemType.Scandens, StemType.Orchid);
            stemCalculator.SetStemFormula(StemType.Gladiatus, StemType.TigerFern, StemType.Maple);
            stemCalculator.SetStemFormula(StemType.Gladiatus, StemType.Weeper, StemType.RareOak);

            stemCalculator.SetStemFormula(StemType.Grass, StemType.Lemonbush, StemType.Fern);
            stemCalculator.SetStemFormula(StemType.Grass, StemType.Maple, StemType.Ananas);
            stemCalculator.SetStemFormula(StemType.Grass, StemType.Maranta, StemType.Gladiatus);
            stemCalculator.SetStemFormula(StemType.Grass, StemType.Multiflora, StemType.Maple);
            stemCalculator.SetStemFormula(StemType.Grass, StemType.Orchid, StemType.Orchid);
            stemCalculator.SetStemFormula(StemType.Grass, StemType.PearCactus, StemType.Fanleaf);
            stemCalculator.SetStemFormula(StemType.Grass, StemType.PipeCactus, StemType.Maranta);
            stemCalculator.SetStemFormula(StemType.Grass, StemType.Pitcher, StemType.Bamboo);
            stemCalculator.SetStemFormula(StemType.Grass, StemType.RareOak, StemType.Maranta);
            stemCalculator.SetStemFormula(StemType.Grass, StemType.Reptans, StemType.Scandens);
            stemCalculator.SetStemFormula(StemType.Grass, StemType.Ridgeball, StemType.Maple);
            stemCalculator.SetStemFormula(StemType.Grass, StemType.Scandens, StemType.Grass);
            stemCalculator.SetStemFormula(StemType.Grass, StemType.TigerFern, StemType.Lemonbush);
            stemCalculator.SetStemFormula(StemType.Grass, StemType.Weeper, StemType.Bamboo);

            stemCalculator.SetStemFormula(StemType.Lemonbush, StemType.Maple, StemType.Bamboo);
            stemCalculator.SetStemFormula(StemType.Lemonbush, StemType.Maranta, StemType.Fanleaf);
            stemCalculator.SetStemFormula(StemType.Lemonbush, StemType.Multiflora, StemType.BallCactus);
            stemCalculator.SetStemFormula(StemType.Lemonbush, StemType.Orchid, StemType.Ananas);
            stemCalculator.SetStemFormula(StemType.Lemonbush, StemType.PearCactus, StemType.RareOak);
            stemCalculator.SetStemFormula(StemType.Lemonbush, StemType.PipeCactus, StemType.Maple);
            stemCalculator.SetStemFormula(StemType.Lemonbush, StemType.Pitcher, StemType.PearCactus);
            stemCalculator.SetStemFormula(StemType.Lemonbush, StemType.RareOak, StemType.Maple);
            stemCalculator.SetStemFormula(StemType.Lemonbush, StemType.Reptans, StemType.Gladiatus);
            stemCalculator.SetStemFormula(StemType.Lemonbush, StemType.Ridgeball, StemType.BallCactus);
            stemCalculator.SetStemFormula(StemType.Lemonbush, StemType.Scandens, StemType.Fern);
            stemCalculator.SetStemFormula(StemType.Lemonbush, StemType.TigerFern, StemType.PipeCactus);
            stemCalculator.SetStemFormula(StemType.Lemonbush, StemType.Weeper, StemType.PearCactus);

            stemCalculator.SetStemFormula(StemType.Maple, StemType.Maranta, StemType.Lemonbush);
            stemCalculator.SetStemFormula(StemType.Maple, StemType.Multiflora, StemType.Glaber);
            stemCalculator.SetStemFormula(StemType.Maple, StemType.Orchid, StemType.Maranta);
            stemCalculator.SetStemFormula(StemType.Maple, StemType.PearCactus, StemType.PipeCactus);
            stemCalculator.SetStemFormula(StemType.Maple, StemType.PipeCactus, StemType.RareOak);
            stemCalculator.SetStemFormula(StemType.Maple, StemType.Pitcher, StemType.BallCactus);
            stemCalculator.SetStemFormula(StemType.Maple, StemType.RareOak, StemType.RareOak);
            stemCalculator.SetStemFormula(StemType.Maple, StemType.Reptans, StemType.Fern);
            stemCalculator.SetStemFormula(StemType.Maple, StemType.Ridgeball, StemType.Glaber);
            stemCalculator.SetStemFormula(StemType.Maple, StemType.Scandens, StemType.Ananas);
            stemCalculator.SetStemFormula(StemType.Maple, StemType.TigerFern, StemType.PearCactus);
            stemCalculator.SetStemFormula(StemType.Maple, StemType.Weeper, StemType.BallCactus);

            stemCalculator.SetStemFormula(StemType.Maranta, StemType.Multiflora, StemType.PearCactus);
            stemCalculator.SetStemFormula(StemType.Maranta, StemType.Orchid, StemType.Fern);
            stemCalculator.SetStemFormula(StemType.Maranta, StemType.PearCactus, StemType.Maple);
            stemCalculator.SetStemFormula(StemType.Maranta, StemType.PipeCactus, StemType.Bamboo);
            stemCalculator.SetStemFormula(StemType.Maranta, StemType.Pitcher, StemType.PipeCactus);
            stemCalculator.SetStemFormula(StemType.Maranta, StemType.RareOak, StemType.Bamboo);
            stemCalculator.SetStemFormula(StemType.Maranta, StemType.Reptans, StemType.Astera);
            stemCalculator.SetStemFormula(StemType.Maranta, StemType.Ridgeball, StemType.PearCactus);
            stemCalculator.SetStemFormula(StemType.Maranta, StemType.Scandens, StemType.Gladiatus);
            stemCalculator.SetStemFormula(StemType.Maranta, StemType.TigerFern, StemType.RareOak);
            stemCalculator.SetStemFormula(StemType.Maranta, StemType.Weeper, StemType.PipeCactus);

            stemCalculator.SetStemFormula(StemType.Multiflora, StemType.Orchid, StemType.Maple);
            stemCalculator.SetStemFormula(StemType.Multiflora, StemType.PearCactus, StemType.TigerFern);
            stemCalculator.SetStemFormula(StemType.Multiflora, StemType.PipeCactus, StemType.TigerFern);
            stemCalculator.SetStemFormula(StemType.Multiflora, StemType.Pitcher, StemType.Weeper);
            stemCalculator.SetStemFormula(StemType.Multiflora, StemType.RareOak, StemType.Glaber);
            stemCalculator.SetStemFormula(StemType.Multiflora, StemType.Reptans, StemType.Bamboo);
            stemCalculator.SetStemFormula(StemType.Multiflora, StemType.Ridgeball, StemType.Ridgeball);
            stemCalculator.SetStemFormula(StemType.Multiflora, StemType.Scandens, StemType.Bamboo);
            stemCalculator.SetStemFormula(StemType.Multiflora, StemType.TigerFern, StemType.Weeper);
            stemCalculator.SetStemFormula(StemType.Multiflora, StemType.Weeper, StemType.Multiflora);

            stemCalculator.SetStemFormula(StemType.Orchid, StemType.PearCactus, StemType.Fanleaf);
            stemCalculator.SetStemFormula(StemType.Orchid, StemType.PipeCactus, StemType.Fanleaf);
            stemCalculator.SetStemFormula(StemType.Orchid, StemType.Pitcher, StemType.Bamboo);
            stemCalculator.SetStemFormula(StemType.Orchid, StemType.RareOak, StemType.Maranta);
            stemCalculator.SetStemFormula(StemType.Orchid, StemType.Reptans, StemType.Grass);
            stemCalculator.SetStemFormula(StemType.Orchid, StemType.Ridgeball, StemType.RareOak);
            stemCalculator.SetStemFormula(StemType.Orchid, StemType.Scandens, StemType.Grass);
            stemCalculator.SetStemFormula(StemType.Orchid, StemType.TigerFern, StemType.Bamboo);
            stemCalculator.SetStemFormula(StemType.Orchid, StemType.Weeper, StemType.Maple);

            stemCalculator.SetStemFormula(StemType.PearCactus, StemType.PipeCactus, StemType.PearCactus);
            stemCalculator.SetStemFormula(StemType.PearCactus, StemType.Pitcher, StemType.Glaber);
            stemCalculator.SetStemFormula(StemType.PearCactus, StemType.RareOak, StemType.PipeCactus);
            stemCalculator.SetStemFormula(StemType.PearCactus, StemType.Reptans, StemType.Maranta);
            stemCalculator.SetStemFormula(StemType.PearCactus, StemType.Ridgeball, StemType.Pitcher);
            stemCalculator.SetStemFormula(StemType.PearCactus, StemType.Scandens, StemType.Maranta);
            stemCalculator.SetStemFormula(StemType.PearCactus, StemType.TigerFern, StemType.Glaber);
            stemCalculator.SetStemFormula(StemType.PearCactus, StemType.Weeper, StemType.TigerFern);

            stemCalculator.SetStemFormula(StemType.PipeCactus, StemType.Pitcher, StemType.Glaber);
            stemCalculator.SetStemFormula(StemType.PipeCactus, StemType.RareOak, StemType.PipeCactus);
            stemCalculator.SetStemFormula(StemType.PipeCactus, StemType.Reptans, StemType.Ananas);
            stemCalculator.SetStemFormula(StemType.PipeCactus, StemType.Ridgeball, StemType.TigerFern);
            stemCalculator.SetStemFormula(StemType.PipeCactus, StemType.Scandens, StemType.Maranta);
            stemCalculator.SetStemFormula(StemType.PipeCactus, StemType.TigerFern, StemType.BallCactus);
            stemCalculator.SetStemFormula(StemType.PipeCactus, StemType.Weeper, StemType.Glaber);

            stemCalculator.SetStemFormula(StemType.Pitcher, StemType.RareOak, StemType.BallCactus);
            stemCalculator.SetStemFormula(StemType.Pitcher, StemType.Reptans, StemType.Lemonbush);
            stemCalculator.SetStemFormula(StemType.Pitcher, StemType.Ridgeball, StemType.Multiflora);
            stemCalculator.SetStemFormula(StemType.Pitcher, StemType.Scandens, StemType.Lemonbush);
            stemCalculator.SetStemFormula(StemType.Pitcher, StemType.TigerFern, StemType.Pitcher);
            stemCalculator.SetStemFormula(StemType.Pitcher, StemType.Weeper, StemType.Weeper);

            stemCalculator.SetStemFormula(StemType.RareOak, StemType.Reptans, StemType.Ananas);
            stemCalculator.SetStemFormula(StemType.RareOak, StemType.Ridgeball, StemType.TigerFern);
            stemCalculator.SetStemFormula(StemType.RareOak, StemType.TigerFern, StemType.BallCactus);
            stemCalculator.SetStemFormula(StemType.RareOak, StemType.Scandens, StemType.Ananas);
            stemCalculator.SetStemFormula(StemType.RareOak, StemType.Weeper, StemType.Glaber);

            stemCalculator.SetStemFormula(StemType.Reptans, StemType.Ridgeball, StemType.Bamboo);
            stemCalculator.SetStemFormula(StemType.Reptans, StemType.Scandens, StemType.Scandens);
            stemCalculator.SetStemFormula(StemType.Reptans, StemType.TigerFern, StemType.Fanleaf);
            stemCalculator.SetStemFormula(StemType.Reptans, StemType.Weeper, StemType.Lemonbush);

            stemCalculator.SetStemFormula(StemType.Ridgeball, StemType.Scandens, StemType.Maple);
            stemCalculator.SetStemFormula(StemType.Ridgeball, StemType.TigerFern, StemType.Weeper);
            stemCalculator.SetStemFormula(StemType.Ridgeball, StemType.Weeper, StemType.Multiflora);

            stemCalculator.SetStemFormula(StemType.Scandens, StemType.TigerFern, StemType.Lemonbush);
            stemCalculator.SetStemFormula(StemType.Scandens, StemType.Weeper, StemType.Bamboo);

            stemCalculator.SetStemFormula(StemType.TigerFern, StemType.Weeper, StemType.Pitcher);
        }
    }
}
