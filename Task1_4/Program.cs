using Task1_4;
using Task1_4.Enums;
using Task1_4.Implementations;

var cooker = new Cooker();
var restaurant = new Restaurant();
foreach (var country in Enum.GetValues<Country>())
{
    Console.WriteLine($"Cooking masala in {country}:");
    restaurant.CookMasala(cooker, country);
    Console.WriteLine();
}

Console.ReadLine();