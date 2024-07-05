using System;
using System.Collections.Generic;
using System.Linq;
using GildedRoseKata.Items;

namespace GildedRoseKata;

public class Program
{
    public static void Main(string[] args)
    {
        /*Aplicando PRINCIPIOS SOLID
         PROBLEMAS QUE SURGEN DE ESTE CODIGO:
         -No es tan escalable en caso de querer crear nuevos items
         -Se pueden instanciar directamente los items que utilizamos
         -Los items, no son muy escalables en si, tener un solo elemento base es muy general y no nos dice nada realmente
         de las caracteristicas de cada item


         POSIBLES SOLUCIONES APLICANDO PRINCIPIOS SOLID:
         -Este modulo no debería tener directamente la creacion de instancias. Deberemos usar inyeccion de dependencias
         para quitarle las dependencias de este modulo sobre los demas.
         -Crear interfaces segun las caracteristicas de los items e implementar las interfaces que hagan falta en cada
         clase especifica. Esto soluciona el Principio de Abierto a extension y cerrado a modificacion OpenClosedPrinciple
         -Cada CLase tiene su propósito, evitar que las clases se sobrecarguen con procesos que no deben hacer
         Una clase debe hacer solo una cosa

        Buenas practicas a aplicar de otros videos que ví:
        -Metodos deben hacer una cosa
        -Mantener el codigo simple
        -Ser consistente en la manera de hacer codigo (estandarizar de que manera hago todo)
        -concatenar string usando $ {} Y StringBuilder (es más eficiente en loops)

         */
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