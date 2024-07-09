using GildedRoseKata.Interfaces;
using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Items;

public class Conjured : IUpdatableItem
{
    public string Name { get; set; }
    public SellIn SellIn { get; set; }
    public Quality Quality { get; set; }

    public Conjured(string name, int sellIn, int quality)
    {
        Name = name;
        SellIn = new SellIn(sellIn);
        Quality = new Quality(quality);
    }

    public Conjured()
    {
    }

    public void UpdateQuality()
    {
    }

    public void Update()
    {
        SellIn.UpdateSellIn();
        Quality.ChangeQuality(SellIn.IsBellowMinimum() ? -2 : -1);
    }
}