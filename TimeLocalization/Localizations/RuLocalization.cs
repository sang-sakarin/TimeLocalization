namespace TimeLocalization.Localizations
{
    public class RuLocalization : ILocalization
    {
        public string SecondAgo { get; set; } = "только что";
        public string SecondsAgo { get; set; } = "{0} секунд назад";
        public string MinuteAgo { get; set; } = "1 минуту назад";
        public string MinutesAgo { get; set; } = "{0} минут назад";
        public string HourAgo { get; set; } = "1 час назад";
        public string HoursAgo { get; set; } = "{0} часов назад";
        public string DayAgo { get; set; } = "1 день назад";
        public string DaysAgo { get; set; } = "{0} дней назад";
        public string WeekAgo { get; set; } = "1 неделю назад";
        public string WeeksAgo { get; set; } = "{0} недель назад";
        public string MonthAgo { get; set; } = "1 месяц назад";
        public string MonthsAgo { get; set; } = "{0} месяцев назад";
        public string YearAgo { get; set; } = "1 год назад";
        public string YearsAgo { get; set; } = "{0} лет назад";
        public string InSecond { get; set; } = "скоро";
        public string InSeconds { get; set; } = "через {0} секунд";
        public string InMinute { get; set; } = "через 1 минуту";
        public string InMinutes { get; set; } = "через {0} минут";
        public string InHour { get; set; } = "через 1 час";
        public string InHours { get; set; } = "через {0} часов";
        public string InDay { get; set; } = "через 1 день";
        public string InDays { get; set; } = "через {0} дней";
        public string InWeek { get; set; } = "через 1 неделю";
        public string InWeeks { get; set; } = "через {0} недель";
        public string InMonth { get; set; } = "через 1 месяц";
        public string InMonths { get; set; } = "через {0} месяцев";
        public string InYear { get; set; } = "через 1 год";
        public string InYears { get; set; } = "через {0} лет";
    }
}