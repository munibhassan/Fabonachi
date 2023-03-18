using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class TimeConversion
    {
        public static string timeConversion(string s)
        {
            DateTime dateTime = DateTime.ParseExact(s, "hh:mm:sstt", CultureInfo.InvariantCulture);
            string time = dateTime.ToString("HH:mm:ss");
            return time;

        }

    }
}
