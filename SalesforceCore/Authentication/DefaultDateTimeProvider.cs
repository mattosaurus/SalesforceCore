using System;

namespace SalesforceCore.Authentication
{
    internal class DefaultDateTimeProvider : IDateTimeProvider
    {
        public DateTime Now => DateTime.Now;
    }
}