namespace Task2_1.Models;

public record DeltaOneFeed : TradeFeed
{
    public string Isin { get; init; }
    public DateTime MaturityDate { get; init; }
}