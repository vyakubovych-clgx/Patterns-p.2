using Task1_4.Enums;
using Task1_4.Implementations;
using Task1_4.Interfaces;

namespace Task1_4;

public class Restaurant
{
    public void CookMasala(ICooker cooker, Country country)
    {
        var factory = new RecipeFactory();
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