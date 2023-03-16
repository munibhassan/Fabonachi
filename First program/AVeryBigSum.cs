using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class AVeryBigSum
    {
        public static long aVeryBigSumFunc(List<long> ar)
        {
            long sum = 0;
            foreach (int num in ar)
            {
                sum += num;
            }
            return sum;
        }

    }
}
