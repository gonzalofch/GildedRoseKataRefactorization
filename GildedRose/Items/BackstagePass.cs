using GildedRoseKata.Interfaces;
using GildedRoseKata.Validators;
using GildedRoseKata.Extensions;

namespace GildedRoseKata.Items;

public class BackstagePass : IUpdatableItem
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public BackstagePass(int sellIn, int quality)
    {
        Name = "Backstage passes to a TAFKAL80ETC concert";
        Quality = quality;
        SellIn = sellIn;
    }

    public BackstagePass()
    {
        Name = "Backstage passes to a TAFKAL80ETC concert";
    }
    
    public void UpdateQuality()
    {
        if (SellIn.IsBellowMinimum())
        {
            this.ChangeQuality(-Quality);
        }
        else
            switch (SellIn)
            {
                case < 5:
                    this.ChangeQuality(3);
                    break;
                case < 10:
                    this.ChangeQuality(2);
                    break;
                default:
                    this.ChangeQuality(1);
                    break;
            }
    }
}