namespace Task2_2.Models.Errors;

public class InvalidPriceErrorCode : ErrorCode
{
    public InvalidPriceErrorCode()
    {
        Message = "CurrentPrice should be a valid price: >= 0 and have only 2 digits after delimiter.";
    }
}