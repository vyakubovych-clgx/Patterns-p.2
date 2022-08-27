using Task1_5.Enums;
using Task1_5.Interfaces;

namespace Task1_5.Implementations.Recipes;

public class UkrainianSummerRecipe : IRecipe
{
    public void Cook(ICooker cooker)
    {
        cooker.FryRice(150, Level.Medium);
        cooker.FryChicken(200, Level.Medium);
        cooker.SaltRice(Level.Low);
        cooker.SaltChicken(Level.Low);
    }
}