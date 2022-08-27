using Task2_1.Models.Errors;

namespace Task2_1.Models;

public class ValidateResult
{
    public bool IsValid => Errors.Count == 0;
    public List<ErrorCode> Errors { get; set; } = new();
}