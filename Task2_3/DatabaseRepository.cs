using Task2_3.Interfaces;
using Task2_3.Models;

namespace Task2_3;

public class DatabaseRepository : IDatabaseRepository
{
    private readonly List<TradeFeed> _feeds = new()
    {
        new DeltaOneFeed
        {
            StagingId = 1,
            SourceTradeRef = "pyshch pyshch ololo",
            CounterpartyId = 2,
            PrincipalId = 3,
            ValuationDate = DateTime.Now.AddDays(-1),
            CurrentPrice = 12.34m,
            SourceAccountId = 4,
            Isin = "US9311421039",
            MaturityDate = DateTime.Now
        },

        new EmFeed
        {
            StagingId = 1,
            SourceTradeRef = "pyshch pyshch ololo",
            CounterpartyId = 2,
            PrincipalId = 3,
            ValuationDate = DateTime.Now.AddDays(-1),
            CurrentPrice = 12.34m,
            SourceAccountId = 4,
            Sedol = 42,
            AssetValue = 13
        }
    };

    private readonly Dictionary<int, List<string>> _errors = new();

    public List<T> LoadFeeds<T>()
        => _feeds.OfType<T>().ToList();

    public void SaveFeed<T>(T feed)
    {
        _feeds.Add(feed as TradeFeed);
    }

    public void SaveErrors(int feedStagingId, List<string> errors)
    {
        if (!_errors.TryAdd(feedStagingId, errors))
            _errors[feedStagingId].AddRange(errors);
    }
}