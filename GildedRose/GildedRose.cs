using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using GildedRoseKata.Extensions;
using GildedRoseKata.Items;
using GildedRoseKata.Interfaces;
using IItem = GildedRoseKata.Interfaces.IItem;

namespace GildedRoseKata;

public class GildedRose()
{
    private readonly IList<IItem> _items;

    public GildedRose(IList<IItem> items) : this()
    {
        _items = items;
    }

    public void Update()
    {
        foreach (var item in _items)
        {
            if (item is IUpdatableItem updatableItem)
            {
                updatableItem.UpdateSellIn();
                updatableItem.UpdateQuality();
            }
        }
    }
}