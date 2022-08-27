namespace Task1_4.Interfaces;

public interface IRecipeFactory
{
    IRecipe GetUkrainianRecipe();
    IRecipe GetEnglishRecipe();
    IRecipe GetIndianRecipe();
}