using GildedRoseKata.Interfaces;

namespace GildedRoseKata.Validators;

public static class SellInValidator
{
    private const int MinSellIn = 0;
    
    public static bool IsBellowMinimum(this int SellIn)
    {
        return SellIn < MinSellIn;
    }
}