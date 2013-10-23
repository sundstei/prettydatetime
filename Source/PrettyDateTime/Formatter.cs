﻿using System;

namespace PrettyDateTime
{
    public static class Formatter
    {
        private static string GetPrettyDate(DateTime d)
        {
            TimeSpan s = DateTime.Now.Subtract(d);
            var dayDiff = (int) s.TotalDays;
            var secDiff = (int) s.TotalSeconds;
            if (dayDiff < 0 || dayDiff >= 31)
            {
                return null;
            }

            if (dayDiff == 0)
            {
                if (secDiff < 60)
                {
                    return "just now";
                }
                if (secDiff < 120)
                {
                    return "1 minute ago";
                }
                if (secDiff < 3600)
                {
                    return string.Format("{0} minutes ago", Math.Floor((double) secDiff/60));
                }
                if (secDiff < 7200)
                {
                    return "1 hour ago";
                }
                if (secDiff < 86400)
                {
                    return string.Format("{0} hours ago", Math.Floor((double) secDiff/3600));
                }
            }
            if (dayDiff == 1)
            {
                return "yesterday";
            }
            if (dayDiff < 7)
            {
                return string.Format("{0} days ago", dayDiff);
            }
            if (dayDiff < 31)
            {
                return string.Format("{0} weeks ago", Math.Ceiling((double) dayDiff/7));
            }
            return null;
        }
    }
}