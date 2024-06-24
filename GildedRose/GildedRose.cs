using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;

namespace GildedRoseKata;

public class GildedRose
{
    private readonly IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        Items.Select(item =>
        {
            Update(item);
            return item;
        }).ToList();
    }

    public void Update(Item item)
    {
        if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
        {
            if (item.Quality > 0)
                if (item.Name != "Sulfuras, Hand of Ragnaros")
                    item.Quality -= 1;
        }
        else
        {
            if (item.Quality < 50)
            {
                item.Quality += 1;

                if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (item.SellIn < 11)
                        if (item.Quality < 50)
                            item.Quality += 1;

                    if (item.SellIn < 6)
                        if (item.Quality < 50)
                            item.Quality += 1;
                }
            }
        }

        if (item.Name != "Sulfuras, Hand of Ragnaros") item.SellIn -= 1;

        if (item.SellIn < 0)
        {
            //"Aged Brie"

            if (item.Name == "Aged Brie")
            {
                if (item.Quality < 50) item.Quality += 1;
            }
            else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                item.Quality = 0;
            }
            else if (item.Name == "Sulfuras, Hand of Ragnaros")
            {
                item.Quality -= 0;
            }
            else
            {
                item.Quality -= 1;
            }
        }
    }
}