namespace AKSoft.DataStructures.Core.Exception;

using System;


public class InvalidArgumentException : Exception
{
    public InvalidArgumentException(string? message) : base(message)
    {
    }
}