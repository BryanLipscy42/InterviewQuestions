using System;

namespace InterviewQuestions
{
    public class DateTimeEx
    {
        public DateTimeEx() { }

        public DateTimeEx(int year, int month, int day)
        {
            this.Month = month;
            this.Year = year;
            this.Day = day;
        }

        public DateTimeEx(int year, Months month, int day)
        {
            this.Year = year;
            this.Month = (int)month;
            this.Day = day;
        }

        public int Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }

        public DaysOfWeek DayOfWeek
        {
            get
            {
            https://en.wikipedia.org/wiki/Determination_of_the_day_of_the_week
                int[] shiftedMonth = new int[] { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
                var year = this.Year;
                year -= (this.Month < 3) ? 1 : 0;
                var w = (year + year / 4 - year / 100 + year / 400 + shiftedMonth[this.Month - 1] + this.Day) % 7;

                return (DaysOfWeek)w;
            }
        }

        public int DayOfYear
        {
            get
            {
                ushort[] days = { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334 };

                if (this.IsLeapYear && this.Month >= 2)
                {
                    return days[this.Month - 1] + this.Day + 1;
                }

                return days[this.Month - 1] + this.Day;
            }
        }

        public bool IsLeapYear
        {
            get
            {
                return (this.Year % 4 == 0 && (this.Year % 100 != 0 || this.Year % 400 == 0));
            }
        }

        public int ToJulianDate()
        {
            var year = this.Year.ToString("D4");
            var calYear = year.Substring(2, 2);
            return Convert.ToInt32($"{calYear}{this.DayOfYear}");
        }

        public override string ToString()
        {
            return $"{this.Month}/{this.Day}/{this.Year}";
        }

        public string DayOfWeekCheck()
        {
            var dt = new DateTime(this.Year, this.Month, this.Day);
            return dt.DayOfWeek.ToString();
        }

        public int DayOfYearCheck
        {
            get
            {
                var dt = new DateTime(this.Year, this.Month, this.Day);
                return dt.DayOfYear;
            }
        }
    }

    public enum Months : int
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }

    public enum DaysOfWeek : int
    {
        Sunday = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
    }

}
