using Task2_3.Importers;
using Task2_3.Interfaces;
using Task2_3.Models;

namespace Task2_3.Factories;

public class EmFactory : ITradeFeedFactory<EmFeed>
{
    public IFeedImporter<EmFeed> GetFeedImporter(IDatabaseRepository repository)
        => new EmFeedImporter(repository);
}