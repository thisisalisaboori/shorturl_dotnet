
using System;
namespace Infrastructure.Util;
public static class DateTimeHelper
{
    private static DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
    public static long ToEpoch(this DateTime from)
    {
        return Convert.ToInt64((from - epoch).TotalSeconds); ;
    }
}