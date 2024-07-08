using GildedRoseKata.Interfaces;
using GildedRoseKata.Items;

namespace GildedRoseKata;

public static class Factory
{
    public static ILegendaryItem CreateLegendary()
    {
        return new BaseLegendaryItem();
    }

    public static IUpdatableItem CreateConuredItem()
    {
        return new Conjured();
    }

    public static IUpdatableItem CreateBackstagePass()
    {
        return new BackstagePass();
    }

    public static IUpdatableItem CreateNormalItem()
    {
        return new NormalItem();
    }

    public static IUpdatableItem CreateAgedBrie()
    {
        return new AgedBrie();
    }
}