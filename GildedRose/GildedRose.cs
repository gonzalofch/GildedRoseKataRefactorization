using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata;

public class GildedRose(IList<Item> items)
{
    public void Update()
    {
        items.ToList().ForEach(item =>
        {
            Item.UpdateSellIn(item);
            Item.UpdateQuality(item);
        });
    }
}