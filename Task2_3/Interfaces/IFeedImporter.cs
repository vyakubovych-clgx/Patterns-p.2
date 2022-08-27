using Task2_3.Models;

namespace Task2_3.Interfaces;

public interface IFeedImporter<T> where T : TradeFeed
{
    void Import(IEnumerable<T> feeds);
}