namespace Task2_3.Models.Errors;

public class InvalidIdErrorCode : ErrorCode
{
    public InvalidIdErrorCode(string propertyName)
    {
        Message = $"{propertyName} must be valid non-negative identifier >= 1.";
    }
}