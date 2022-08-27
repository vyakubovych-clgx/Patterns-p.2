namespace Task2_2.Models.Errors;

public class InvalidMaturityDateErrorCode : ErrorCode
{
    public InvalidMaturityDateErrorCode()
    {
        Message = "MaturityDate should be bigger than ValuationDate.";
    }
}