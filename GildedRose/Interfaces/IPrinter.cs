using System.Collections.Generic;
using GildedRoseKata.Interfaces;

namespace GildedRoseKata;

public interface IPrinter
{
    void PrintDay(int day);
    void PrintItemList(IEnumerable<IItem> items);
}