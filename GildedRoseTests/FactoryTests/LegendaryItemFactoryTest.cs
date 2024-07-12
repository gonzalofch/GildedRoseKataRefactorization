using FluentAssertions;
using GildedRoseKata;
using GildedRoseKata.Enums;
using GildedRoseKata.Items;
using GildedRoseKata.Services;
using GildedRoseKata.ValueObjects;
using Xunit;

namespace GildedRoseTests.FactoryTests;

public class LegendaryItemFactoryTest
{
    private readonly LegendaryItemFactory _legendaryItemFactory;

    public LegendaryItemFactoryTest()
    {
        _legendaryItemFactory = new LegendaryItemFactory();
    }

    [Fact]
    public void CreateLegendaryItem_ShouldReturnSulfurasInstance_WhenItemIsSulfuras()
    {
        var item = _legendaryItemFactory.CreateItem(LegendaryItems.SulfurasHandOfRagnaros, new SellIn(0),
            new Quality(80));
        item.Should().BeOfType<Sulfuras>();
    }

    [Fact]
    public void CreateLegendaryItem_ShouldReturnAtieshInstance_WhenItemIsAtiesh()
    {
        var item = _legendaryItemFactory.CreateItem(LegendaryItems.AtieshGreatstaffOfTheGuardian, new SellIn(0),
            new Quality(80));
        item.Should().BeOfType<Atiesh>();
    }

    [Fact]
    public void CreateLegendaryItem_ShouldReturnShadowmourneInstance_WhenItemIsShadowmourne()
    {
        var item = _legendaryItemFactory.CreateItem(LegendaryItems.Shadowmourne, new SellIn(0), new Quality(80));
        item.Should().BeOfType<Shadowmourne>();
    }

    [Fact]
    public void CreateLegendaryItem_ShouldReturnThunderfuryInstance_WhenItemIsThunderfury()
    {
        var item = _legendaryItemFactory.CreateItem(LegendaryItems.ThunderfuryBlessedBladeOfTheWindseeker,
            new SellIn(0), new Quality(80));
        item.Should().BeOfType<Thunderfury>();
    }

    [Fact]
    public void CreateLegendaryItem_ShouldReturnValanyrInstance_WhenItemIsValanyr()
    {
        var item = _legendaryItemFactory.CreateItem(LegendaryItems.ValanyrHammerOfAncientKings, new SellIn(0),
            new Quality(80));
        item.Should().BeOfType<Valanyr>();
    }
    
}