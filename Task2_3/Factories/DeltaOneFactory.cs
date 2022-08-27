using Task2_3.Importers;
using Task2_3.Interfaces;
using Task2_3.Models;

namespace Task2_3.Factories;

public class DeltaOneFactory : ITradeFeedFactory<DeltaOneFeed>
{
    public IFeedImporter<DeltaOneFeed> GetFeedImporter(IDatabaseRepository repository)
        => new DeltaOneFeedImporter(repository);
}