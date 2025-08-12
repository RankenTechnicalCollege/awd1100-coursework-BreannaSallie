using System;

namespace Lab_1
{
    public class InvalidHeightException : ArgumentException
    {
        public InvalidHeightException(string message) : base(message) { }
    }
}
