﻿using Acc.Lib.Broadcasting.Messages;

namespace Acc.Lib.Shared;

public static class Extensions
{
    public static string ToFriendlyName(this RaceSessionType sessionType)
    {
        return sessionType switch
               {
                   RaceSessionType.HotlapSuperpole => "Hotlap Superpole"
                 , _ => sessionType.ToString()
               };
    }

    public static string ToFriendlyName(this SessionPhase sessionType)
    {
	    return sessionType switch
	           {
		           SessionPhase.FormationLap => "Formation Lap",
                   SessionPhase.PostSession => "Post Session",
                   SessionPhase.PreFormation => "Pre Formation",
                   SessionPhase.PreSession => "Pre Session",
                   SessionPhase.SessionOver => "Session Over",
		           _ => sessionType.ToString()
	           };
    }

    public static string ToFriendlyName(this Nationality nationality)
    {
        return nationality switch
               {
                   Nationality.ChineseTaipei => "Chinese Taipei",
                   Nationality.CzechRepublic => "Czech Republic",
                   Nationality.GreatBritain => "Great Britain",
                   Nationality.HongKong => "Hong Kong",
                   Nationality.NewCaledonia => "New Caledonia",
                   Nationality.NewZealand => "New Zealand",
                   Nationality.NorthernIreland => "Northern Ireland",
                   Nationality.PapuaNewGuinea => "Papua New Guinea",
                   Nationality.PuertoRico => "Puerto Rico",
                   Nationality.SanMarino => "San Marino",
                   Nationality.SaudiArabia => "Saudi Arabia",
                   Nationality.SouthAfrica => "South Africa",
                   Nationality.SouthKorea => "South Korea",
                   _ => nationality.ToString()
               };
    }

    public static long ValidatedValue(this long longValue)
    {
        return longValue >= int.MaxValue? 0: longValue;
    }

    public static int ValidatedValue(this int intValue)
    {
	    return intValue >= int.MaxValue? 0: intValue;
    }

    public static string ToTimeString(this double timeMs)
    {
	    return TimeSpan.FromMilliseconds(timeMs)
	                   .ToString(Constants.TimeFormat);
    }

    public static string ToTimingString(this double timingMs)
    {
	    return TimeSpan.FromMilliseconds(timingMs)
	                   .ToString(Constants.TimingFormat);
    }

    public static string ToTimingString(this float timingMs)
    {
        return TimeSpan.FromMilliseconds(timingMs)
                       .ToString(Constants.TimingFormat);
    }

    public static string ToTimeString(this int timeMs)
    {
	    return TimeSpan.FromMilliseconds(timeMs)
	                   .ToString(Constants.TimeFormat);
    }

    public static string ToTimingString(this int timingMs)
    {
	    return TimeSpan.FromMilliseconds(timingMs)
	                   .ToString(Constants.TimingFormat);
    }

    public static string ToTimeString(this long timeMs)
    {
	    return TimeSpan.FromMilliseconds(timeMs)
	                   .ToString(Constants.TimeFormat);
    }

    public static string ToTimingString(this long timingMs)
    {
	    return TimeSpan.FromMilliseconds(timingMs)
	                   .ToString(Constants.TimingFormat);
    }
}