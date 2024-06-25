namespace GildedRoseKata.Items;

public class Sulfuras:ItemBase
{
    public Sulfuras(int sellIn, int quality) : base( sellIn, quality)
    {
        Name = "Sulfuras, Hand of Ragnaros";
    }

    public override void UpdateQuality()
    {
        
    }
}