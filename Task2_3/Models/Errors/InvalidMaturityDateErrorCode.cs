namespace Task2_3.Models.Errors;

public class InvalidMaturityDateErrorCode : ErrorCode
{
    public InvalidMaturityDateErrorCode()
    {
        Message = "MaturityDate should be bigger than ValuationDate.";
    }
}