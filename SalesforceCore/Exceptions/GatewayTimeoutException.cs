using SalesforceCore.Client;

namespace SalesforceCore.Exceptions
{
    public class GatewayTimeoutException : ApiException
    {
        public GatewayTimeoutException(int errorCode, string message, dynamic errorContent = null) : base(errorCode, message)
        {
            this.ErrorContent = errorContent;
        }
    }
}