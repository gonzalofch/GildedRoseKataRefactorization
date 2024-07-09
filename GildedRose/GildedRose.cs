using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using GildedRoseKata.Items;
using GildedRoseKata.Interfaces;
using IItem = GildedRoseKata.Interfaces.IItem;

namespace GildedRoseKata;

public class GildedRose
{
    private readonly IList<IItem> _items;
    private readonly IPrinter _printer;

    public GildedRose(IList<IItem> items, IPrinter printer)
    {
        _items = items;
        _printer = printer;
    }

    public void UpdateItems()
    {
        foreach (var item in _items)
        {
            if (item is IUpdatableItem updatableItem)
            {
                // updatableItem.UpdateSellIn();
                // updatableItem.UpdateQuality();
                updatableItem.Update();
            }
        }
    }

    public void Print(int day)
    {
        _printer.PrintDay(day);
        _printer.PrintItemList(_items);
    }

}