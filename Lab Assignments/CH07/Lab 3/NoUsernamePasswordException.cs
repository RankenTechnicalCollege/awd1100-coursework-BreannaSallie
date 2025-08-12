using System;
namespace Lab_3
{
    public class NoUsernamePasswordException : Exception
    { public NoUsernamePasswordException(string message) : base(message) { } }
}