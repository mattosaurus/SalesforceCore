using SalesforceCore.Client;

namespace SalesforceCore.Exceptions
{
    public class BadGatewayException : ApiException
    {
        public BadGatewayException(int errorCode, string message, dynamic errorContent = null) : base(errorCode, message)
        {
            this.ErrorContent = errorContent;
        }
    }
}