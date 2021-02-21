namespace TimeLocalization.Localizations
{
    public class Localization<T> : ILocalization where T : ILocalization, new()
    {
        public Localization()
        {
            var localization = new T();
            
            SecondAgo = localization.SecondAgo;
            SecondsAgo = localization.SecondsAgo;
            MinuteAgo = localization.MinuteAgo;
            MinutesAgo = localization.MinutesAgo;
            HourAgo = localization.HourAgo;
            HoursAgo = localization.HoursAgo;
            DayAgo = localization.DaysAgo;
            DaysAgo = localization.DaysAgo;
            WeekAgo = localization.WeekAgo;
            WeeksAgo = localization.WeeksAgo;
            MonthAgo = localization.MonthAgo;
            MonthsAgo = localization.MonthsAgo;
            YearAgo = localization.YearAgo;
            YearsAgo = localization.YearsAgo;
            InSecond = localization.InSecond;
            InSeconds = localization.InSeconds;
            InMinute = localization.InMinute;
            InMinutes = localization.InMinutes;
            InHour = localization.InHour;
            InHours = localization.InHours;
            InDay = localization.InDay;
            InDays = localization.InDays;
            InWeek = localization.InWeek;
            InWeeks = localization.InWeeks;
            InMonth = localization.InMonth;
            InMonths = localization.InMonths;
            InYear = localization.InYear;
            InYears = localization.InYears;
        }
        
        public string SecondAgo { get; set; }
        public string SecondsAgo { get; set; }
        public string MinuteAgo { get; set; }
        public string MinutesAgo { get; set; }
        public string HourAgo { get; set; }
        public string HoursAgo { get; set; }
        public string DayAgo { get; set; }
        public string DaysAgo { get; set; }
        public string WeekAgo { get; set; }
        public string WeeksAgo { get; set; }
        public string MonthAgo { get; set; }
        public string MonthsAgo { get; set; }
        public string YearAgo { get; set; }
        public string YearsAgo { get; set; }
        public string InSecond { get; set; }
        public string InSeconds { get; set; }
        public string InMinute { get; set; }
        public string InMinutes { get; set; }
        public string InHour { get; set; }
        public string InHours { get; set; }
        public string InDay { get; set; }
        public string InDays { get; set; }
        public string InWeek { get; set; }
        public string InWeeks { get; set; }
        public string InMonth { get; set; }
        public string InMonths { get; set; }
        public string InYear { get; set; }
        public string InYears { get; set; }
    }
}