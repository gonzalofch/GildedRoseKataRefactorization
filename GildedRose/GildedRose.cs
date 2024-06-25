using System.Collections.Generic;
using System.Linq;
using GildedRoseKata.Items;

namespace GildedRoseKata;

public class GildedRose(IList<ItemBase> items)
{
    public void Update()
    {
        items.ToList().ForEach(item =>
        {
            item.UpdateSellIn();
            item.UpdateQuality();
        });
    }
}