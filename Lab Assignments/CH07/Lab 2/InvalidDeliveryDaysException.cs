using System;
namespace Lab_2
{
    public class InvalidDeliveryDaysException : ArgumentException
    { public InvalidDeliveryDaysException(string message) : base(message) { } }
}