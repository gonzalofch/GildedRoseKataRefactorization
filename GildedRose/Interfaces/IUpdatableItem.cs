using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Interfaces;

public interface IUpdatableItem : IItem, IUpdatable
{
     string Name { get; protected set; }
     SellIn SellIn { get; protected set; }
     Quality Quality { get; protected set; }
}