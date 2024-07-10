using System;
using GildedRoseKata.Interfaces;
using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Items;

public class Valanyr : ILegendaryItem
{
    public string Name { get; } = "Val'anyr, Hammer of Ancient Kings";
    public SellIn SellIn { get; }
    public Quality Quality { get; }

    public Valanyr(SellIn sellIn, Quality quality)
    {
        Quality = quality;
        SellIn = sellIn;
    }
}