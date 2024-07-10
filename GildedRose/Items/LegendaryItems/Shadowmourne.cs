using System;
using GildedRoseKata.Interfaces;
using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Items;

public class Shadowmourne : ILegendaryItem
{
    public string Name { get; } = "Shadowmourne";
    public SellIn SellIn { get; }
    public Quality Quality { get; }

    public Shadowmourne(SellIn sellIn, Quality quality)
    {
        Quality = quality;
        SellIn = sellIn;
    }
}