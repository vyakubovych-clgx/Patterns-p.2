using Task1_1;
using Task1_1.Enums;

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
    OutputFilteredTrades(bank);
Console.ReadLine();

void OutputFilteredTrades(Bank bank)
{
    Console.WriteLine($"Filtered trades for {bank}:");
    foreach(var trade in filter.FilterForBank(trades, bank))
        Console.WriteLine(trade);
    Console.WriteLine();
}