using Task1_5;
using Task1_5.Enums;
using Task1_5.Implementations;

var cooker = new Cooker();
var restaurant = new Restaurant();
foreach (var country in Enum.GetValues<Country>())
{
    Console.WriteLine($"Cooking masala in {country} in winter:");
    restaurant.CookMasala(cooker, country, new DateTime(2022, 12, 31));
    Console.WriteLine();
    Console.WriteLine($"Cooking masala in {country} in summer:");
    restaurant.CookMasala(cooker, country, new DateTime(2022, 8, 24));
    Console.WriteLine();
}

Console.ReadLine();