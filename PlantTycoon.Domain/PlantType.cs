using System;

namespace PlantTycoon.Domain
{
    public enum  PlantType
    {
        Ananas,
        Astera,
        BallCactus,
        Bamboo,
        Fanleaf,
        Fern,
        Gladiatus,
        Grass,
        Lemonbush,
        Maple,
        Maranta,
        Orchid,
        PipeCactus,
        RareOak,
        Reptans,
        Scandens
    }

    public static class PlantTypeExtensions
    {
        public static PlantType? ToPlantType(this string plantTypeName)
        {
            try
            {
                return (PlantType)Enum.Parse(typeof(PlantType), plantTypeName, ignoreCase: true);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
