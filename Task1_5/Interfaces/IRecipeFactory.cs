namespace Task1_5.Interfaces;

public interface IRecipeFactory
{
    IRecipe GetUkrainianRecipe();
    IRecipe GetEnglishRecipe();
    IRecipe GetIndianRecipe();
}