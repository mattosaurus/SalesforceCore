using System;

namespace SalesforceCore.Authentication
{
    internal interface IDateTimeProvider
    {
        DateTime Now { get; }
    }
}