namespace Task2_3.Models.Errors;

public class InvalidPriceErrorCode : ErrorCode
{
    public InvalidPriceErrorCode()
    {
        Message = "CurrentPrice should be a valid price: >= 0 and have only 2 digits after delimiter.";
    }
}