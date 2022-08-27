namespace Task1_2.Filters;

public class BofaFilter :IFilter
{
    public IEnumerable<Trade> Match(IEnumerable<Trade> trades)
        => trades.Where(t => t.Amount > 70);
}