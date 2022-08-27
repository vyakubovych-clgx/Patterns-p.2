using Task2_2.Interfaces;
using Task2_2.Matchers;
using Task2_2.Models;
using Task2_2.Validators;

namespace Task2_2.Importers;

public class EmFeedImporter
{
    private readonly IDatabaseRepository _repository;

    public EmFeedImporter(IDatabaseRepository repository)
    {
        _repository = repository;
    }

    public void Import(IEnumerable<EmFeed> feeds)
    {
        var validator = new EmFeedValidator();
        var matcher = new EmFeedMatcher();

        foreach (var feed in feeds)
        {
            var validationResult = validator.Validate(feed);
            if (validationResult.IsValid)
            {
                var feedsFromRepository = _repository.LoadFeeds<EmFeed>();
                if (!feedsFromRepository.Any(f => matcher.Match(feed, f)))
                    _repository.SaveFeed(feed);
            }
            else _repository.SaveErrors(feed.StagingId, validationResult.Errors.Select(e => e.Message).ToList());
        }
    }
}