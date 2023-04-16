using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class DivisibleSumPairs
    {
        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            n = 0;
           // int[] sortarray = new int[ar.Count];
             ar.Sort();
           // sortarray= Array.Sort(ar.ToArray(), (x, y) => y.CompareTo(x));

            
            int sum = 0;

            //for (int i = 0; i < ar.Count; i++)
            //{
            //    sum = ar[i] + ar[i+1];


            //}
            for (int i = ar.Count-1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    sum = ar[i] + ar[j];

                    if (sum % k == 0)
                    {
                        n++;
                    }
                }

            }

            return n;
        }
    }
}
