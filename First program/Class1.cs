using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class Class1
    {
        public static int sortedSum(List<int> a)
        {
            a.Sort(); // Sort the sequence in non-descending order

            int n = a.Count;
            long sum = 0;
            long mod = (long)(1e9 + 7);

            for (int i = 0; i < n; i++)
            {
                long fi = 0;
                for (int j = 0; j <= i; j++)
                {
                    fi += (j + 1) * a[j];
                    fi %= mod;
                }

                sum += fi;
                sum %= mod;
            }

            Console.WriteLine(sum);
            return (int)sum;
        }

        public static int sortedSum2(List<int> a)
        {
            const int mod = 1000000007; // Modulo value
          //  a.Sort(); // Sort the list in non-descending order

            long sum = 0; // Use a long data type to handle large intermediate values
            long prefixSum = 0; // Initialize the prefix sum

            // Calculate the sorted sum using the prefix sum
            for (int i = 0; i < a.Count; i++)
            {
                prefixSum += a[i];
                sum += (i + 1) * prefixSum;
                sum %= mod; // Apply modulo after each addition to prevent overflow
            }
            Console.WriteLine(sum);

          
            return (int)sum; // Convert the final sum back to int and return

            //foreach (var item in collection)
            //{
            //    Console.WriteLine(item);
            //}
        }


    }
}
