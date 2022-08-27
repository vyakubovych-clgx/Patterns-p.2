using Task1_5.Enums;
using Task1_5.Implementations;
using Task1_5.Interfaces;

namespace Task1_5;

public class Restaurant
{
    public void CookMasala(ICooker cooker, Country country, DateTime currentTime)
    {
        var factory = currentTime.Month is 6 or 7 or 8
            ? (IRecipeFactory)new SummerRecipeFactory()
            : new BasicRecipeFactory();
        var recipe = country switch
        {
            Country.Ukraine => factory.GetUkrainianRecipe(),
            Country.England => factory.GetEnglishRecipe(),
            Country.India => factory.GetIndianRecipe(),
            _ => throw new ArgumentException("Unsupported country", nameof(country))
        };
        recipe.Cook(cooker);
    }
}