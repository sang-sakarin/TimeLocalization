namespace TimeLocalization.Localizations
{
    public class JaLocalization : ILocalization
    {
        public string SecondAgo { get; set; } = "たった今";
        public string SecondsAgo { get; set; } = "{0}秒前";
        public string MinuteAgo { get; set; } = "1分前";
        public string MinutesAgo { get; set; } = "{0}分前";
        public string HourAgo { get; set; } = "1時間前";
        public string HoursAgo { get; set; } = "{0}時間前";
        public string DayAgo { get; set; } = "昨日";
        public string DaysAgo { get; set; } = "{0}日前";
        public string WeekAgo { get; set; } = "先週";
        public string WeeksAgo { get; set; } = "{0}週間前";
        public string MonthAgo { get; set; } = "1ヶ月前";
        public string MonthsAgo { get; set; } = "{0}ヶ月前";
        public string YearAgo { get; set; } = "1年前";
        public string YearsAgo { get; set; } = "{0}年前";
        public string InSecond { get; set; } = "すぐに";
        public string InSeconds { get; set; } = "{0}秒以内";
        public string InMinute { get; set; } = "1分以内";
        public string InMinutes { get; set; } = "{0}分以内";
        public string InHour { get; set; } = "1時間以内";
        public string InHours { get; set; } = "{0}時間以内";
        public string InDay { get; set; } = "1日以内";
        public string InDays { get; set; } = "{0}日以内";
        public string InWeek { get; set; } = "1週間以内";
        public string InWeeks { get; set; } = "{0}週間以内";
        public string InMonth { get; set; } = "1ヶ月以内";
        public string InMonths { get; set; } = "{0}ヶ月以内";
        public string InYear { get; set; } = "1年以内";
        public string InYears { get; set; } = "{0}年以内";
    }
}