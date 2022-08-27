using Task2_1.Models;

namespace Task2_1.Interfaces;

public interface IFeedValidator<T> where T : TradeFeed
{
    ValidateResult Validate(T feed);
}