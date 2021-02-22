namespace TimeLocalization.Localizations
{
    public class EsLocalization : ILocalization
    {
        public string SecondAgo { get; set; } = "justo ahora";
        public string SecondsAgo { get; set; } = "hace {0} segundos";
        public string MinuteAgo { get; set; } = "hace 1 minuto";
        public string MinutesAgo { get; set; } = "hace {0} minuto";
        public string HourAgo { get; set; } = "hace 1 hora";
        public string HoursAgo { get; set; } = "hace {0} horas";
        public string DayAgo { get; set; } = "hace 1 día";
        public string DaysAgo { get; set; } = "hace {0} días";
        public string WeekAgo { get; set; } = "hace 1 semana";
        public string WeeksAgo { get; set; } = "hace {0} semanas";
        public string MonthAgo { get; set; } = "hace 1 mes";
        public string MonthsAgo { get; set; } = "hace {0} meses";
        public string YearAgo { get; set; } = "hace 1 año";
        public string YearsAgo { get; set; } = "hace {0} años";
        public string InSecond { get; set; } = "en un rato";
        public string InSeconds { get; set; } = "en {0} segundos";
        public string InMinute { get; set; } = "en 1 minuto";
        public string InMinutes { get; set; } = "en {0} minutos";
        public string InHour { get; set; } = "en 1 hora";
        public string InHours { get; set; } = "en {0} horas";
        public string InDay { get; set; } = "en 1 día";
        public string InDays { get; set; } = "en {0} días";
        public string InWeek { get; set; } = "en 1 semana";
        public string InWeeks { get; set; } = "en {0} semanas";
        public string InMonth { get; set; } = "en 1 mes";
        public string InMonths { get; set; } = "en {0} meses";
        public string InYear { get; set; } = "en 1 año";
        public string InYears { get; set; } = "en {0} años";
    }
}