using System;

namespace GildedRoseKata.Validators;

public static class QualityValidator
{
    const int MinQuality = 0;
    const int MaxQuality = 50;
    
    public static bool IsOverMaximumQuality(this int quality)
    {
        return quality > MaxQuality;
    }

    public static bool IsBellowMinimumQuality(this int quality)
    {
        return quality < MinQuality;
    }
}