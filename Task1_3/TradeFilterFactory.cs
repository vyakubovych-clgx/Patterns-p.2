using Task1_3.Enums;
using Task1_3.Filters;

namespace Task1_3;

public class TradeFilterFactory
{
    public IFilter GetFilter(Bank bank, Country country)
        => bank switch
        {
            Bank.Bofa => new BofaFilter(),
            Bank.Connacord => new ConnacordFilter(),
            Bank.Barclays => country switch
            {
                Country.USA => new BarclaysUsaFilter(),
                Country.England => new BarclaysEnglandFilter(),
                _ => throw new ArgumentException("Unsupported country", nameof(country))
            },
            Bank.Deutsche => new DeutscheFilter(),
            _ => throw new ArgumentException("Unsupported bank", nameof(bank))
        };
}