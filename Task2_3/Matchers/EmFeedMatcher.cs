using Task2_3.Interfaces;
using Task2_3.Models;

namespace Task2_3.Matchers;

public class EmFeedMatcher : IFeedMatcher<EmFeed>
{
    public bool Match(EmFeed current, EmFeed other)
        => current.SourceAccountId == other.SourceAccountId;
}