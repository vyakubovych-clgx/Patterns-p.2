using System.Text.RegularExpressions;
using Task2_1.Models;
using Task2_1.Models.Errors;

namespace Task2_1.Validators;

public class EmFeedValidator : FeedValidator<EmFeed>
{
    public override ValidateResult Validate(EmFeed feed)
    {
        var result = base.Validate(feed);

        if (feed.Sedol is <= 0 or >= 100)
            result.Errors.Add(new InvalidSedolErrorCode());

        if (feed.AssetValue <= 0 || feed.AssetValue >= feed.Sedol)
            result.Errors.Add(new InvalidAssetValueErrorCode());

        return result;
    }
}