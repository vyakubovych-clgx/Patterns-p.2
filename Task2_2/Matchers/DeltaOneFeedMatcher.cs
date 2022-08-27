using Task2_2.Interfaces;
using Task2_2.Models;

namespace Task2_2.Matchers;

public class DeltaOneFeedMatcher : IFeedMatcher<DeltaOneFeed>
{
    public bool Match(DeltaOneFeed current, DeltaOneFeed other)
        => current.CounterpartyId + current.PrincipalId == other.CounterpartyId + other.PrincipalId;
}