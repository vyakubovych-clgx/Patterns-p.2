using Task1_4.Implementations.Recipes;
using Task1_4.Interfaces;

namespace Task1_4.Implementations;

public class RecipeFactory : IRecipeFactory
{
    public IRecipe GetUkrainianRecipe() => new UkrainianRecipe();
    public IRecipe GetEnglishRecipe() => new EnglishRecipe();
    public IRecipe GetIndianRecipe() => new IndianRecipe();
}