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
        //aged brie
        if (item.Name == "Aged Brie")
        {
            item.UpdateQuality(1);
        }
        //backstage pass
        else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
        {
            item.UpdateQuality(1);

            if (item.SellIn < 11) item.UpdateQuality(1);
            if (item.SellIn < 6) item.UpdateQuality(1);
        }
        else if (item.Quality > 0)
            if (item.Name == "Sulfuras, Hand of Ragnaros")
            {
                item.UpdateQuality(0);
                //sulfuras no se va a editar, por lo tanto esto se va eliminar
            }
            else
            {
                item.UpdateQuality(-1);
            }

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