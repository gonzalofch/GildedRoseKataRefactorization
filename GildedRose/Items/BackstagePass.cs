namespace GildedRoseKata.Items;

public class BackstagePass : ItemBase
{
    public BackstagePass(int sellIn, int quality) : base(sellIn, quality)
    {
        Name = "Backstage passes to a TAFKAL80ETC concert";
    }

    public override void UpdateQuality()
    {
        if (SellInBelowZero())
        {
            ChangeQuality(-Quality);
        }
        else
            switch (SellIn)
            {
                case < 5:
                    ChangeQuality(3);
                    break;
                case < 10:
                    ChangeQuality(2);
                    break;
                default:
                    ChangeQuality(1);
                    break;
            }
    }
}