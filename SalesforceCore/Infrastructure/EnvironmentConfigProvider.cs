using System;
using SalesforceCore.Exceptions;

namespace SalesforceCore
{
    internal class EnvironmentConfigProvider
    {
        public string Get(string variable, bool mandatory = true)
        {
            var envVariableValue = Environment.GetEnvironmentVariable(variable);

            if (envVariableValue != null) return envVariableValue;

            if (mandatory)
            {
                throw new EnvironmentVariableNotSetException(variable);
            }

            return null;
        }
    }
}