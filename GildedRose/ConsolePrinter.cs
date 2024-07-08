using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GildedRoseKata.Interfaces;

namespace GildedRoseKata;

public class ConsolePrinter : IPrinter
{
    public void PrintDay(int numberDay)
    {
        Console.WriteLine($"-------- day {numberDay} --------");
    }

    public void PrintItemList(IEnumerable<IItem> items)
    {
            var output = new StringBuilder();

            output.AppendLine("name, sellIn, quality");
            items.ToList().ForEach(item =>
            {
                output.AppendLine($"{item.Name}, {item.SellIn}, {item.Quality}");
            });

            output.AppendLine();

            Console.Write(output.ToString());
    }
}