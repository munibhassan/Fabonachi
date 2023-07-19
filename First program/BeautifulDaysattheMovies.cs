using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class BeautifulDaysattheMovies
    {
        public static int beautifulDays(int s, int j, int k)
        {
            int reverse = 0;
            int absoluteResult = 0;
            int isBeautiful = 0;

            for (int i=s; i <= j ; i++)
            {
                reverse = ReverseInteger(i);
                absoluteResult= Math.Abs(i - reverse);

                if (absoluteResult % k ==0)
                {
                    isBeautiful++;
                }
            }

            Console.WriteLine(isBeautiful);
            return isBeautiful;
        }

        public static int ReverseInteger(int num)
        {
            // Convert the integer to a string
            string numString = num.ToString();

            // Reverse the characters in the string
            char[] charArray = numString.ToCharArray();
            Array.Reverse(charArray);

            // Convert the reversed string back to an integer
            string reversedString = new string(charArray);
            int reversedNum = Int32.Parse(reversedString);

            return reversedNum;
        }
    }
}
