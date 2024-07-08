using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GildedRoseKata.Interfaces;
using GildedRoseKata.Items;
using IItem = GildedRoseKata.Interfaces.IItem;

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

        var items = SeedData.ObtainItems();

        var app = new GildedRose(items);

        int days = args.Length > 0 ? int.Parse(args[0]) + 1 : 1;

        Enumerable.Range(0, days).ToList().ForEach(day =>
        {
            var output = new StringBuilder();

            output.AppendLine($"-------- day {day} --------");
            output.AppendLine("name, sellIn, quality");
            items.ToList().ForEach(item =>
            {
                output.AppendLine($"{item.Name}, {item.SellIn}, {item.Quality}");
            });

            output.AppendLine();

            Console.Write(output.ToString());
            app.Update();
        });
    }
}