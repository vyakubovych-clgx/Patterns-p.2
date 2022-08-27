namespace Task2_2.Models.Errors;

public class InvalidIsinErrorCode : ErrorCode
{
    public InvalidIsinErrorCode()
    {
        Message = "Isin should start with 2 capital letters and then 10 digits.";
    }
}