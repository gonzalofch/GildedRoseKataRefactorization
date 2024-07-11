using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Interfaces.ItemFactory;

public interface IItemFactory
{
    IItem CreateItem(SellIn sellIn, Quality quality);
}
