using GildedRoseKata.Interfaces;
using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Items;

public class Sulfuras : ILegendaryItem
{
    public string Name { get; } = "Sulfuras, Hand of Ragnaros";
    public SellIn SellIn { get; }
    public Quality Quality { get; }

    public Sulfuras(SellIn sellIn, Quality quality)
    {
        Quality = quality;
        SellIn = sellIn;
    }
}