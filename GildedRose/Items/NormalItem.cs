using GildedRoseKata.Extensions;
using GildedRoseKata.Validators;
using GildedRoseKata.Interfaces;

namespace GildedRoseKata.Items;

public class NormalItem : IUpdatableItem
{
    public string Name { get; set; }
    public int Quality { get; set; }
    public int SellIn { get; set; }

    public NormalItem(string name, int sellIn, int quality)
    {
        Name = name;
        Quality = quality;
        SellIn = sellIn;
    }

    public NormalItem()
    {
    }

    public void UpdateQuality()
    {
        this.ChangeQuality(SellIn.IsBellowMinimum() ? -2 : -1);
    }
}