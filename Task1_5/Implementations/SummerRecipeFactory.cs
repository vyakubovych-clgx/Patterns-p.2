using Task1_5.Implementations.Recipes;
using Task1_5.Interfaces;

namespace Task1_5.Implementations;

public class SummerRecipeFactory : IRecipeFactory
{
    public IRecipe GetUkrainianRecipe() => new UkrainianSummerRecipe();
    public IRecipe GetEnglishRecipe() => new EnglishSummerRecipe();
    public IRecipe GetIndianRecipe() => new IndianSummerRecipe();
}