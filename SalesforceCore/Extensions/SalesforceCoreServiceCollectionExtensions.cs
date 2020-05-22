using Microsoft.Extensions.DependencyInjection;
using System;
using SalesforceCore.Api;
using SalesforceCore.Client;

namespace SalesforceCore.Extensions
{
    public static class SalesforceCoreServiceCollectionExtensions
    {
        public static IServiceCollection AddSalesforce(this IServiceCollection collection,
            Action<Configuration> setupAction)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));
            if (setupAction == null) throw new ArgumentNullException(nameof(setupAction));

            collection.Configure(setupAction);
            return collection.AddSingleton<IClient, Api.Client>();
        }
    }
}
