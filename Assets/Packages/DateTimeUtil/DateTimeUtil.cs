public static class DateTimeUtil
{
    // NOTE:
    // "using static DateTimeUtil;" is useful.

    #region Field

    // CAUTION:
    // 'f' is quite important to make a value as float.

    public const float DayToHour        = 24;
    public const float DayToMinute      = 24 * 60;
    public const float DayToSecond      = 24 * 60 * 60;
    public const float DayToMillisecond = 24 * 60 * 60 * 1000;

    public const float HourToDay         = 1f / 24;
    public const float HourToMinute      = 60;
    public const float HourToSecond      = 60 * 60;
    public const float HourToMillisecond = 60 * 60 * 1000;

    public const float MinuteToDay         = 1f / 60 / 24;
    public const float MinuteToHour        = 1f / 60;
    public const float MinuteToSecond      = 60;
    public const float MinuteToMillisecond = 60 * 1000;

    public const float SecondToDay         = 1f / 60 / 60 / 24;
    public const float SecondToHour        = 1f / 60 / 60;
    public const float SecondToMinute      = 1f / 60;
    public const float SecondToMillisecond = 1000;

    public const float MillisecondToDay     = 1f / 1000 / 60 / 60 / 24;
    public const float MillisecondToHour    = 1f / 1000 / 60 / 60;
    public const float MillisecondToMinute  = 1f / 1000 / 60;
    public const float MillisecondToSecond  = 1f / 1000;

    // NOTE:
    // These Formats are defined as replaceable value.

    public static string DateTimeFormatMS      = "mm:ss";
    public static string DateTimeFormatHM      = "HH:mm";
    public static string DateTimeFormatHMS     = "HH:mm:ss";
    public static string DateTimeFormatHMSF    = "HH:mm:ss:ff";
    public static string DateTimeFormatYMDHMS  = "yy/MM/dd HH:mm:ss";
    public static string DateTimeFormatYMDHMSF = "yy/MM/dd HH:mm:ss:ff";

    #endregion Field

    #region Property

    public static float DateTimeNowInSecond
    {
        get
        {
            var now = System.DateTime.Now;

            return now.Hour * HourToSecond
                 + now.Minute * MinuteToSecond
                 + now.Second
                 + now.Millisecond * MillisecondToSecond;
        }
    }

    public static string DateTimeNowInMS      => System.DateTime.Now.ToString(DateTimeFormatMS);
    public static string DateTimeNowInHM      => System.DateTime.Now.ToString(DateTimeFormatHM);
    public static string DateTimeNowInHMS     => System.DateTime.Now.ToString(DateTimeFormatHMS);
    public static string DateTimeNowInHMSF    => System.DateTime.Now.ToString(DateTimeFormatHMSF);
    public static string DateTimeNowInYMDHMS  => System.DateTime.Now.ToString(DateTimeFormatYMDHMS);
    public static string DateTimeNowInYMDHMSF => System.DateTime.Now.ToString(DateTimeFormatYMDHMSF);

    #endregion Property
}