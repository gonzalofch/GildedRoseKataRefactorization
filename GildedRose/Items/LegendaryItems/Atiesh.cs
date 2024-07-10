using System;
using GildedRoseKata.Interfaces;
using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Items;

public class Atiesh : ILegendaryItem
{
    public string Name { get; } = "Atiesh, Greatstaff Of The Guardian";
    public SellIn SellIn { get; }
    public Quality Quality { get; }

    public Atiesh(SellIn sellIn, Quality quality)
    {
        Quality = quality;
        SellIn = sellIn;
    }
}