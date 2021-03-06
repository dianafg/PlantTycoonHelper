﻿using PlantTycoon.Data;
using PlantTycoon.Domain;
using System.Collections.Generic;
using System.Linq;

namespace PlantTycoonHelper
{
    public class Catalog
    {
        public IEnumerable<Plant> Plants { get; set; }

        public Catalog()
        {
            Initialize();
        }

        public void Reseed()
        {
            using (var dbContext = new PlantTycoonContext())
            {
                InitializeEmptyCatalog(dbContext);
                dbContext.AddRange(Plants);
                dbContext.SaveChanges();
            }
        }

        protected void InitializeEmptyCatalog(PlantTycoonContext dbContext)
        {
            dbContext.Plants.RemoveRange(dbContext.Plants.Where(x => 1 == 1));
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

        public IEnumerable<Plant> BuildFromFile()
        {
            var catalogFileReader = new TextFileReader(filePath);
            var plantTextLines = catalogFileReader.ReadAllDistinctWithoutEmptyLines();

            var plants = new HashSet<Plant>();
            plantTextLines.ToList().ForEach(plantTextLine => plants.Add(CreatePlantFromTextLine(plantTextLine)));
            var orderedPlants = plants.OrderBy(x => x.Flower).ThenBy(x => x.Stem);
            return orderedPlants;
        }

        protected Plant CreatePlantFromTextLine(string plantTextLine)
        {
            var splittedLine = plantTextLine.Split(" ");
            if (splittedLine.Length != 2 && splittedLine.Length != 3)
                throw new System.ArgumentException($"Invalid line from file: {plantTextLine}");
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

        public IEnumerable<string> ReadAllDistinctWithoutEmptyLines()
        {
            HashSet<string> lines = System.IO.File.ReadAllLines(this.filePath).ToHashSet();
            lines.Remove(string.Empty);
            return lines.AsEnumerable();
        }
    }
}
