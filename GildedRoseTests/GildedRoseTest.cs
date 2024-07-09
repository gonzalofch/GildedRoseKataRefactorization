using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using GildedRoseKata.Items;
using IItem = GildedRoseKata.Interfaces.IItem;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void foo()
    {
        IList<IItem> items = new List<IItem> { new NormalItem("foo", 0, 0) };
        GildedRose app = Factory.CreateGildedRoseInConsole();
        app.UpdateItems();
        Assert.Equal("foo", items[0].Name);
    }
}