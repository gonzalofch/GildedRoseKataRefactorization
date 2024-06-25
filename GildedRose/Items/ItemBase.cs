namespace GildedRoseKata.Items;

public abstract class ItemBase(int sellIn, int quality)
{
    public string Name { get; protected set; }
    public int SellIn { get; private set; } = sellIn;
    public int Quality { get; private set; } = quality;

    //hacer override de esto en cada clase
    public abstract void UpdateQuality();

    public virtual void UpdateSellIn()
    {
        if (this is not Sulfuras)
            SellIn--;
    }

    //este de aqui no va a cambiar, por lo tanto protegido y ya
    protected void ChangeQuality(int addedQuality)
    {
        if (Quality > 50) return;
        Quality += addedQuality;
        if (Quality < 0) Quality = 0;
        if (Quality > 50) Quality = 50;
    }

    //tampoco cambia asi q lo mismo
    protected bool SellInBelowZero()
    {
        return SellIn < 0;
    }
}