using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class BetweenTwoSets
    {
        public static int getTotalX(List<int> a, List<int> b)
        {
            int lcm = LCM(a);
            int gcd = GCD(b);
            int count = 0;

            #region Simple Form of Loop
            //int i = lcm;
            //int j = 2;
            //while (i <= gcd)
            //{
            //    if (gcd % i == 0)
            //    {
            //        count++;
            //    }
            //    j++;
            //    i = lcm * j;
            //}

            #endregion

            for (int i = lcm, j = 2; i <= gcd; i = lcm * j, j++)
            {
                if (gcd % i == 0) count++;
            }
            Console.WriteLine(count);
            return count;
        }

        static int LCM(List<int> a)
        {
            int lcm = a[0];
            for (int i = 1; i < a.Count; i++)
            {
                lcm = LCM(lcm, a[i]);
            }
            return lcm;
        }

        static int LCM(int a, int b)
        {
            return a * b / GCD(a, b);
        }
        static int GCD(List<int> a)
        {
            int gcd = a[0];
            for (int i = 1; i < a.Count; i++)
            {
                gcd = GCD(gcd, a[i]);
            }
            return gcd;
        }

        static int GCD(int a, int b)
        {
            if (a == 0) return b;
            return GCD(b % a, a);
        }

    }
}
