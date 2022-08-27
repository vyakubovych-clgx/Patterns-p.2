using Task2_2.Interfaces;
using Task2_2.Models;

namespace Task2_2.Matchers;

public class EmFeedMatcher : IFeedMatcher<EmFeed>
{
    public bool Match(EmFeed current, EmFeed other)
        => current.SourceAccountId == other.SourceAccountId;
}