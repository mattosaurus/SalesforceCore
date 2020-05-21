﻿using System;

namespace SalesforceCore.Exceptions
{
    public class EnvironmentVariableNotSetException : Exception
    {
        public string Variable { get; }

        public EnvironmentVariableNotSetException(string variable)
            : base($"Env variable {variable} is not set")
        {
            Variable = variable;
        }
    }
}