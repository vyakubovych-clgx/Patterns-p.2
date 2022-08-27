using Task1_3.Enums;

namespace Task1_3;

public class TradeFilter
{
    public IEnumerable<Trade> FilterForBank(IEnumerable<Trade> trades, Bank bank, Country country)
    {
        var filterFactory = new TradeFilterFactory();
        var filter = filterFactory.GetFilter(bank, country);
        return filter.Match(trades);
    }
}