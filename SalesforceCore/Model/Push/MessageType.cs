using System;
using System.Collections.Generic;
using System.Text;

namespace SalesforceCore.Model.Push
{
    /// <summary>
    /// Indicates the type of message to create.
    /// </summary>
    public enum MessageType
    {
        Outbound = 1,
        LocationEntry = 3,
        LocationExit = 4,
        Beacon = 5,
        Inbox = 8
    }
}
