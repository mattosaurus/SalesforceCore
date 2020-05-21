using SalesforceCore.Client;

namespace SalesforceCore.Exceptions
{
    public class ServerUnreachableException : ApiException
    {
        public ServerUnreachableException(int errorCode, string message, dynamic errorContent = null) : base(errorCode, message)
        {
            this.ErrorContent = errorContent;
        }
    }
}