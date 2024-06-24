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

    public void Update()
    {
        Items.Select(item =>
        {
            UpdateItem(item);
            return item;
        }).ToList();
    }

    private void UpdateItem(Item item)
    {
        item.Quality = item.Name switch
        {
            "Aged Brie" => item.UpdateQuality(1),
            "Backstage passes to a TAFKAL80ETC concert" => item.SellIn switch
            {
                < 6 => item.UpdateQuality(3),
                < 11 => item.UpdateQuality(2),
                _ => item.UpdateQuality(1)
                //esto tal vez pasar a una funcion updatebackstage o algo asi
            },
            _ => item.UpdateQuality(-1),
        };
        
        item.SellIn -= item.Name == "Sulfuras, Hand of Ragnaros"
            ? 0
            : 1;

        if (item.SellIn < 0)
        {
            item.Quality = item.Name switch
            {
                "Aged Brie" => item.UpdateQuality(1),
                "Backstage passes to a TAFKAL80ETC concert" => item.UpdateQuality(-item.Quality),
                "Sulfuras, Hand of Ragnaros" => item.UpdateQuality(0),
                _ => item.UpdateQuality(-1)
            };
        }
    }
}