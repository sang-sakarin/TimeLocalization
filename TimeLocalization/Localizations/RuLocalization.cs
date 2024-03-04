namespace TimeLocalization.Localizations
{
    public class RuLocalization : ILocalization
    {
        public string SecondAgo { get; set; } = "������ ���";
        public string SecondsAgo { get; set; } = "{0} ������ �����";
        public string MinuteAgo { get; set; } = "1 ������ �����";
        public string MinutesAgo { get; set; } = "{0} ����� �����";
        public string HourAgo { get; set; } = "1 ��� �����";
        public string HoursAgo { get; set; } = "{0} ����� �����";
        public string DayAgo { get; set; } = "1 ���� �����";
        public string DaysAgo { get; set; } = "{0} ���� �����";
        public string WeekAgo { get; set; } = "1 ������ �����";
        public string WeeksAgo { get; set; } = "{0} ������ �����";
        public string MonthAgo { get; set; } = "1 ����� �����";
        public string MonthsAgo { get; set; } = "{0} ������� �����";
        public string YearAgo { get; set; } = "1 ��� �����";
        public string YearsAgo { get; set; } = "{0} ��� �����";
        public string InSecond { get; set; } = "�����";
        public string InSeconds { get; set; } = "����� {0} ������";
        public string InMinute { get; set; } = "����� 1 ������";
        public string InMinutes { get; set; } = "����� {0} �����";
        public string InHour { get; set; } = "����� 1 ���";
        public string InHours { get; set; } = "����� {0} �����";
        public string InDay { get; set; } = "����� 1 ����";
        public string InDays { get; set; } = "����� {0} ����";
        public string InWeek { get; set; } = "����� 1 ������";
        public string InWeeks { get; set; } = "����� {0} ������";
        public string InMonth { get; set; } = "����� 1 �����";
        public string InMonths { get; set; } = "����� {0} �������";
        public string InYear { get; set; } = "����� 1 ���";
        public string InYears { get; set; } = "����� {0} ���";
    }
}