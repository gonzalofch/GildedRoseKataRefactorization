using GildedRoseKata.Interfaces;

namespace GildedRoseKata.Items;

public class BaseLegendaryItem : ILegendaryItem
{
    public string Name { get; set; }
    public int Quality { get; set; }
    public int SellIn { get; set; }

}