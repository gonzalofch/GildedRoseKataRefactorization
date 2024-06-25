using System;
using System.Collections.Generic;
using GildedRoseKata.Items;

namespace GildedRoseKata;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");
        
        IList<ItemBase> items = new List<ItemBase>
        {
            new NormalItem("+5 Dexterity Vest", 10, 20),
            new AgedBrie( 2, 0),
            new NormalItem("Elixir of the Mongoose", 5, 7),
            new Sulfuras( 0, 80),
            new Sulfuras( -1, 80),
            new BackstagePass( 15, 20),
            new BackstagePass( 10, 49),
            new BackstagePass( 5, 49),
            // this conjured item does not work properly yet
            new Conjured("Conjured Mana Cake", 3, 6)
        };
        
        var app = new GildedRose(items);

        int days = 2;
        if (args.Length > 0)
        {
            days = int.Parse(args[0]) + 1;
        }

        for (var i = 0; i < days; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("name, sellIn, quality");
            for (var j = 0; j < items.Count; j++)
            {
                Console.WriteLine(items[j].Name + ", " + items[j].SellIn + ", " + items[j].Quality);
            }

            Console.WriteLine("");
            app.Update();
        }
    }
}