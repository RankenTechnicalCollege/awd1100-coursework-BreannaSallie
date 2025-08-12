using System;

namespace Lab_1
{
    public class InvalidWeightException : ArgumentException
    {
        public InvalidWeightException(string message) : base(message) { }
    }
}
