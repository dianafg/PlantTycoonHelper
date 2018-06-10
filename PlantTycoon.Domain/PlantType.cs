using System;

namespace PlantTycoon.Domain
{
    public enum  PlantType
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
        Orchid,
        PearCactus,
        PipeCactus,
        RareOak,
        Reptans,
        Scandens,
        TigerFern
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
