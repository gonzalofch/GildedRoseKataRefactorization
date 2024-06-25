namespace GildedRoseKata.Items;

public class Conjured:ItemBase
{
    //por si pide implementar funcionalidad para los objetos
    //conjurados por magos o demas clases como el Conjured Mana Cake aqui implementaria la funcionalidad
    public Conjured(string name,int sellIn, int quality) : base( sellIn, quality)
    {
        //aqui podria tener sentido que, al existir mas items que se conjuren que me deje pasarle el nombre del item
        Name = name; 
    }

    public override void UpdateQuality()
    {
        ChangeQuality(SellInBelowZero() ? -2 : -1);
    }
}