using SalesforceCore.Client;

namespace SalesforceCore.Exceptions
{
    public class BadRequestException : ApiException
    {
        public BadRequestException(int errorCode, string message, dynamic errorContent = null) : base(errorCode, message)
        {
            this.ErrorContent = errorContent;
        }
    }
}