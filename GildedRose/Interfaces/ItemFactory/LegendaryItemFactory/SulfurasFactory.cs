using GildedRoseKata.Items;
using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Interfaces.ItemFactory.LegendaryItemFactory;

public class SulfurasFactory : ILegendaryItemFactory
{
    public ILegendaryItem CreateItem(SellIn sellIn, Quality quality)
    {
        return new Sulfuras(sellIn, quality);
    }
}