namespace Task2_2.Models.Errors;

public class InvalidAssetValueErrorCode : ErrorCode
{
    public InvalidAssetValueErrorCode()
    {
        Message = "AssetValue should be a valid decimal bigger than 0 and less than Sedol.";
    }
}