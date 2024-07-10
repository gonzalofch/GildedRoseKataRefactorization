using GildedRoseKata.Interfaces;
using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Items;

public class BackstagePass : IUpdatableItem
{
    public string Name { get; set; } = "Backstage passes to a TAFKAL80ETC concert";
    public SellIn SellIn { get; set; }
    public Quality Quality { get; set; }

    public BackstagePass(SellIn sellIn, Quality quality)
    {
        Quality = quality;
        SellIn = sellIn;
    }

    public void Update()
    {
        SellIn.UpdateSellIn();

        if (SellIn.IsBellowMinimum())
        {
            Quality.ChangeQuality(-Quality.QualityValue);
        }
        else
            switch (SellIn.SellInValue)
            {
                case < 5:
                    Quality.ChangeQuality(3);
                    break;
                case < 10:
                    Quality.ChangeQuality(2);
                    break;
                default:
                    Quality.ChangeQuality(1);
                    break;
            }
    }
}