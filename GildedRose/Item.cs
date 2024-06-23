namespace GildedRoseKata;

public class Item
{
    public Item()
    {
    }

    public Item(string name, int sellIn, int quality)
    {
        Name = name;
        SellIn = sellIn;
        Quality = quality;
    }

    public static Item CreateItem(string name, int sellIn, int quality)
    {
        Item item = new Item();
        item.Name = name;
        item.SellIn = sellIn;
        item.Quality = quality;
        return item;
    }
    
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }
}