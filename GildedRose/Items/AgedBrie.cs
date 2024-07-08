using GildedRoseKata.Interfaces;
using GildedRoseKata.Extensions;
using GildedRoseKata.Validators;

namespace GildedRoseKata.Items;

public class AgedBrie : IUpdatableItem
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public AgedBrie(int sellIn, int quality)
    {
        Name = "Aged Brie";
        Quality = quality;
        SellIn = sellIn;
    }

    public AgedBrie()
    {
        Name = "Aged Brie";
    }

    public void UpdateQuality()
    {
        this.ChangeQuality(SellIn.IsBellowMinimum() ? 2 : 1);
    }
}