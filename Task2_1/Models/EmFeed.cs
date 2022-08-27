namespace Task2_1.Models;

public record EmFeed : TradeFeed
{
    public decimal Sedol { get; init; }
    public decimal AssetValue { get; init; }
}