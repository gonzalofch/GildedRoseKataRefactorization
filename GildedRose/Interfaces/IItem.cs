using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Interfaces;

public interface IItem
{
    string Name { get;}
    SellIn SellIn { get; }
    Quality Quality { get; }
}