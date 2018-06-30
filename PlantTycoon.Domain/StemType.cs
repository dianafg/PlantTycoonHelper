using System;

namespace PlantTycoon.Domain
{
    public enum  StemType
    {
        Ananas = 1,
        Astera,
        BallCactus,
        Bamboo,
        Fanleaf,
        Fern,
        Glaber,
        Gladiatus,
        Grass,
        Lemonbush,
        Maple,
        Maranta,
        Multiflora,
        Orchid,
        PearCactus,
        PipeCactus,
        Pitcher,
        RareOak,
        Reptans,
        Ridgeball,
        Scandens,
        TigerFern,
        Weeper
    }

    public static class StemTypeExtensions
    {
        public static StemType? ToStemType(this string stemTypeName)
        {
            try
            {
                return (StemType)Enum.Parse(typeof(StemType), stemTypeName, ignoreCase: true);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
