using System;
using System.Collections.Generic;
using System.Text;

namespace SalesforceCore.Model.Push
{
    public enum TzPastSendActionType
    {
        SendImmediately = 1,
        SendAtScheduledTimeNextDay = 2,
        NeverSend = 3
    }
}
