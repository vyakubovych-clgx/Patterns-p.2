namespace Task2_3.Models;

public record EmFeed : TradeFeed
{
    public decimal Sedol { get; init; }
    public decimal AssetValue { get; init; }
}