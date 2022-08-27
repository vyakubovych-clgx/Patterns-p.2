using Task2_3.Interfaces;
using Task2_3.Models;

namespace Task2_3.Matchers;

public class DeltaOneFeedMatcher : IFeedMatcher<DeltaOneFeed>
{
    public bool Match(DeltaOneFeed current, DeltaOneFeed other)
        => current.CounterpartyId + current.PrincipalId == other.CounterpartyId + other.PrincipalId;
}