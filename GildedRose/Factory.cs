using System.Collections.Generic;
using System.Collections.ObjectModel;
using GildedRoseKata.Interfaces;
using GildedRoseKata.Items;

namespace GildedRoseKata;

public static class Factory
{
    public static GildedRose CreateGildedRoseInConsole()
    {
        return new GildedRose(SeedData.ObtainItems(),new ConsolePrinter());
    }

    public static ILegendaryItem CreateLegendary()
    {
        return new BaseLegendaryItem(){};
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