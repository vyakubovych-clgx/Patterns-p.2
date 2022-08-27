using Task2_2.Models;

namespace Task2_2.Interfaces;

public interface IFeedValidator<T> where T : TradeFeed
{
    ValidateResult Validate(T feed);
}