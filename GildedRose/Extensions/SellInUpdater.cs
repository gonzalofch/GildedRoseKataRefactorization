using GildedRoseKata.Interfaces;

namespace GildedRoseKata.Extensions;

public static class SellInUpdater
{
    public static void UpdateSellIn(this IUpdatableItem item)
    {
        item.SellIn--;
    }
}