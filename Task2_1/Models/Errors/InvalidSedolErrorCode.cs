﻿namespace Task2_1.Models.Errors;

public class InvalidSedolErrorCode : ErrorCode
{
    public InvalidSedolErrorCode()
    {
        Message = "Sedol should be a valid decimal bigger than 0 and less than 100.";
    }
}