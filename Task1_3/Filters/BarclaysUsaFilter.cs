namespace Task1_3.Filters;

public class BarclaysUsaFilter : IFilter
{
    public IEnumerable<Trade> Match(IEnumerable<Trade> trades)
        => trades.Where(t => t.Type == "Option" && t.SubType == "NyOption" && t.Amount > 50);
}