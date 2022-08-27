using Task2_2.Models.Errors;

namespace Task2_2.Models;

public class ValidateResult
{
    public bool IsValid => Errors.Count == 0;
    public List<ErrorCode> Errors { get; set; } = new();
}