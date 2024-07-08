using GildedRoseKata.Interfaces;

namespace GildedRoseKata.Items;

public class Sulfuras : IInmutableItem
{
    public string Name { get; set; }
    public int Quality { get; set; }
    public int SellIn { get; set; }
    
    public Sulfuras(int sellIn, int quality)
    {
        Name = "Sulfuras, Hand of Ragnaros";
        Quality = quality;
        SellIn = sellIn;
    }
}