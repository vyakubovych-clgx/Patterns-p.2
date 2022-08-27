using Task1_5.Enums;
using Task1_5.Interfaces;

namespace Task1_5.Implementations.Recipes;

public class IndianRecipe : IRecipe
{
    public void Cook(ICooker cooker)
    {
        cooker.FryRice(200, Level.Strongly);
        cooker.FryChicken(100, Level.Strongly);
        cooker.SaltRice(Level.Strongly);
        cooker.PepperRice(Level.Strongly);
        cooker.SaltChicken(Level.Strongly);
        cooker.PepperChicken(Level.Strongly);
    }
}