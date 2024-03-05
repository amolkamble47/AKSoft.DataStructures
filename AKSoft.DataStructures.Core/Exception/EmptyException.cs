namespace AKSoft.DataStructures.Core.Exception;

using System;

public class EmptyException : Exception
{
    public EmptyException(string? message) : base(message)
    {
    }
}
