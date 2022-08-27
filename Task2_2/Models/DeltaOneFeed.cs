namespace Task2_2.Models;

public record DeltaOneFeed : TradeFeed
{
    public string Isin { get; init; }
    public DateTime MaturityDate { get; init; }
}