using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class DayoftheProgrammer
    {
        public static string dayOfProgrammer(int year)
        {
            string date = "";
            int day = 256;
            int[] daysInMonths = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // check if it's a leap year
            bool isLeapYear = (year % 4 == 0 && year < 1918) || (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0) && year > 1918);

            // adjust days in February for leap year
            if (isLeapYear && year != 1918) daysInMonths[1] = 29;
            else if (year == 1918) daysInMonths[1] = 15 - 29 - 31;

            // find the month and day of the programmer
            int month = 1;
            while (day > daysInMonths[month - 1])
            {
                day -= daysInMonths[month - 1];
                month++;
            }

            // format the date
            date = String.Format("{0:00}.{1:00}.{2:0000}", day, month, year);

            return date;
        }

    }
}
