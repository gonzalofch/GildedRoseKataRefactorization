using GildedRoseKata.Interfaces;
using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Items;

public class Sulfuras : IInmutableItem
{
    public string Name { get; set; }
    public SellIn SellIn { get;set; }
    public Quality Quality { get;set; }

    public Sulfuras(int sellIn, int quality)
    {
        Name = "Sulfuras, Hand of Ragnaros";
        Quality = new Quality(quality);
        SellIn = new SellIn(sellIn);
    }

    public Sulfuras()
    {
        Name = "Sulfuras, Hand of Ragnaros";
    }
}