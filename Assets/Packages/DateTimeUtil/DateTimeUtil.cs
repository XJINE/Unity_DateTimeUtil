using System;

public static class DateTimeUtil
{
    // NOTE:
    // "using static DateTimeUtil;" is useful.

    public const float DayToHour        = 24;
    public const float DayToMinute      = 24 * 60;
    public const float DayToSecond      = 24 * 60 * 60;
    public const float DayToMillisecond = 24 * 60 * 60 * 1000;

    public const float HourToDay         = 1f / DayToHour;
    public const float HourToMinute      = 60;
    public const float HourToSecond      = 60 * 60;
    public const float HourToMillisecond = 60 * 60 * 1000;

    public const float MinuteToDay         = 1f / DayToMinute;
    public const float MinuteToHour        = 1f / HourToMinute;
    public const float MinuteToSecond      = 60;
    public const float MinuteToMillisecond = 60 * 1000;

    public const float SecondToDay         = 1f / DayToSecond;
    public const float SecondToHour        = 1f / HourToSecond;
    public const float SecondToMinute      = 1f / MinuteToSecond;
    public const float SecondToMillisecond = 1000;

    public const float MillisecondToDay     = 1f / DayToMillisecond;
    public const float MillisecondToHour    = 1f / HourToMillisecond;
    public const float MillisecondToMinute  = 1f / MinuteToMillisecond;
    public const float MillisecondToSecond  = 1f / SecondToMillisecond;

    public static float DateTimeNowInSecond => (float)DateTime.Now.TimeOfDay.TotalSeconds;

    // NOTE:
    // These Formats are defined as replaceable value.

    public static string DateTimeFormatMS      = "mm:ss";
    public static string DateTimeFormatHM      = "HH:mm";
    public static string DateTimeFormatHMS     = "HH:mm:ss";
    public static string DateTimeFormatHMSF    = "HH:mm:ss:ff";
    public static string DateTimeFormatYMDHMS  = "yy/MM/dd HH:mm:ss";
    public static string DateTimeFormatYMDHMSF = "yy/MM/dd HH:mm:ss:ff";

    public static string DateTimeNowInMS      => DateTime.Now.ToString(DateTimeFormatMS);
    public static string DateTimeNowInHM      => DateTime.Now.ToString(DateTimeFormatHM);
    public static string DateTimeNowInHMS     => DateTime.Now.ToString(DateTimeFormatHMS);
    public static string DateTimeNowInHMSF    => DateTime.Now.ToString(DateTimeFormatHMSF);
    public static string DateTimeNowInYMDHMS  => DateTime.Now.ToString(DateTimeFormatYMDHMS);
    public static string DateTimeNowInYMDHMSF => DateTime.Now.ToString(DateTimeFormatYMDHMSF);
}