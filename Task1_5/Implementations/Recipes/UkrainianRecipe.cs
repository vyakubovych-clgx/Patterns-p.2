using Task1_5.Enums;
using Task1_5.Interfaces;

namespace Task1_5.Implementations.Recipes;

public class UkrainianRecipe : IRecipe
{
    public void Cook(ICooker cooker)
    {
        cooker.FryRice(500, Level.Strongly);
        cooker.FryChicken(300, Level.Medium);
        cooker.SaltRice(Level.Strongly);
        cooker.PepperRice(Level.Low);
        cooker.SaltChicken(Level.Medium);
        cooker.PepperChicken(Level.Low);
    }
}