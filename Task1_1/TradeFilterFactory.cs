using Task1_1.Enums;
using Task1_1.Filters;

namespace Task1_1;

public class TradeFilterFactory
{
    public IFilter GetFilter(Bank bank)
        => bank switch
        {
            Bank.Bofa => new BofaFilter(),
            Bank.Connacord => new ConnacordFilter(),
            Bank.Barclays => new BarclaysFilter(),
            _ => throw new ArgumentException("Unsupported bank", nameof(bank))
        };
}