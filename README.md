# Unity_DateTimeUtil

``DateTimeUtil`` is just a static class. Not dependence on Unity.

## Importing

You can use Package Manager or import it directly.

```
https://github.com/XJINE/Unity_DateTimeUtil.git?path=Assets/Packages/DateTimeUtil
```

## How to Use

### Convert Day/Hour/Minute/Second

Multiply these parameters.

```csharp
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
```

or use ``public static float DateTimeNowInSecond;`` property.

### Convert to string

Use popular format or the properties.

```csharp

public static string DateTimeFormatHMSF   = "HH:mm:ss:ff";
public static string DateTimeFormatYMDHMS = "yy/MM/dd HH:mm:ss";

public static string DateTimeNowInHMSF;
public static string DateTimeNowInYMDHMS;
```

### Season

There are some property and methods to get Season.

```csharp
public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}

public static Season SeasonFromDateTimeNowMonthInJapan
public static Season SeasonFromDateTimeNowMonth(int shiftMonth)
public static Season SeasonFromMoneth(int month)
```
