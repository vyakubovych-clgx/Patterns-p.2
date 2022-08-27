using Task2_1.Models;
using Task2_1.Validators;

var validDeltaOneFeed = new DeltaOneFeed
{
    StagingId = 1,
    SourceTradeRef = "pyshch pyshch ololo",
    CounterpartyId = 2,
    PrincipalId = 3,
    ValuationDate = DateTime.Now.AddDays(-1),
    CurrentPrice = 12.34m,
    SourceAccountId = 4,
    Isin = "US9311421039",
    MaturityDate = DateTime.Now
};

var invalidDeltaOneFeed = new DeltaOneFeed
{
    StagingId = -1,
    SourceTradeRef = "pyshch pyshch ololo",
    CounterpartyId = -2,
    PrincipalId = -3,
    ValuationDate = DateTime.Now,
    CurrentPrice = 12.345m,
    SourceAccountId = -4,
    Isin = "AAAAAAAAAAAAAAAAAAAAAAA",
    MaturityDate = DateTime.Now.AddDays(-1)
};

var validEmFeed = new EmFeed
{
    StagingId = 1,
    SourceTradeRef = "pyshch pyshch ololo",
    CounterpartyId = 2,
    PrincipalId = 3,
    ValuationDate = DateTime.Now.AddDays(-1),
    CurrentPrice = 12.34m,
    SourceAccountId = 4,
    Sedol = 42,
    AssetValue = 13
};

var invalidEmFeed = new EmFeed
{
    StagingId = -1,
    SourceTradeRef = "pyshch pyshch ololo",
    CounterpartyId = -2,
    PrincipalId = -3,
    ValuationDate = DateTime.Now,
    CurrentPrice = 12.345m,
    SourceAccountId = -4,
    Sedol = 420,
    AssetValue = 666
};

var deltaOneFeedValidator = new DeltaOneFeedValidator();
var emFeedValidator = new EmFeedValidator();

Console.WriteLine(validDeltaOneFeed);
OutputValidationResult(deltaOneFeedValidator.Validate(validDeltaOneFeed));

Console.WriteLine(invalidDeltaOneFeed);
OutputValidationResult(deltaOneFeedValidator.Validate(invalidDeltaOneFeed));

Console.WriteLine(validEmFeed);
OutputValidationResult(emFeedValidator.Validate(validEmFeed));

Console.WriteLine(invalidEmFeed);
OutputValidationResult(emFeedValidator.Validate(invalidEmFeed));

Console.ReadLine();

void OutputValidationResult(ValidateResult result)
{
    if (result.IsValid)
        Console.WriteLine("Feed is valid");
    else
    {
        Console.WriteLine("Feed is not valid. Errors:");
        foreach (var error in result.Errors)
        {
            Console.WriteLine(error.Message);
        }
    }
    Console.WriteLine();
}