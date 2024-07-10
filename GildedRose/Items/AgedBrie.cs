using GildedRoseKata.Interfaces;
using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Items;

public class AgedBrie : IUpdatableItem
{
    public string Name { get; set; } = "Aged Brie";
    public SellIn SellIn { get; set; }
    public Quality Quality { get; set; }

    public AgedBrie(SellIn sellIn, Quality quality)
    {
        Quality = quality;
        SellIn = sellIn;
    }
    
    public void Update()
    {
        SellIn.UpdateSellIn();
        Quality.ChangeQuality(SellIn.IsBellowMinimum() ? 2 : 1);
    }
}