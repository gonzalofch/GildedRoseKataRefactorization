using GildedRoseKata.Interfaces;

namespace GildedRoseKata.ValueObjects;

public class SellIn
{
    public int SellInValue { get; private set; }
    private const int MinSellIn = 0;

    public SellIn(int sellInValue)
    {
        SellInValue = sellInValue;
    }

    public void UpdateSellIn()
    {
        SellInValue--;
    }

    public bool IsBellowMinimum()
    {
        return SellInValue < MinSellIn;
    }
    
    public string ToString()
    {
        return $"{SellInValue}";
    }
}