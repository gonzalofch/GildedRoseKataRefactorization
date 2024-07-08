using GildedRoseKata.Interfaces;
using GildedRoseKata.Validators;
namespace GildedRoseKata.Extensions;

public static class QualityExtensions
{
    public static void ChangeQuality(this IUpdatableItem item, int addedQuality)
    {
        if (item.Quality.IsOverMaximumQuality()) return;
        item.Quality += addedQuality;
        if (item.Quality.IsBellowMinimumQuality()) item.Quality = 0;
        if (item.Quality. IsOverMaximumQuality()) item.Quality = 50;
    }
}