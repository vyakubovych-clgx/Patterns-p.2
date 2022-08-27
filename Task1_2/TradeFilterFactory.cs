using Task1_2.Enums;
using Task1_2.Filters;

namespace Task1_2;

public class TradeFilterFactory
{
    public IFilter GetFilter(Bank bank)
        => bank switch
        {
            Bank.Bofa => new BofaFilter(),
            Bank.Connacord => new ConnacordFilter(),
            Bank.Barclays => new BarclaysFilter(),
            Bank.Deutsche => new DeutscheFilter(),
            _ => throw new ArgumentException("Unsupported bank", nameof(bank))
        };
}