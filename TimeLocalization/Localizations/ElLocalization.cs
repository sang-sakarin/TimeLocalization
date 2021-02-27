namespace TimeLocalization.Localizations
{
    public class ElLocalization : ILocalization
    {
        public string SecondAgo { get; set; } = "μόλις τώρα";
        public string SecondsAgo { get; set; } = "{0} δευτερόλεπτα πριν";
        public string MinuteAgo { get; set; } = "1 λεπτό πριν";
        public string MinutesAgo { get; set; } = "{0} λεπτά πριν";
        public string HourAgo { get; set; } = "1 ώρα πριν";
        public string HoursAgo { get; set; } = "{0} ώρες πριν";
        public string DayAgo { get; set; } = "1 μέρα πριν";
        public string DaysAgo { get; set; } = "{0} μέρες πριν";
        public string WeekAgo { get; set; } = "1 εβδομάδα πριν";
        public string WeeksAgo { get; set; } = "{0} εβδομάδες πριν";
        public string MonthAgo { get; set; } = "1 μήνα πριν";
        public string MonthsAgo { get; set; } = "{0} μήνες πριν";
        public string YearAgo { get; set; } = "1 χρόνο πριν";
        public string YearsAgo { get; set; } = "{0} χρόνια πριν";
        public string InSecond { get; set; } = "σε λίγο";
        public string InSeconds { get; set; } = "σε {0} δευτερόλεπτα";
        public string InMinute { get; set; } = "σε 1 λεπτό";
        public string InMinutes { get; set; } = "σε {0} λεπτά";
        public string InHour { get; set; } = "σε 1 ώρα";
        public string InHours { get; set; } = "σε {0} ώρες";
        public string InDay { get; set; } = "σε 1 μέρα";
        public string InDays { get; set; } = "σε {0} μέρες";
        public string InWeek { get; set; } = "σε 1 εβδομάδα";
        public string InWeeks { get; set; } = "σε {0} εβδομάδες";
        public string InMonth { get; set; } = "σε 1 μήνα";
        public string InMonths { get; set; } = "σε {0} μήνες";
        public string InYear { get; set; } = "σε 1 χρόνο";
        public string InYears { get; set; } = "σε {0} χρόνια";
    }
}