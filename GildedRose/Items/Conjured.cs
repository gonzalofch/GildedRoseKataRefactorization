using GildedRoseKata.Interfaces;
using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Items;

public class Conjured : IUpdatableItem
{
    public string Name { get; set; }
    public SellIn SellIn { get; set; }
    public Quality Quality { get; set; }

    public Conjured(string name, SellIn sellIn, Quality quality)
    {
        Name = name;
        SellIn = sellIn;
        Quality = quality;
    }
    
    public void Update()
    {
        SellIn.UpdateSellIn();
        Quality.ChangeQuality(SellIn.IsBellowMinimum() ? -2 : -1);
    }
}