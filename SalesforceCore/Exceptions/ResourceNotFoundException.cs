using SalesforceCore.Client;

namespace SalesforceCore.Exceptions
{
    public class ResourceNotFoundException : ApiException
    {
        public ResourceNotFoundException(int errorCode, string message, dynamic errorContent = null) : base(errorCode, message)
        {
            this.ErrorContent = errorContent;
        }
    }
}