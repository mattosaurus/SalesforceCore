using SalesforceCore.Model;

namespace SalesforceCore.Authentication
{
    public interface ICacheService
    {
        TokenResponse Get(string key);
        void AddOrUpdate(string key, TokenResponse value);
    }
}