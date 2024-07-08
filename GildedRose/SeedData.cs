using System.Collections.Generic;
using GildedRoseKata.Interfaces;

namespace GildedRoseKata;

public static class SeedData
{

   public static List<IItem> ObtainItems()
   {
      IUpdatableItem dexterityVest5 = Factory.CreateNormalItem();
      dexterityVest5.Name = "+5 Dexterity Vest";
      dexterityVest5.SellIn = 10;
      dexterityVest5.Quality = 20;

      IUpdatableItem agedBrie = Factory.CreateAgedBrie();
      agedBrie.SellIn = 2;
      agedBrie.Quality = 0;

      IUpdatableItem mongooseElixir = Factory.CreateNormalItem();
      mongooseElixir.Name = "Elixir of the Mongoose";
      mongooseElixir.SellIn = 5;
      mongooseElixir.Quality = 7;

      IInmutableItem sulfuras1 = Factory.CreateLegendary();
      sulfuras1.Name = "Sulfuras, Hand of Ragnaros";
      sulfuras1.SellIn = 0;
      sulfuras1.Quality = 80;

      IInmutableItem sulfuras2 = Factory.CreateLegendary();
      sulfuras2.Name = "Sulfuras, Hand of Ragnaros";
      sulfuras2.SellIn = -1;
      sulfuras2.Quality = 80;

      IUpdatableItem backstagePass1 = Factory.CreateBackstagePass();
      backstagePass1.SellIn = 15;
      backstagePass1.Quality = 20;
        
      IUpdatableItem backstagePass2 = Factory.CreateBackstagePass();
      backstagePass2.SellIn = 10;
      backstagePass2.Quality = 49;
        
      IUpdatableItem backstagePass3 = Factory.CreateBackstagePass();
      backstagePass3.SellIn = 5;
      backstagePass3.Quality = 49;

      IUpdatableItem manaCake = Factory.CreateConuredItem();
      manaCake.Name = "Conjured Mana Cake";
      manaCake.SellIn = 3;
      manaCake.Quality = 6;

      List<IItem> items = new List<IItem>();
      items.Add(dexterityVest5);
      items.Add(agedBrie);
      items.Add(mongooseElixir);
      items.Add(sulfuras1);
      items.Add(sulfuras2);
      items.Add(backstagePass1);
      items.Add(backstagePass2);
      items.Add(backstagePass3);
      items.Add(manaCake);
      
      return items;
   }
}