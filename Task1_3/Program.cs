using Task1_3;
using Task1_3.Enums;

var trades = new Trade[] 
{
    new("Future", "SomeWeirdSubType", 101),
    new("Future", "SomeWeirdSubType", 26),
    new("Option", "NyOption", 89),
    new("Future", "NyOption", 52),
    new("Option", "NewOption", 111)
};

var filter = new TradeFilter();
foreach(var bank in Enum.GetValues<Bank>())
foreach (var country in Enum.GetValues<Country>())
    OutputFilteredTrades(bank, country);
Console.ReadLine();

void OutputFilteredTrades(Bank bank, Country country)
{
    Console.WriteLine($"Filtered trades for {bank} in {country}:");
    foreach(var trade in filter.FilterForBank(trades, bank, country))
        Console.WriteLine(trade);
    Console.WriteLine();
}