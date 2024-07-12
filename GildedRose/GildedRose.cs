using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using GildedRoseKata.Items;
using GildedRoseKata.Interfaces;
using IItem = GildedRoseKata.Interfaces.IItem;

namespace GildedRoseKata;

public class GildedRose(IList<IItem> items, IPrinter printer)
{
    private readonly IList<IItem> _items = items;
    private readonly IPrinter _printer = printer;

    public void UpdateItems()
    {
        foreach (var item in _items)
        {
            if (item is IUpdatableItem updatableItem)
            {
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