using Task2_2.Interfaces;
using Task2_2.Models;
using Task2_2.Models.Errors;

namespace Task2_2.Validators;

public abstract class FeedValidator<T> : IFeedValidator<T> where T : TradeFeed
{
    public virtual ValidateResult Validate(T feed)
    {
        var result = new ValidateResult();

        if (feed.StagingId < 1)
            result.Errors.Add(new InvalidIdErrorCode(nameof(feed.StagingId)));

        if (feed.CounterpartyId < 1)
            result.Errors.Add(new InvalidIdErrorCode(nameof(feed.CounterpartyId)));

        if (feed.PrincipalId < 1)
            result.Errors.Add(new InvalidIdErrorCode(nameof(feed.PrincipalId)));

        if (feed.SourceAccountId < 1)
            result.Errors.Add(new InvalidIdErrorCode(nameof(feed.SourceAccountId)));

        if (feed.CurrentPrice < 0 || HasMoreThanTwoDigitsAfterComma(feed.CurrentPrice))
            result.Errors.Add(new InvalidPriceErrorCode());

        return result;
    }

    private static bool HasMoreThanTwoDigitsAfterComma(decimal number)
        => number * 100 - Math.Floor(number * 100) != 0;
}