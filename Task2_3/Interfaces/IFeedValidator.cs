using Task2_3.Models;

namespace Task2_3.Interfaces;

public interface IFeedValidator<T> where T : TradeFeed
{
    ValidateResult Validate(T feed);
}