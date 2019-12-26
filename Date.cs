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
        // Constructor
        public Date (int y, int m, int d)
        {
            year = y;
            month = m;
            day = d;
        }
        // return month name as string
        public string MonthName()
        {
            string result = string.Empty;
            switch (month)
            {
                case 1:
                    result += "January";
                    break;
                case 2:
                    result += "February";
                    break;
                case 3:
                    result += "March";
                    break;
                case 4:
                    result += "April";
                    break;
                case 5:
                    result += "May";
                    break;
                case 6:
                    result += "June";
                    break;
                case 7:
                    result += "July";
                    break;
                case 8:
                    result += "August";
                    break;
                case 9:
                    result += "September";
                    break;
                case 10:
                    result += "October";
                    break;
                case 11:
                    result += "November";
                    break;
                case 12:
                    result += "December";
                    break;
                default:
                    result += "Error: Month value out of range\n";
                    break;
            }
            result += String.Format(" {0}, {1}", day, year);
            return result;
        }
    }
}
