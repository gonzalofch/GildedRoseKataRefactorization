﻿using System.Collections.Generic;
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

    public void UpdateItem(Item item)
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