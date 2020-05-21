using SalesforceCore.Client;

namespace SalesforceCore.Exceptions
{
    public class UnauthorizedAccessException : ApiException
    {
        public UnauthorizedAccessException(int errorCode, string message, dynamic errorContent = null) : base(errorCode, message)
        {
            this.ErrorContent = errorContent;
        }
    }
}