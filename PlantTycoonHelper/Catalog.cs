using PlantTycoon.Domain;
using System.Collections.Generic;
using System.Linq;

namespace PlantTycoonHelper
{
    public class Catalog
    {
        public HashSet<Plant> Plants { get; set; }

        public Catalog()
        {
            Initialize();
        }

        protected void Add(Plant plant)
        {
            Plants.Add(plant);
        }

        protected void Initialize()
        {
            var builder = new CatalogBuilder();
            Plants = builder.BuildFromFile();
        }
    }

    public class CatalogBuilder
    {
        private const string filePath = "Catalog.txt";

        public HashSet<Plant> BuildFromFile()
        {
            var catalogFileReader = new TextFileReader(filePath);
            var plantTextLines = catalogFileReader.ReadAllDistinctWithoutEmptyLines();

            var plants = new HashSet<Plant>();
            plantTextLines.ToList().ForEach(plantTextLine => plants.Add(CreatePlantFromTextLine(plantTextLine)));

            return plants;
        }

        protected Plant CreatePlantFromTextLine(string plantTextLine)
        {
            var splittedLine = plantTextLine.Split(" ");
            if (splittedLine.Length != 2) throw new System.ArgumentException($"Invalid line from file: {plantTextLine}");
            return new Plant(splittedLine[0], splittedLine[1]);
        }
    }

    public class TextFileReader
    {
        private readonly string filePath;

        public TextFileReader(string filePath)
        {
            this.filePath = filePath;
        }

        public HashSet<string> ReadAllDistinctWithoutEmptyLines()
        {
            ICollection<string> lines = System.IO.File.ReadAllLines(this.filePath);
            lines.Remove(string.Empty);
            return lines.Distinct().ToHashSet();
        }
    }
}
