using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using GildedRoseKata.Items;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void foo()
    {
        IList<ItemBase> items = new List<ItemBase> { new NormalItem("foo", 0, 0) };
        GildedRose app = new GildedRose(items);
        app.Update();
        Assert.Equal("foo", items[0].Name);
    }
}