using System.Collections.Generic;
using GildedRoseKata.Interfaces;
using GildedRoseKata.ValueObjects;

namespace GildedRoseKata;

public static class SeedData
{
    public static List<IItem> ObtainItems()
    {
        IUpdatableItem dexterityVest5 = Factory.CreateNormalItem();
        dexterityVest5.Name = "+5 Dexterity Vest";
        dexterityVest5.SellIn = new SellIn(10);
        dexterityVest5.Quality = new Quality(20);

        IUpdatableItem agedBrie = Factory.CreateAgedBrie();
        agedBrie.SellIn = new SellIn(2);
        agedBrie.Quality = new Quality(0);

        IUpdatableItem mongooseElixir = Factory.CreateNormalItem();
        mongooseElixir.Name = "Elixir of the Mongoose";
        mongooseElixir.SellIn = new SellIn(5);
        mongooseElixir.Quality = new Quality(7);

        IInmutableItem sulfuras1 = Factory.CreateLegendary();
        sulfuras1.Name = "Sulfuras, Hand of Ragnaros";
        sulfuras1.SellIn = new SellIn(0);
        sulfuras1.Quality = new Quality(80);

        IInmutableItem sulfuras2 = Factory.CreateLegendary();
        sulfuras2.Name = "Sulfuras, Hand of Ragnaros";
        sulfuras2.SellIn = new SellIn(-1);
        sulfuras2.Quality = new Quality(80);

        IUpdatableItem backstagePass1 = Factory.CreateBackstagePass();
        backstagePass1.SellIn = new SellIn(15);
        backstagePass1.Quality = new Quality(20);

        IUpdatableItem backstagePass2 = Factory.CreateBackstagePass();
        backstagePass2.SellIn = new SellIn(10);
        backstagePass2.Quality = new Quality(49);

        IUpdatableItem backstagePass3 = Factory.CreateBackstagePass();
        backstagePass3.SellIn = new SellIn(5);
        backstagePass3.Quality = new Quality(49);

        IUpdatableItem manaCake = Factory.CreateConuredItem();
        manaCake.Name = "Conjured Mana Cake";
        manaCake.SellIn = new SellIn(3);
        manaCake.Quality = new Quality(6);

        List<IItem> items =
        [
            dexterityVest5,
            agedBrie,
            mongooseElixir,
            sulfuras1,
            sulfuras2,
            backstagePass1,
            backstagePass2,
            backstagePass3,
            manaCake
        ];

        return items;
    }
}