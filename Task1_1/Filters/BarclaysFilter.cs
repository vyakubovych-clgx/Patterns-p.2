namespace Task1_1.Filters;

public class BarclaysFilter : IFilter
{
    public IEnumerable<Trade> Match(IEnumerable<Trade> trades)
        => trades.Where(t => t.Type == "Option" && t.SubType == "NyOption" && t.Amount > 50);
}