using System;

namespace Clock
{
    public class Clock
    {
        public int Seconds { get; private set; }

        public int Minutes { get; private set; }

        public int Hours { get; private set; }

        public int Days { get; private set; }

        public int Months { get; private set; }

        public string MonthLabel { get; private set; }

        public void UpdateClock()
        {
            //ints for the time
            int s = DateTime.Now.Second;
            int m = DateTime.Now.Minute;
            int h = DateTime.Now.Hour;
            
            //ints for the day
            int d = DateTime.Now.DayOfYear;

            //math for the time
            int secondOfDay = s + m * 60 + h * 3600;
            Hours = secondOfDay / 4320;
            int secondsAfterHour = secondOfDay - Hours * 4320;
            Minutes = secondsAfterHour / 216;
            Seconds = secondsAfterHour - Minutes * 216;

            Hours++;
            Minutes++;
            Seconds++;

            //Console.WriteLine(Hours);
            //Console.WriteLine(secondsAfterHour);

            //maths for the day :D
            Months = d / 30;
            Days = d - Months * 30 + 1;
            Months++;

            if (d == 365)
            {
                MonthLabel = "January, 1";
            }
            if (Months == 1)
            {
                MonthLabel = $"January, {Days}";
            }
            if (Months == 2)
            {
                MonthLabel = $"Febuary, {Days}";
            }
            if (Months == 3)
            {
                MonthLabel = $"Marchuary, {Days}";
            }
            if (Months == 4)
            {
                MonthLabel = $"Apuary, {Days}";
            }
            if (Months == 5)
            {
                MonthLabel = $"Jmay, {Days}";
            }
            if (Months == 6)
            {
                MonthLabel = $"June, {Days}";
            }
            if (Months == 7)
            {
                MonthLabel = $"July, {Days}";
            }
            if (Months == 8)
            {
                MonthLabel = $"Jaugust, {Days}";
            }
            if (Months == 9)
            {
                MonthLabel = $"September, {Days}";
            }
            if (Months == 10)
            {
                MonthLabel = $"October, {Days}";
            }
            if (Months == 11)
            {
                MonthLabel = $"November, {Days}";
            }
            if (Months == 12)
            {
                MonthLabel = $"December, {Days}";
            }
            if (Months == 13)
            {
                MonthLabel = $"Bonus Weekend, {Days}";
            }
        }
    }
}
