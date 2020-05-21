﻿using SalesforceCore.Client;

namespace SalesforceCore.Exceptions
{
    public class ServiceUnavailableException : ApiException
    {
        public ServiceUnavailableException(int errorCode, string message, dynamic errorContent = null) : base(errorCode, message)
        {
            this.ErrorContent = errorContent;
        }
    }
}