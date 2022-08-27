﻿using Task1_5.Enums;
using Task1_5.Interfaces;

namespace Task1_5.Implementations.Recipes;

public class EnglishRecipe : IRecipe
{
    public void Cook(ICooker cooker)
    {
        cooker.FryRice(100, Level.Low);
        cooker.FryChicken(100, Level.Low);
    }
}