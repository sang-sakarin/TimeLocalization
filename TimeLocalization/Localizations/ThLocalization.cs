namespace TimeLocalization.Localizations
{
    public class ThLocalization : ILocalization
    {
        public string SecondAgo { get; set; } = "เมื่อสักครู่";
        public string SecondsAgo { get; set; } = "{0} วินาทีที่แล้ว";
        public string MinuteAgo { get; set; } = "1 นาทีที่แล้ว";
        public string MinutesAgo { get; set; } = "{0} นาทีที่แล้ว";
        public string HourAgo { get; set; } = "1 ชั่วโมงที่แล้ว";
        public string HoursAgo { get; set; } = "{0} ชั่วโมงที่แล้ว";
        public string DayAgo { get; set; } = "1 วันที่แล้ว";
        public string DaysAgo { get; set; } = "{0} วันที่แล้ว";
        public string WeekAgo { get; set; } = "1 อาทิตย์ที่แล้ว";
        public string WeeksAgo { get; set; } = "{0} อาทิตย์ที่แล้ว";
        public string MonthAgo { get; set; } = "1 เดือนที่แล้ว";
        public string MonthsAgo { get; set; } = "{0} เดือนที่แล้ว";
        public string YearAgo { get; set; } = "1 ปีที่แล้ว";
        public string YearsAgo { get; set; } = "{0} ปีที่แล้ว";
        public string InSecond { get; set; } = "อีกสักครู่";
        public string InSeconds { get; set; } = "ใน {0} วินาที";
        public string InMinute { get; set; } = "ใน 1 นาที";
        public string InMinutes { get; set; } = "ใน {0} นาที";
        public string InHour { get; set; } = "ใน 1 ชั่วโมง";
        public string InHours { get; set; } = "ใน {0} ชั่วโมง";
        public string InDay { get; set; } = "ใน 1 วัน";
        public string InDays { get; set; } = "ใน {0} วัน";
        public string InWeek { get; set; } = "ใน 1 อาทิตย์";
        public string InWeeks { get; set; } = "ใน {0} อาทิตย์";
        public string InMonth { get; set; } = "ใน 1 เดือน";
        public string InMonths { get; set; } = "ใน {0} เดือน";
        public string InYear { get; set; } = "ใน 1 ปี";
        public string InYears { get; set; } = "ใน {0} ปี";
    }
}