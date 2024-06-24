namespace GildedRoseKata;

public class Item(string name, int sellIn, int quality)
{
    public string Name { get; } = name;
    public int SellIn { get; private set; } = sellIn;
    public int Quality { get; private set; } = quality;

    private void ChangeQuality(int addedQuality)
    {
        if (Quality > 50) return;
        Quality += addedQuality;
        if (Quality < 0) Quality = 0;
        if (Quality > 50) Quality = 50;
    }

    public static void UpdateQuality(Item item)
    {
        item.ChangeQuality(item.Name switch
        {
            "Aged Brie" => item.SellIn < 0
                ? 2
                : 1,
            "Backstage passes to a TAFKAL80ETC concert" => item.SellIn < 0
                ? -item.Quality
                : item.SellIn switch
                {
                    < 5 => 3,
                    < 10 => 2,
                    _ => 1
                },
            _ => item.SellIn < 0 ? -2 : -1,
        });
    }

    public static void UpdateSellIn(Item item)
    {
        if (item.Name != "Sulfuras, Hand of Ragnaros")
            --item.SellIn;
    }
}