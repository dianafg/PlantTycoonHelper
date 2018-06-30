using System;

namespace PlantTycoon.Domain
{
    public class StemFormula
    {
        public int Id { get; protected set; }
        public StemType StemA { get; protected set; }
        public StemType StemB { get; protected set; }
        public StemType? Result { get; set; }
        public bool InProgress { get; set; }

        protected StemFormula() { }   //For EF

        public StemFormula(StemType stemA, StemType stemB, StemType? result = null)
        {
            this.StemA = stemA;
            this.StemB = stemB;
            this.Result = result;
        }

        public static StemFormula CreateFromStemTypeNames(string stemTypeNameA, string stemTypeNameB)
        {
            var stemTypeA = (StemType)Enum.Parse(typeof(StemType), stemTypeNameA);
            var stemTypeB = (StemType)Enum.Parse(typeof(StemType), stemTypeNameB);
            return new StemFormula(stemTypeA, stemTypeB);
        }

        public static StemFormula CreateFromStemTypeNames(string stemTypeNameA, string stemTypeNameB, string stemTypeNameResult)
        {
            var stemTypeResult = (StemType)Enum.Parse(typeof(StemType), stemTypeNameResult);
            var stemFormula = CreateFromStemTypeNames(stemTypeNameA, stemTypeNameB);
            stemFormula.Result = stemTypeResult;
            return stemFormula;
        }

        public void SetResultAndInProgress(StemType? result, bool inProgress)
        {
            //Some consistency checkings for parameter combinations
            if (result == null && inProgress == false)
                throw new InvalidOperationException($"Result can only be null for formulas in progress.");

            if (result != null && inProgress == true)
                throw new InvalidOperationException($"Result must be null for formulas in progress.");

            this.Result = result;
            this.InProgress = inProgress;
        }
    }
}
