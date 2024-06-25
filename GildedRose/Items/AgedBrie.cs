namespace GildedRoseKata.Items;

public class AgedBrie : ItemBase
{
    public AgedBrie(int sellIn, int quality) : base(sellIn, quality)
    {
        Name = "Aged Brie";
    }

    public override void UpdateQuality()
    {
        ChangeQuality(SellInBelowZero() ? 2 : 1);
    }
}