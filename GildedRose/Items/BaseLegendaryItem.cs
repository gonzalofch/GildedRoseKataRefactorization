using GildedRoseKata.Interfaces;
using GildedRoseKata.ValueObjects;

namespace GildedRoseKata.Items;

public class BaseLegendaryItem : ILegendaryItem
{
    public string Name { get;set; }
    public SellIn SellIn { get; set;}
    public Quality Quality { get;set; }
}