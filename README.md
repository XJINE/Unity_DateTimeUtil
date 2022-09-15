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