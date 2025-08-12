using System;
namespace Lab_3
{
    public class AccountDisabledException : Exception
    { public AccountDisabledException(string message) : base(message) { } }
}