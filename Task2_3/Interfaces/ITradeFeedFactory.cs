using Task2_3.Models;

namespace Task2_3.Interfaces;

public interface ITradeFeedFactory<T> where T : TradeFeed
{
    IFeedImporter<T> GetFeedImporter(IDatabaseRepository repository);
}