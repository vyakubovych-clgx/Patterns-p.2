using Task1_2.Enums;

namespace Task1_2;

public class TradeFilter
{
    public IEnumerable<Trade> FilterForBank(IEnumerable<Trade> trades, Bank bank)
    {
        var filterFactory = new TradeFilterFactory();
        var filter = filterFactory.GetFilter(bank);
        return filter.Match(trades);
    }
}