using System;
using System.Collections.Generic;
using System.Linq;
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
            new AgedBrie(2, 0),
            new NormalItem("Elixir of the Mongoose", 5, 7),
            new Sulfuras(0, 80),
            new Sulfuras(-1, 80),
            new BackstagePass(15, 20),
            new BackstagePass(10, 49),
            new BackstagePass(5, 49),
            // this conjured item does not work properly yet
            new Conjured("Conjured Mana Cake", 3, 6)
        };

        var app = new GildedRose(items);

        int days = args.Length > 0 ? int.Parse(args[0]) + 1 : 1;

        Enumerable.Range(0, days).ToList().ForEach(day =>
        {
            {
                Console.WriteLine("-------- day " + day + " --------");
                Console.WriteLine("name, sellIn, quality");
                items.ToList().ForEach(item =>
                {
                    Console.WriteLine(item.Name + ", " + item.SellIn + ", " + item.Quality);
                });

                Console.WriteLine("");
                app.Update();
            }
        });
    }
}