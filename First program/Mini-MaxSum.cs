using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class Mini_MaxSum
    {
        public static void miniMaxSum(List<int> arr)
        {
            arr.Sort();

            long minSum = (long)arr[0] + (long)arr[1] + (long)arr[2] + (long)arr[3];
            long maxSum = (long)arr[1] + (long)arr[2] + (long)arr[3] + (long)arr[4];

            Console.WriteLine(minSum + " " + maxSum);
        }

    }
}
