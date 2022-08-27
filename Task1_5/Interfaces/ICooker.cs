using Task1_5.Enums;

namespace Task1_5.Interfaces;

public interface ICooker
{
    void FryRice(int amount, Level level);
    void FryChicken(int amount, Level level);
    void SaltRice(Level level);
    void SaltChicken(Level level);
    void PepperRice(Level level);
    void PepperChicken(Level level);
}