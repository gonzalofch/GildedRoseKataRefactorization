using System;
using System.Collections.Generic;
using GildedRoseKata.Interfaces;
using GildedRoseKata.Interfaces.ItemFactory;
using GildedRoseKata.Interfaces.ItemFactory.LegendaryItemFactory;
using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Services;

public class LegendaryItemFactoryProvider
{
    private readonly Dictionary<LegendaryItems, ILegendaryItemFactory> _legendaryItemFactoriesfactories;

    public LegendaryItemFactoryProvider()
    {
        _legendaryItemFactoriesfactories = new Dictionary<LegendaryItems, ILegendaryItemFactory>
        {
            { LegendaryItems.AtieshGreatstaffOfTheGuardian, new AtieshFactory() },
            { LegendaryItems.Shadowmourne, new ShadowmourneFactory() },
            { LegendaryItems.SulfurasHandOfRagnaros, new SulfurasFactory() },
            { LegendaryItems.ThunderfuryBlessedBladeOfTheWindseeker, new ThunderfuryFactory() },
            { LegendaryItems.ValanyrHammerOfAncientKings, new ValanyrFactory() },
        };
    }

    public ILegendaryItem CreateItem(LegendaryItems item, SellIn sellIn, Quality quality)
    {
        if (!_legendaryItemFactoriesfactories.TryGetValue(item, out var factory))
        {
            throw new ArgumentException("Invalid legendary item");
        }

        return factory.CreateItem(sellIn, quality);
    }
}