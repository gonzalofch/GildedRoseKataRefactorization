using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GildedRoseKata.Enums;
using GildedRoseKata.Interfaces;
using GildedRoseKata.Interfaces.ItemFactory;
using GildedRoseKata.Interfaces.ItemFactory.LegendaryItemFactory;
using GildedRoseKata.Items;
using GildedRoseKata.Services;
using GildedRoseKata.ValueObjects;

namespace GildedRoseKata;

public class Factory
{
    private static LegendaryItemFactory _legendaryFactory;

    public Factory(LegendaryItemFactory legendaryItemFactory)
    {
        _legendaryFactory = legendaryItemFactory;
    }

    public static GildedRose CreateGildedRoseInConsole()
    {
        return new GildedRose(SeedData.ObtainItems(), new ConsolePrinter());
    }

    public static ILegendaryItem CreateLegendary(LegendaryItems item, SellIn sellIn, Quality quality)
    {
        return _legendaryFactory.CreateItem(item, sellIn, quality);
    }

    public static IUpdatableItem CreateConuredItem(string name, SellIn sellIn, Quality quality)
    {
        return new Conjured(name, sellIn, quality);
    }

    public static IUpdatableItem CreateBackstagePass(SellIn sellIn, Quality quality)
    {
        return new BackstagePass(sellIn, quality);
    }

    public static IUpdatableItem CreateNormalItem(string name, SellIn sellIn, Quality quality)
    {
        return new NormalItem(name, sellIn, quality);
    }

    public static IUpdatableItem CreateAgedBrie(SellIn sellIn, Quality quality)
    {
        return new AgedBrie(sellIn, quality);
    }
}