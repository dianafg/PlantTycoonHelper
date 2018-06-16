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
        Multiflora,
        Orchid,
        PearCactus,
        PipeCactus,
        Pitcher,
        RareOak,
        Reptans,
        Scandens,
        TigerFern,
        Weeper
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
