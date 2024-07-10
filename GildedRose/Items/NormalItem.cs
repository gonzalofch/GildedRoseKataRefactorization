using GildedRoseKata.ValueObjects;
using GildedRoseKata.Interfaces;

namespace GildedRoseKata.Items;

public class NormalItem : IUpdatableItem
{
    public string Name { get; set; }
    public Quality Quality { get; set; }
    public SellIn SellIn { get; set; }

    public NormalItem(string name, SellIn sellIn, Quality quality)
    {
        Name = name;
        Quality = quality;
        SellIn = sellIn;
    }

    public void Update()
    {
        SellIn.UpdateSellIn();
        Quality.ChangeQuality(SellIn.IsBellowMinimum() ? -2 : -1);
    }
}