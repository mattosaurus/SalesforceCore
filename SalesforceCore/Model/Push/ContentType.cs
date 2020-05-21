using System;
using System.Collections.Generic;
using System.Text;

namespace SalesforceCore.Model.Push
{
    /// <summary>
    /// Indicates the content included within the message.
    /// </summary>
    public enum ContentType
    {
        Alert = 1,
        Inbox = 2,
        InboxAndAlert = 3
    }
}
