namespace GildedRoseKata.Items;

public class NormalItem :ItemBase
{
    public NormalItem(string name, int sellIn, int quality) : base(sellIn, quality)
    {
        Name = name;
    }

    public override void UpdateQuality()
    {
        ChangeQuality(SellInBelowZero() ? -2 : -1);
    }
}