using GildedRoseKata.Interfaces;

namespace GildedRoseKata.Extensions;

public static class SellInExtensions
{
    public static void UpdateSellIn(this IUpdatableItem item)
    {
        item.SellIn--;
    }
}