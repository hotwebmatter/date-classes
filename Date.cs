using System;
using System.Collections.Generic;
using System.Text;

namespace date_classes
{
    class Date
    {
        // instance data members
        private int year,
                    month,
                    day;
        private string monthName;
        // properties acting as mutators and accessors
        public int Year
        {
            set
            {
                Year = value;
            }
            get
            {
                return year;
            }
        }
        public int Month
        {
            set
            {
                Month = value;
            }
            get
            {
                return month;
            }
        }
        public int Day
        {
            set
            {
                Day = value;
            }
            get
            {
                return day;
            }
        }
    }
}
