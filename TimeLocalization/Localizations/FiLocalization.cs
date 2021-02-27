namespace TimeLocalization.Localizations
{
    public class FiLocalization : ILocalization
    {
        public string SecondAgo { get; set; } = "juuri äsken";
        public string SecondsAgo { get; set; } = "{0} sekuntia sitten";
        public string MinuteAgo { get; set; } = "minuutti sitten";
        public string MinutesAgo { get; set; } = "{0} minuuttia sitten";
        public string HourAgo { get; set; } = "tunti sitten";
        public string HoursAgo { get; set; } = "{0} tuntia sitten";
        public string DayAgo { get; set; } = "päivä sitten";
        public string DaysAgo { get; set; } = "{0} päivää sitten";
        public string WeekAgo { get; set; } = "viikko sitten";
        public string WeeksAgo { get; set; } = "{0} viikkoa sitten";
        public string MonthAgo { get; set; } = "kuukausi sitten";
        public string MonthsAgo { get; set; } = "{0} kuukautta sitten";
        public string YearAgo { get; set; } = "vuosi sitten";
        public string YearsAgo { get; set; } = "{0} vuotta sitten";
        public string InSecond { get; set; } = "juuri nyt";
        public string InSeconds { get; set; } = "{0} sekunnin päästä";
        public string InMinute { get; set; } = "minuutin päästä";
        public string InMinutes { get; set; } = "{0} minuutin päästä";
        public string InHour { get; set; } = "tunnin päästä";
        public string InHours { get; set; } = "{0} tunnin päästä";
        public string InDay { get; set; } = "päivän päästä";
        public string InDays { get; set; } = "{0} päivän päästä";
        public string InWeek { get; set; } = "viikon päästä";
        public string InWeeks { get; set; } = "{0} viikon päästä";
        public string InMonth { get; set; } = "kuukauden päästä";
        public string InMonths { get; set; } = "{0} kuukauden päästä";
        public string InYear { get; set; } = "vuoden päästä";
        public string InYears { get; set; } = "{0} vuoden päästä";
    }
}