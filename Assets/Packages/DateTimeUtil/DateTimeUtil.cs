public static class DateTimeUtil
{
    // NOTE:
    // "using DateTimeUtil" is useful.

    public static float DayToHour        = 24;
    public static float DayToMinute      = 24 * 60;
    public static float DayToSecond      = 24 * 60 * 60;
    public static float DayToMillisecond = 24 * 60 * 60 * 100;

    public static float HourToDay         = 1 / 24;
    public static float HourToMinute      = 60;
    public static float HourToSecond      = 60 * 60;
    public static float HourToMillisecond = 60 * 60 * 100;

    public static float MinuteToDay         = 1 / 60 / 24;
    public static float MinuteToHour        = 1 / 60;
    public static float MinuteToSecond      = 60;
    public static float MinuteToMillisecond = 60 * 100;

    public static float SecondToDay         = 1 / 60 / 60 / 24;
    public static float SecondToHour        = 1 / 60 / 60;
    public static float SecondToMinute      = 1 / 60;
    public static float SecondToMillisecond = 100;

    public static float MillisecondToDay     = 1 / 100 / 60 / 60 / 24;
    public static float MillisecondToHour    = 1 / 100 / 60 / 60;
    public static float MillisecondToMinute  = 1 / 100 / 60;
    public static float MillisecondToSecond  = 1 / 100;

    public static float SytemTimeSecondNow
    {
        get
        {
            var now = System.DateTime.Now;

            return now.Hour   * HourToSecond
                 + now.Minute * MinuteToSecond
                 + now.Second;
        }
    }
}