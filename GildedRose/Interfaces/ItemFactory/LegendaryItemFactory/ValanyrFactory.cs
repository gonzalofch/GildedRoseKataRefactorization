using GildedRoseKata.Items;
using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Interfaces.ItemFactory.LegendaryItemFactory;

public class ValanyrFactory : ILegendaryItemFactory
{
    public ILegendaryItem CreateItem(SellIn sellIn, Quality quality)
    {
        return new Valanyr(sellIn, quality);
    }
}