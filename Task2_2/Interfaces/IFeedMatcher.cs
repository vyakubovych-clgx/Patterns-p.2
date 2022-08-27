using Task2_2.Models;

namespace Task2_2.Interfaces;

public interface IFeedMatcher<T> where T : TradeFeed
{
    bool Match(T current, T other);
}