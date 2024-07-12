using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using GildedRoseKata.Items;
using GildedRoseKata.Services;
using GildedRoseKata.ValueObjects;
using IItem = GildedRoseKata.Interfaces.IItem;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void foo()
    {
        IList<IItem> items = new List<IItem> { new NormalItem("foo", new SellIn(0), new Quality(0)) };
        var legendaryFactory = new LegendaryItemFactory();
        GildedRose app = Factory.CreateGildedRoseInConsole();
        app.UpdateItems();
        Assert.Equal("foo", items[0].Name);
    }
}