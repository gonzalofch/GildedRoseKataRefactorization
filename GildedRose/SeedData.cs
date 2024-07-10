using System.Collections.Generic;
using GildedRoseKata.Interfaces;
using GildedRoseKata.ValueObjects;

namespace GildedRoseKata;

public static class SeedData
{
    public static List<IItem> ObtainItems()
    {
        IUpdatableItem dexterityVest5 = Factory.CreateNormalItem("+5 Dexterity Vest",new SellIn(10),new Quality(20));
        IUpdatableItem agedBrie = Factory.CreateAgedBrie(new SellIn(2),new Quality(0));
        IUpdatableItem mongooseElixir = Factory.CreateNormalItem("Elixir of the Mongoose",new SellIn(5),new Quality(7));
        IInmutableItem sulfuras1 = Factory.CreateLegendary(LegendaryItems.SulfurasHandOfRagnaros, new SellIn(0),new Quality(80) );
        IInmutableItem sulfuras2 = Factory.CreateLegendary(LegendaryItems.SulfurasHandOfRagnaros, new SellIn(-1),new Quality(80));
        IUpdatableItem backstagePass1 = Factory.CreateBackstagePass(new SellIn(15),new Quality(20));
        IUpdatableItem backstagePass2 = Factory.CreateBackstagePass(new SellIn(10),new Quality(49));
        IUpdatableItem backstagePass3 = Factory.CreateBackstagePass(new SellIn(5),new Quality(49));
        IUpdatableItem manaCake = Factory.CreateConuredItem("Conjured Mana Cake",new SellIn(3),new Quality(6));
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