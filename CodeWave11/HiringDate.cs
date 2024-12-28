using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWave11
{
    internal class HiringDate
    {
        // fields
        private int _day;
        private int _month;
        private int _year;

        // full properties
        public int Day
        {
            get { return _day; }
            set
            {
                if (value < 1 || value > 31)
                    throw new ArgumentOutOfRangeException(nameof(value), "Day must be between 1 and 31.");
                _day = value;
            }
        }

        public int Month
        {
            get { return _month; }
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentOutOfRangeException(nameof(value), "Month must be between 1 and 12.");
                _month = value;
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException(nameof(value), "Year must be a positive value.");
                _year = value;
            }
        }

        public HiringDate(int day, int month, int year)
        {
            Month = month;
            Day = day;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }

    }
}
