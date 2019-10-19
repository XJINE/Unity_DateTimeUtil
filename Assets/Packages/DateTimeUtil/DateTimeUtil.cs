public static class DateTimeUtil
{
    // NOTE:
    // "using DateTimeUtil;" is useful.

    #region Field

    public const float DayToHour        = 24;
    public const float DayToMinute      = 24 * 60;
    public const float DayToSecond      = 24 * 60 * 60;
    public const float DayToMillisecond = 24 * 60 * 60 * 100;

    public const float HourToDay         = 1 / 24;
    public const float HourToMinute      = 60;
    public const float HourToSecond      = 60 * 60;
    public const float HourToMillisecond = 60 * 60 * 100;

    public const float MinuteToDay         = 1 / 60 / 24;
    public const float MinuteToHour        = 1 / 60;
    public const float MinuteToSecond      = 60;
    public const float MinuteToMillisecond = 60 * 100;

    public const float SecondToDay         = 1 / 60 / 60 / 24;
    public const float SecondToHour        = 1 / 60 / 60;
    public const float SecondToMinute      = 1 / 60;
    public const float SecondToMillisecond = 100;

    public const float MillisecondToDay     = 1 / 100 / 60 / 60 / 24;
    public const float MillisecondToHour    = 1 / 100 / 60 / 60;
    public const float MillisecondToMinute  = 1 / 100 / 60;
    public const float MillisecondToSecond  = 1 / 100;

    // NOTE:
    // These Formats are defined as replaceable value.

    public static string DateTimeFormatHMSF   = "HH:mm:ss:ff";
    public static string DateTimeFormatYMDHMS = "yy/MM/dd HH:mm:ss";

    #endregion Field

    #region Property

    public static float DateTimeNowInSecond
    {
        get
        {
            var now = System.DateTime.Now;

            return now.Hour   * HourToSecond
                 + now.Minute * MinuteToSecond
                 + now.Second;
        }
    }

    public static string DateTimeNowInHMSF
    { 
        get { return System.DateTime.Now.ToString(DateTimeFormatHMSF); }
    }

    public static string DateTimeNowInYMDHMS
    {
        get { return System.DateTime.Now.ToString(DateTimeFormatYMDHMS); }
    }

    #endregion Property
}