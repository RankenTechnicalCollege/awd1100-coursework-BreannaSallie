using System;
namespace Lab_2
{
    public class InvalidQuantityException : ArgumentException
    { public InvalidQuantityException(string message) : base(message) { } }
}