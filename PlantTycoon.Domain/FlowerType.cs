using System;

namespace PlantTycoon.Domain
{
    public enum FlowerType
    {
        Arthurium = 1,
        Aureus,
        Blazing,
        Bluestar,
        Citrus,
        Daisy,
        Fabled,
        Fourpetal,
        Fragrant,
        Jalapa,
        Mela,
        Mystic,
        Nox,
        Painted,
        Rosaceae,
        Spotted,
        Tahitian,
        Tilia,
        Venomous,
        Venus,
        Viola
    }

    public static class FlowerTypeExtensions
    {
        public static FlowerType? ToFlowerType(this string flowerTypeName)
        {
            try
            {
                return (FlowerType)Enum.Parse(typeof(FlowerType), flowerTypeName, ignoreCase: true);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
