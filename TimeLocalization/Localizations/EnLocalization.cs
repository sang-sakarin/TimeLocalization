namespace TimeLocalization.Localizations
{
    public class EnLocalization : ILocalization
    {
        public string SecondAgo { get; set; } = "just now";
        public string SecondsAgo { get; set; } = "{0} seconds ago";
        public string MinuteAgo { get; set; } = "1 minute ago";
        public string MinutesAgo { get; set; } = "{0} minutes ago";
        public string HourAgo { get; set; } = "1 hour ago";
        public string HoursAgo { get; set; } = "{0} hours ago";
        public string DayAgo { get; set; } = "1 day ago";
        public string DaysAgo { get; set; } = "{0} days ago";
        public string WeekAgo { get; set; } = "1 week ago";
        public string WeeksAgo { get; set; } = "{0} weeks ago";
        public string MonthAgo { get; set; } = "1 month ago";
        public string MonthsAgo { get; set; } = "{0} months ago";
        public string YearAgo { get; set; } = "1 year ago";
        public string YearsAgo { get; set; } = "{0} years ago";
        public string InSecond { get; set; } = "a while";
        public string InSeconds { get; set; } = "in {0} seconds";
        public string InMinute { get; set; } = "in 1 minute";
        public string InMinutes { get; set; } = "in {0} minutes";
        public string InHour { get; set; } = "in 1 hour";
        public string InHours { get; set; } = "in {0} hours";
        public string InDay { get; set; } = "in 1 day";
        public string InDays { get; set; } = "in {0} days";
        public string InWeek { get; set; } = "in 1 week";
        public string InWeeks { get; set; } = "in {0} weeks";
        public string InMonth { get; set; } = "in 1 month";
        public string InMonths { get; set; } = "in {0} months";
        public string InYear { get; set; } = "in 1 year";
        public string InYears { get; set; } = "in {0} years";
    }
}