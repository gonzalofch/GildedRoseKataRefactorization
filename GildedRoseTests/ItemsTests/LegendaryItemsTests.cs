using GildedRoseKata.Items;
using GildedRoseKata.ValueObjects;
using Xunit;

namespace GildedRoseTests.ItemsTests;

public class LegendaryItemsTests
{
    [Fact]
    public void Sulfuras_ShouldHaveCorrectName()
    {
        var sulfuras = new Sulfuras(new SellIn(0), new Quality(80));

        Assert.Equal("Sulfuras, Hand of Ragnaros", sulfuras.Name);
    }
}