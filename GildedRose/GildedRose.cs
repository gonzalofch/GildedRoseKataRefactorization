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
        if (item.Name != "Sulfuras, Hand of Ragnaros")
            --item.SellIn;

        //lo que hace el dia anterior
        item.UpdateQuality(item.Name switch
        {
            "Aged Brie" => item.SellIn < 0
                ? 2
                : 1,
            "Backstage passes to a TAFKAL80ETC concert" => item.SellIn < 0
                ? -item.Quality
                : item.SellIn switch //hacer que cuando expiran utilicen otro valor
                {
                    < 5 => 3,
                    < 10 => 2,
                    _ => 1
                },
            "Sulfuras, Hand of Ragnaros" => 0,
            // "Conjured Mana Cake" => -2, //doble de rapido xq es creado por mago
            _ => item.SellIn < 0 ? -2 : -1,
        });
        
        //pasar esto a un metodo de Item para llamarlo dentro de Update
        //lo que hace para dis

        if (item.SellIn < 0)
        {
            item.UpdateQuality(item.Name switch
            {
                "Aged Brie" => 0,
                "Backstage passes to a TAFKAL80ETC concert" => 0,
                "Sulfuras, Hand of Ragnaros" => 0,
                // "Conjured Mana Cake" => -2, //doble de rapido xq es creado por mago, pero no funciona
                _ => 0,
            });
        }
    }
}