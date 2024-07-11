using GildedRoseKata.Items;
using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Interfaces.ItemFactory.LegendaryItemFactory;

public class ShadowmourneFactory : ILegendaryItemFactory
{
    public ILegendaryItem CreateItem(SellIn sellIn, Quality quality)
    {
        return new Shadowmourne(sellIn, quality);
    }
}