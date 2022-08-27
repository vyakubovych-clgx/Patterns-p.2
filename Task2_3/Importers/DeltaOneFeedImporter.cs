using Task2_3.Interfaces;
using Task2_3.Matchers;
using Task2_3.Models;
using Task2_3.Validators;

namespace Task2_3.Importers;

public class DeltaOneFeedImporter : IFeedImporter<DeltaOneFeed>
{
    private readonly IDatabaseRepository _repository;

    public DeltaOneFeedImporter(IDatabaseRepository repository)
    {
        _repository = repository;
    }

    public void Import(IEnumerable<DeltaOneFeed> feeds)
    {
        var validator = new DeltaOneFeedValidator();
        var matcher = new DeltaOneFeedMatcher();

        foreach (var feed in feeds)
        {
            var validationResult = validator.Validate(feed);
            if (validationResult.IsValid)
            {
                var feedsFromRepository = _repository.LoadFeeds<DeltaOneFeed>();
                if (!feedsFromRepository.Any(f => matcher.Match(feed, f)))
                    _repository.SaveFeed(feed);
            }
            else _repository.SaveErrors(feed.StagingId, validationResult.Errors.Select(e => e.Message).ToList());
        }
    }
}