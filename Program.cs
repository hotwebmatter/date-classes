using System;
using static System.Console;

namespace date_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Date myDate = new Date(2019, 12, 26);
            WriteLine(myDate.MonthName());
            WriteLine(myDate.ToString());
        }
    }
}
