using GildedRoseKata.Interfaces;
using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Items;

public class AgedBrie : IUpdatableItem
{
    public string Name { get; set; }
    public SellIn SellIn { get; set; }
    public Quality Quality { get; set; }

    public AgedBrie(int sellIn, int quality)
    {
        Name = "Aged Brie";
        Quality = new Quality(quality);
        SellIn = new SellIn(sellIn);
    }

    public AgedBrie()
    {
        Name = "Aged Brie";
    }

    public void Update()
    {
        SellIn.UpdateSellIn();
        Quality.ChangeQuality(SellIn.IsBellowMinimum() ? 2 : 1);
    }
}