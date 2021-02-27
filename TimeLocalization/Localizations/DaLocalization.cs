namespace TimeLocalization.Localizations
{
    public class DaLocalization : ILocalization
    {
        public string SecondAgo { get; set; } = "for et øjeblik siden";
        public string SecondsAgo { get; set; } = "for {0} sekunder siden";
        public string MinuteAgo { get; set; } = "for 1 minut siden";
        public string MinutesAgo { get; set; } = "for {0} minutter siden";
        public string HourAgo { get; set; } = "for 1 time siden";
        public string HoursAgo { get; set; } = "for {0} timer siden";
        public string DayAgo { get; set; } = "for 1 dag siden";
        public string DaysAgo { get; set; } = "for {0} dage siden";
        public string WeekAgo { get; set; } = "for 1 uge siden";
        public string WeeksAgo { get; set; } = "for {0} uger siden";
        public string MonthAgo { get; set; } = "for 1 måned siden";
        public string MonthsAgo { get; set; } = "for {0} måneder siden";
        public string YearAgo { get; set; } = "for 1 år siden";
        public string YearsAgo { get; set; } = "for {0} år siden";
        public string InSecond { get; set; } = "om et øjeblik";
        public string InSeconds { get; set; } = "om {0} sekunder";
        public string InMinute { get; set; } = "om 1 minut";
        public string InMinutes { get; set; } = "om {0} minutter";
        public string InHour { get; set; } = "om 1 time";
        public string InHours { get; set; } = "om {0} timer";
        public string InDay { get; set; } = "om 1 dag";
        public string InDays { get; set; } = "om {0} dage";
        public string InWeek { get; set; } = "om 1 uge";
        public string InWeeks { get; set; } = "om {0} uger";
        public string InMonth { get; set; } = "om 1 måned";
        public string InMonths { get; set; } = "om {0} måneder";
        public string InYear { get; set; } = "om 1 år";
        public string InYears { get; set; } = "om {0} år";
    }
}