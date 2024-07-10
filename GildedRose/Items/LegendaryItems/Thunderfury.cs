using System;
using GildedRoseKata.Interfaces;
using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Items;

public class Thunderfury : ILegendaryItem
{
    public string Name { get; } = "Thunderfury, Blessed Blade Of The Windseeker";
    public SellIn SellIn { get; }
    public Quality Quality { get; }

    public Thunderfury(SellIn sellIn, Quality quality)
    {
        Quality = quality;
        SellIn = sellIn;
    }
}