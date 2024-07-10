using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GildedRoseKata.Interfaces;
using GildedRoseKata.Items;
using GildedRoseKata.ValueObjects;

namespace GildedRoseKata;

public static class Factory
{
    public static GildedRose CreateGildedRoseInConsole()
    {
        return new GildedRose(SeedData.ObtainItems(), new ConsolePrinter());
    }

    public static ILegendaryItem CreateLegendary(LegendaryItems item, SellIn sellIn, Quality quality)
    {
        return item switch
        {
            LegendaryItems.SulfurasHandOfRagnaros => new Sulfuras(sellIn, quality),
            LegendaryItems.ThunderfuryBlessedBladeOfTheWindseeker => new Thunderfury(sellIn, quality),
            LegendaryItems.AtieshGreatstaffOfTheGuardian => new Atiesh(sellIn, quality),
            LegendaryItems.Shadowmourne => new Shadowmourne(sellIn, quality),
            LegendaryItems.ValanyrHammerOfAncientKings => new Valanyr(sellIn, quality),
            //aqui si tuviera mas clases las implementaria, pero como no tengo pues fue
            // LegendaryItems.DragonwrathTarecgosasRest => new Dragonwrath(sellIn, quality),
            // LegendaryItems.FangsOfTheFather => new FangsOfTheFather(sellIn, quality),
            // LegendaryItems.WarglaivesOfAzzinoth => new Warglaives(sellIn, quality),
            // LegendaryItems.ThoridalTheStarsFury => new Thoridal(sellIn, quality),
            // LegendaryItems.GlaiveOfTheStormrage => new Glaive(sellIn, quality),
            _ => throw new ArgumentException("Invalid legendary item")
        };
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