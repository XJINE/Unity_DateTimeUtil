# Unity_DateTimeUtil

``DateTimeUtil`` is just a static class. Not dependence on Unity.

## Import to Your Project

You can import this asset from UnityPackage.

- [DateTimeUtil.unitypackage](https://github.com/XJINE/Unity_DateTimeUtil/blob/master/DateTimeUtil.unitypackage)

## How to Use

``SytemTimeSecondNow`` will return current h.m.s time in second.

Multiply these parameters. ``using DateTimeConverter;`` is useful.

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

There are some useful properties.

```csharp
public static float DateTimeNowInSecond;

public static string DateTimeFormatHMSF   = "HH:mm:ss:ff";
public static string DateTimeFormatYMDHMS = "yy/MM/dd HH:mm:ss";

public static string DateTimeNowInHMSF;
public static string DateTimeNowInYMDHMS;
```
