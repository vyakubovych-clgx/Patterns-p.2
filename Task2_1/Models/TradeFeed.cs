namespace Task2_1.Models;

public abstract record TradeFeed
{
    public int StagingId { get; init; }
    public string SourceTradeRef { get; init; }
    public int CounterpartyId { get; init; }
    public int PrincipalId { get; init; }
    public DateTime ValuationDate { get; init; }
    public decimal CurrentPrice { get; init; }
    public int SourceAccountId { get; init; }
}