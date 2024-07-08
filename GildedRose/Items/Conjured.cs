using GildedRoseKata.Extensions;
using GildedRoseKata.Interfaces;
using GildedRoseKata.Validators;

namespace GildedRoseKata.Items;

public class Conjured : IUpdatableItem
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public Conjured(string name, int sellIn, int quality)
    {
        Name = name;
        SellIn = sellIn;
        Quality = quality;
    }

    public void UpdateQuality()
    {
        this.ChangeQuality(SellIn.IsBellowMinimum() ? -2 : -1);

    }
}
