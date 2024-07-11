using GildedRoseKata.Items;
using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Interfaces.ItemFactory.LegendaryItemFactory;

public class AtieshFactory : ILegendaryItemFactory
{
    public ILegendaryItem CreateItem(SellIn sellIn, Quality quality)
    {
        return new Atiesh(sellIn, quality);
    }
}