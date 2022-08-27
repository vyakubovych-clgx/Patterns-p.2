namespace Task1_3.Filters;

public class BofaFilter :IFilter
{
    public IEnumerable<Trade> Match(IEnumerable<Trade> trades)
        => trades.Where(t => t.Amount > 70);
}