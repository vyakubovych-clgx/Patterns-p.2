namespace Task1_2.Filters;

public class DeutscheFilter : IFilter
{
    public IEnumerable<Trade> Match(IEnumerable<Trade> trades)
        => trades.Where(t => t.Type == "Option" && t.SubType == "NewOption" && t.Amount is > 90 and < 120);
}