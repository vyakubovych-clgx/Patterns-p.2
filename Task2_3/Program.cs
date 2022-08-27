using Task2_3;
using Task2_3.Factories;
using Task2_3.Models;

var repository = new DatabaseRepository();
var deltaOneFeedsToImport = new List<DeltaOneFeed>
{
    new() {
        StagingId = -1,
        SourceTradeRef = "pyshch pyshch ololo",
        CounterpartyId = -2,
        PrincipalId = -3,
        ValuationDate = DateTime.Now,
        CurrentPrice = 12.345m,
        SourceAccountId = -4,
        Isin = "AAAAAAAAAAAAAAAAAAAAAAA",
        MaturityDate = DateTime.Now.AddDays(-1)
    },

    new() {
        StagingId = 1,
        SourceTradeRef = "tyrypyry",
        CounterpartyId = 1,
        PrincipalId = 4,
        ValuationDate = DateTime.Now.AddDays(-1),
        CurrentPrice = 12.34m,
        SourceAccountId = 4,
        Isin = "US9311421039",
        MaturityDate = DateTime.Now
    },

    new() {
        StagingId = 2,
        SourceTradeRef = "test 123",
        CounterpartyId = 3,
        PrincipalId = 3,
        ValuationDate = DateTime.Now.AddDays(-1),
        CurrentPrice = 56.78m,
        SourceAccountId = 4,
        Isin = "AA1234567890",
        MaturityDate = DateTime.Now
    }
};

var emFeedsToImport = new List<EmFeed>()
{
    new()
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
    },

    new() {
        StagingId = 1,
        SourceTradeRef = "blahblahblah",
        CounterpartyId = 2,
        PrincipalId = 3,
        ValuationDate = DateTime.Now.AddDays(-1),
        CurrentPrice = 12.34m,
        SourceAccountId = 4,
        Sedol = 42,
        AssetValue = 13
    },

    new() {
        StagingId = 1,
        SourceTradeRef = "12131214",
        CounterpartyId = 2,
        PrincipalId = 3,
        ValuationDate = DateTime.Now.AddDays(-1),
        CurrentPrice = 14.88m,
        SourceAccountId = 420,
        Sedol = 66,
        AssetValue = 15
    }
};

var deltaOneImporter = new DeltaOneFactory().GetFeedImporter(repository);
deltaOneImporter.Import(deltaOneFeedsToImport);
var emImporter = new EmFactory().GetFeedImporter(repository);
emImporter.Import(emFeedsToImport);

Console.WriteLine("Delta One feeds after import:\n");
OutputFeeds<DeltaOneFeed>();
Console.WriteLine("===================================================================================================\n");
Console.WriteLine("Em feeds after import:\n");
OutputFeeds<EmFeed>();
Console.ReadLine();

void OutputFeeds<T>()
{
    foreach (var feed in repository.LoadFeeds<T>())
    {
        Console.WriteLine(feed);
        Console.WriteLine();
    }
}
