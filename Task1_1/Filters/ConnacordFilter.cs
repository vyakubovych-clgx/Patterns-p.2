namespace Task1_1.Filters;

public class ConnacordFilter : IFilter
{
    public IEnumerable<Trade> Match(IEnumerable<Trade> trades)
        => trades.Where(t => t.Type == "Future" && t.Amount is > 10 and < 40);
}