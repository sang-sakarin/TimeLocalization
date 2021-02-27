namespace TimeLocalization.Localizations
{
    public class EuLocalization : ILocalization
    {
        public string SecondAgo { get; set; } = "orain";
        public string SecondsAgo { get; set; } = "duela {0} segundu";
        public string MinuteAgo { get; set; } = "duela minutu 1";
        public string MinutesAgo { get; set; } = "duela {0} minutu";
        public string HourAgo { get; set; } = "duela ordu 1";
        public string HoursAgo { get; set; } = "duela {0} ordu";
        public string DayAgo { get; set; } = "duela egun 1";
        public string DaysAgo { get; set; } = "duela {0} egun";
        public string WeekAgo { get; set; } = "duela aste 1";
        public string WeeksAgo { get; set; } = "duela {0} aste";
        public string MonthAgo { get; set; } = "duela hillabete 1";
        public string MonthsAgo { get; set; } = "duela {0} hillabete";
        public string YearAgo { get; set; } = "duela urte 1";
        public string YearsAgo { get; set; } = "duela {0} urte";
        public string InSecond { get; set; } = "denbora bat barru";
        public string InSeconds { get; set; } = "{0} segundu barru";
        public string InMinute { get; set; } = "minutu 1 barru";
        public string InMinutes { get; set; } = "{0} minutu barru";
        public string InHour { get; set; } = "ordu {0} barru";
        public string InHours { get; set; } = "{0} ordu barru";
        public string InDay { get; set; } = "egun 1 barru";
        public string InDays { get; set; } = "{0} egun barru";
        public string InWeek { get; set; } = "aste 1 barru";
        public string InWeeks { get; set; } = "{0} aste barru";
        public string InMonth { get; set; } = "hillabete 1 barru";
        public string InMonths { get; set; } = "{0} hillabete barru";
        public string InYear { get; set; } = "urte 1 barru";
        public string InYears { get; set; } = "{0} urte barru";
    }
}