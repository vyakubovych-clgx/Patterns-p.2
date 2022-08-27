using Task1_5.Implementations.Recipes;
using Task1_5.Interfaces;

namespace Task1_5.Implementations;

public class BasicRecipeFactory : IRecipeFactory
{
    public IRecipe GetUkrainianRecipe() => new UkrainianRecipe();
    public IRecipe GetEnglishRecipe() => new EnglishRecipe();
    public IRecipe GetIndianRecipe() => new IndianRecipe();
}