namespace Task2_2.Models;

public record EmFeed : TradeFeed
{
    public decimal Sedol { get; init; }
    public decimal AssetValue { get; init; }
}