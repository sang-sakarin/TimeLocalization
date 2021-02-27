namespace TimeLocalization.Localizations
{
    public class DeLocalization : ILocalization
    {
        public string SecondAgo { get; set; } = "gerade eben";
        public string SecondsAgo { get; set; } = "vor {0} Sekunden";
        public string MinuteAgo { get; set; } = "vor 1 Minute";
        public string MinutesAgo { get; set; } = "vor {0} Minuten";
        public string HourAgo { get; set; } = "vor einer Stunde";
        public string HoursAgo { get; set; } = "vor {0} Stunden";
        public string DayAgo { get; set; } = "vor 1 Tag";
        public string DaysAgo { get; set; } = "vor {0} Tagen";
        public string WeekAgo { get; set; } = "vor 1 Woche";
        public string WeeksAgo { get; set; } = "vor {0} Wochen";
        public string MonthAgo { get; set; } = "vor 1 Monat";
        public string MonthsAgo { get; set; } = "vor {0} Monaten";
        public string YearAgo { get; set; } = "vor 1 Jahr";
        public string YearsAgo { get; set; } = "vor {0} Jahren";
        public string InSecond { get; set; } = "gleich";
        public string InSeconds { get; set; } = "in {0} Sekunden";
        public string InMinute { get; set; } = "in 1 Minute";
        public string InMinutes { get; set; } = "in {0} Minuten";
        public string InHour { get; set; } = "in 1 Stunde";
        public string InHours { get; set; } = "in {0} Stunden";
        public string InDay { get; set; } = "in 1 Tag";
        public string InDays { get; set; } = "in {0} Tagen";
        public string InWeek { get; set; } = "in 1 Woche";
        public string InWeeks { get; set; } = "in {0} Wochen";
        public string InMonth { get; set; } = "in 1 Monat";
        public string InMonths { get; set; } = "in {0} Monaten";
        public string InYear { get; set; } = "in 1 Jah";
        public string InYears { get; set; } = "in {0} Jahren";
    }
}