using Task1_5.Enums;
using Task1_5.Interfaces;

namespace Task1_5.Implementations.Recipes;

public class EnglishSummerRecipe : IRecipe
{
    public void Cook(ICooker cooker)
    {
        cooker.FryRice(50, Level.Low);
        cooker.FryChicken(50, Level.Low);
    }
}