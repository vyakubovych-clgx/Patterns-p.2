using System.Text.RegularExpressions;
using Task2_2.Models;
using Task2_2.Models.Errors;

namespace Task2_2.Validators;

public class DeltaOneFeedValidator : FeedValidator<DeltaOneFeed>
{
    public override ValidateResult Validate(DeltaOneFeed feed)
    {
        var result = base.Validate(feed);

        if (!Regex.IsMatch(feed.Isin, "^[A-Z]{2}\\d{10}$"))
            result.Errors.Add(new InvalidIsinErrorCode());

        if (feed.MaturityDate <= feed.ValuationDate)
            result.Errors.Add(new InvalidMaturityDateErrorCode());

        return result;
    }
}