using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantTycoon.Domain
{
    public class Seed
    {
        private static int tableColumns = 20;
        private static int tableRows = 4;

        public int Id { get; protected set; }

        protected string PositionSection { get; set; }
        protected int PositionRow { get; set; }
        protected int PositionColumn { get; set; }
        public Tuple<char, int, int> Position
        {
            get
            {
                return Tuple.Create<char, int, int>(PositionSection[0], PositionRow, PositionColumn);
            }
            set
            {
                PositionSection = value.Item1.ToString();
                PositionRow = value.Item2;
                PositionColumn = value.Item3;
            }
        }

        public FlowerType Flower { get; protected set; }
        public StemType Stem { get; protected set; }

        protected Seed() { }

        public Seed(Tuple<char, int, int> position, FlowerType flower, StemType stem)
        {
            ValidatePosition(position);
            this.Position = position;
            this.Flower = flower;
            this.Stem = stem;
        }

        private void ValidatePosition(Tuple<char, int, int> position)
        {
            ValidatePositionChar(position.Item1);
            ValidatePositionRow(position.Item2);
            ValidatePositionColumn(position.Item3);
        }

        private void ValidatePositionChar(char positionChar)
        {
            var validChars = new List<char> { 'A', 'B', 'C' };
            if (!validChars.Any(x => x == positionChar.ToString().ToUpper().ToCharArray()[0]))
            {
                throw new ArgumentException($"Wrong position char: {positionChar}");
            }
        }

        private void ValidatePositionRow(int positionRow)
        {
            if (positionRow < 1 || positionRow > tableRows)
            {
                throw new ArgumentException($"Wrong row number {positionRow}: must be between 1 and {tableRows - 1}");
            }
        }

        private void ValidatePositionColumn(int positionColumn)
        {
            if (positionColumn < 1 || positionColumn > tableColumns)
            {
                throw new ArgumentException($"Wrong column number {positionColumn}: must be between 1 and {tableColumns - 1}");
            }
        }
    }
}
