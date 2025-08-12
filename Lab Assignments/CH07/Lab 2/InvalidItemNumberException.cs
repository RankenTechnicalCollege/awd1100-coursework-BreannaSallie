using System;
namespace Lab_2
{
    public class InvalidItemNumberException : ArgumentException
    { public InvalidItemNumberException(string message) : base(message) { } }
}
