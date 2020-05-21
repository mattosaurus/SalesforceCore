namespace SalesforceCore.Authentication
{
    public interface IAuthService
    {
        AuthorizationToken GetAuthorizationToken();
    }
}