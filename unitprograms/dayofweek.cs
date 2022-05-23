using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitprograms
{
    internal class dayofweek
    {
        public void calender()
        {
            int a, b, m, d;
            string[] WeekDays = { "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday" };
            Console.WriteLine("Enter a date:");
            int day = int .Parse(Console.ReadLine());
            Console.WriteLine("Enter a month:");
            int month = int .Parse(Console.ReadLine());
            Console.WriteLine("Enter a year:");
            int year = int .Parse(Console.ReadLine());

            a = year - (14 - month) / 12;
            b = a + a / 4 - a / 100 + a / 400;
            m = month + 12 * ((14 - month) / 12) - 2;
            d = (day + b + (31 * m) / 12) % 7;

            Console.WriteLine("It's a " +WeekDays[d]);

        }
            
    }
}
