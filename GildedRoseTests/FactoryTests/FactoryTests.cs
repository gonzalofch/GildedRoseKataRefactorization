using GildedRoseKata;
using GildedRoseKata.Enums;
using GildedRoseKata.Items;
using GildedRoseKata.Services;
using GildedRoseKata.ValueObjects;
using Xunit;

namespace GildedRoseTests.FactoryTests;

public class FactoryTests
{
    private readonly Factory _factory;

    public FactoryTests()
    {
        var legendaryItemFactory = new LegendaryItemFactory();
        _factory = new Factory(legendaryItemFactory);
    }
    
    [Fact]
    public void CreateNormalItem_ShouldReturnNormalItemInstance()
    {
        var item = Factory.CreateNormalItem("+5 Dexterity Vest", new SellIn(10), new Quality(20));

        Assert.IsType<NormalItem>(item);
        Assert.Equal("+5 Dexterity Vest", item.Name);
    }

    [Fact]
    public void CreateAgedBrie_ShouldReturnAgedBrieInstance()
    {
        var item = Factory.CreateAgedBrie(new SellIn(2), new Quality(0));

        Assert.IsType<AgedBrie>(item);
    }

    [Fact]
    public void CreateLegendary_ShouldReturnLegendaryItemInstance()
    {
        var item = Factory.CreateLegendary(LegendaryItems.SulfurasHandOfRagnaros, new SellIn(0), new Quality(80));

        Assert.IsType<Sulfuras>(item);
    }
}