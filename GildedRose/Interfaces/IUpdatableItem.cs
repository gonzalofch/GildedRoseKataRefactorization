using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Interfaces;

public interface IUpdatableItem : IItem, IUpdatable
{
    new string Name { get; set; }
    new  SellIn SellIn { get; set; }
    new Quality Quality { get; set; }
}