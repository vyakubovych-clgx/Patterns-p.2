using Task2_3.Models;

namespace Task2_3.Interfaces;

public interface IFeedMatcher<T> where T : TradeFeed
{
    bool Match(T current, T other);
}