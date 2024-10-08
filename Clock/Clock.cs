﻿using System;

namespace Clock
{
    public class Clock
    {
        public int Seconds { get; private set; }

        public int Minutes { get; private set; }

        public int Hours { get; private set; }

        public int Days { get; private set; }

        public int Months { get; private set; }

        public string MonthLabel => _labels[Months];

        private string[] _labels = {
            "",
            $"January",
            $"February",
            $"Marchuary",
            $"Apuary",
            $"Jmay",
            $"June",
            $"July",
            $"Jaugust",
            $"September",
            $"October",
            $"November",
            $"December",
            $"Bonus Weekend"
        };

        public void UpdateClock()
        {
            //ints for the time
            int s = DateTime.UtcNow.Second;
            int m = DateTime.UtcNow.Minute;
            int h = DateTime.UtcNow.Hour;

            //ints for the day
            int d = DateTime.UtcNow.DayOfYear;

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
        }
    }
}
