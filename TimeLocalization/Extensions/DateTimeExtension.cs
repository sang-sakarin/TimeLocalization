using System;
using System.Globalization;
using TimeLocalization.Localizations;

namespace TimeLocalization.Extensions
{
    public static class DateTimeExtension
    {
        public static string AsTimeAgo(this DateTime dateTime)
        {
            return dateTime.AsTimeAgo(CultureInfo.CurrentUICulture);
        }

        public static string AsTimeAgo(this DateTime dateTime, DateTime comparisonBase)
        {
            return dateTime.AsTimeAgo(comparisonBase, CultureInfo.CurrentUICulture);
        }

        public static string AsTimeAgo(this DateTime dateTime, CultureInfo cultureInfo)
        {
            return dateTime.AsTimeAgo(DateTime.UtcNow, cultureInfo);
        }
        
        public static string AsTimeAgo(this DateTime dateTime, DateTime comparisonBase, CultureInfo cultureInfo)
        {
            var timeSpan = comparisonBase - dateTime;
            var localization = Localization(cultureInfo);
            
            var isAgo = !(timeSpan.TotalSeconds < 0);
            
            if (Math.Abs(timeSpan.Days) >= 365)
            {
                var years = Math.Abs(timeSpan.Days) / 365;
                
                return isAgo ? string.Format(years == 1 ? localization.YearAgo : localization.YearsAgo, years) : string.Format(years == 1 ? localization.InYear : localization.InYears, years);
            }

            if (Math.Abs(timeSpan.Days) > 30)
            {
                var months = Math.Abs(timeSpan.Days) / 30;

                return isAgo ? string.Format(months == 1 ? localization.MonthAgo : localization.MonthsAgo, months) : string.Format(months == 1 ? localization.InMonth : localization.InMonths, months);
            }
            
            if (Math.Abs(timeSpan.Days) > 7)
            {
                var weeks = Math.Abs(timeSpan.Days) / 7;

                return isAgo ? string.Format(weeks == 1 ? localization.WeekAgo : localization.WeeksAgo, weeks) : string.Format(weeks == 1 ? localization.InWeek : localization.InWeeks, weeks);
            }
            
            if (Math.Abs(timeSpan.Days) > 0)
            {
                var days = Math.Abs(timeSpan.Days);

                return isAgo ? string.Format(days == 1 ? localization.DayAgo : localization.DaysAgo, days) : string.Format(days == 1 ? localization.InDay : localization.InDays, days);
            }
            
            if (Math.Abs(timeSpan.Hours) > 0)
            {
                var hours = Math.Abs(timeSpan.Hours);

                return isAgo ? string.Format(hours == 1 ? localization.HourAgo : localization.HoursAgo, hours) : string.Format(hours == 1 ? localization.InHour : localization.InHours, hours);
            }
            
            if (Math.Abs(timeSpan.Minutes) > 0)
            {
                var minutes = Math.Abs(timeSpan.Minutes);

                return isAgo ? string.Format(minutes == 1 ? localization.MinuteAgo : localization.MinutesAgo, minutes) : string.Format(minutes == 1 ? localization.InMinute : localization.InMinutes, minutes);
            }
            
            var seconds = Math.Abs(timeSpan.Seconds);

            return isAgo ? string.Format(seconds <= 1 ? localization.SecondAgo : localization.SecondsAgo, seconds) : string.Format(seconds <= 1 ? localization.InSecond : localization.InSeconds, seconds);
        
        }

        private static ILocalization Localization(CultureInfo cultureInfo)
        {
            switch (cultureInfo.TwoLetterISOLanguageName)
            {
                case "bg": // Bulgarian
                    return new Localization<BgLocalization>();
                case "ca": // Catalan
                    return new Localization<CaLocalization>();
                case "da": // Danish
                    return new Localization<DaLocalization>();
                case "es": // Spanish
                    return new Localization<EsLocalization>();
                case "ja": // Japan
                    return new Localization<JaLocalization>();
                case "th": // Thai
                    return new Localization<ThLocalization>();
                default: // English
                    return new Localization<EnLocalization>();
            }
        }
    }
}