using Task2_2.Importers;
using Task2_2.Interfaces;
using Task2_2.Models;

namespace Task2_2;

public class ImporterFactory
{
    public void Import<T>(IDatabaseRepository repository, IEnumerable<T> feeds) where T : TradeFeed
    {
        switch (feeds)
        {
            case IEnumerable<DeltaOneFeed> deltaOneFeeds:
                new DeltaOneFeedImporter(repository).Import(deltaOneFeeds);
                break;
            case IEnumerable<EmFeed> emFeeds:
                new EmFeedImporter(repository).Import(emFeeds);
                break;
            default:
                throw new InvalidOperationException("Unsupported feed type");
        }
    }
}