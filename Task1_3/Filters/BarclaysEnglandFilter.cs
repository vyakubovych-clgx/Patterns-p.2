namespace Task1_3.Filters;

public class BarclaysEnglandFilter : IFilter
{
    public IEnumerable<Trade> Match(IEnumerable<Trade> trades)
        => trades.Where(t => t.Type == "Future" && t.Amount > 100);
}