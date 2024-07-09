using System;

namespace GildedRoseKata.ValueObjects;

public class Quality
{
    public int QualityValue { get; set; }
    private const int MinQuality = 0;
    private const int MaxQuality = 50;

    public Quality(int quality)
    {
        this.QualityValue = quality;
    }

    public void ChangeQuality(int addedQuality)
    {
        if (IsOverMaximum()) return;
        QualityValue += addedQuality;
        if (IsBellowMinimum()) QualityValue = 0;
        if (IsOverMaximum()) QualityValue = 50;
    }

    private bool IsOverMaximum()
    {
        return QualityValue > MaxQuality;
    }

    private bool IsBellowMinimum()
    {
        return QualityValue < MinQuality;
    }

    public string ToString()
    {
        return $"{QualityValue}";
    }
}