using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Interfaces;

public interface IItem
{
    string Name { get; set; }
    SellIn SellIn { get; set; }
    Quality Quality { get; set; }
}