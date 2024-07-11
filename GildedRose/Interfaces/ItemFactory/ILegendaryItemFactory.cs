using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Interfaces.ItemFactory;

public interface ILegendaryItemFactory
{
    ILegendaryItem CreateItem(SellIn sellIn, Quality quality);
}