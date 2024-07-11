using GildedRoseKata.Items;
using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Interfaces.ItemFactory.LegendaryItemFactory;

public class ThunderfuryFactory : ILegendaryItemFactory
{
    public ILegendaryItem CreateItem(SellIn sellIn, Quality quality)
    {
        return new Thunderfury(sellIn, quality);
    }
}