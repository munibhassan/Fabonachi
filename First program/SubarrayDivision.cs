using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class SubarrayDivision
    {
        public static int birthday(List<int> s, int d, int m)
        {
            int count = 0;
            int n = s.Count;

            // If m is greater than n, there is no way to form the segment
            if (m > n)
            {
                return count;
            }

            int sum = 0;
            // Find the sum of the first m squares
            for (int i = 0; i < m; i++)
            {
                sum += s[i];
            }

            // Check if the sum equals d, increment count if it does
            if (sum == d)
            {
                count++;
            }

           // { 1, 2, 1, 3, 2 }
            // Check the remaining segments of length m
            for (int i = m; i < n; i++)
            {
                Console.WriteLine(s[i]+ "-"+ s[i - m]);
                sum += s[i] - s[i - m];
                if (sum == d)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
