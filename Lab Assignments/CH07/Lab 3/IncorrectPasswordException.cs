using System;
namespace Lab_3
{
    public class IncorrectPasswordException : Exception
    { public IncorrectPasswordException(string message) : base(message) { } }
}
