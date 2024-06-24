namespace GildedRoseKata;

public class Item
{
    public Item(string name, int sellIn, int quality)
    {
        Name = name;
        SellIn = sellIn;
        Quality = quality;
    }

    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public int UpdateQuality(int addedQuality)
        //verificar que nunca exceda de 50 ni sea menor a 0
    {
        if (Quality > 50)
        {
            return Quality; // No realizar cambios si Quality ya es mayor que 50
        }

        Quality += addedQuality;
        if (Quality < 0) Quality = 0;
        if (Quality > 50) Quality = 50;

        return Quality;
    }
}