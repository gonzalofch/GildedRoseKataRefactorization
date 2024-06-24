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
        switch (item.Name)
        {
            //aged brie
            case "Aged Brie":
                item.UpdateQuality(1);
                break;
            //backstage pass
            case "Backstage passes to a TAFKAL80ETC concert":
            {
                switch (item.SellIn)
                {
                    //para convertir a un if else if y else y luego a un switch case tenemos que dar por hecho que el primero (<6 que siempre se realizara una vez mas que el segundo)se realiza 1 vez mas que el segundo y asi
                    case < 6:
                        item.UpdateQuality(3);
                        break;
                    case < 11:
                        item.UpdateQuality(2);
                        break;
                    default:
                        item.UpdateQuality(1);
                        break;
                }

                break;
            }
            default:
            {
                item.UpdateQuality(-1);
                break;
            }
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