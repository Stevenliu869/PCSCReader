using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Utilities
{
    public static uint GetSystemTickTime()
    {
        return (uint)System.Environment.TickCount;
    }

    public static uint GetTickSpan(uint startTick)
    {
        return ((uint)System.Environment.TickCount - startTick);
    }

    public static UInt32 ConvertToTimestamp(DateTime dateTime)
    {
        // Create Timespan by subtracting the value provided from the Unix Epoch
        TimeSpan tpTimeSpan = (dateTime - (new DateTime(1970, 1, 1, 0, 0, 0, 0)).ToLocalTime());
        // Return the total seconds (which is a UNIX timestamp)
        return Convert.ToUInt32(tpTimeSpan.TotalSeconds);
    }
}
