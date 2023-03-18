using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class PlusMinus
    {
        public static void plusMinus(List<int> arr)
        {
            int positive = 0;
            int negative= 0;
            int zeros = 0;
            int n = arr.Count;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i]>0)
                {
                    positive++;
                }
                else if (arr[i]<0)
                {
                    negative++;
                }
                else if (arr[i]==0)
                {
                    zeros++;
                }
            }

            double positiveRatio=(double)positive/n;
            double negativeRatio = (double)negative / n;
            double zerosRatio = (double)zeros/ n;

            Console.WriteLine("{0:F6}",positiveRatio);
            Console.WriteLine("{0:F6}", negativeRatio);
            Console.WriteLine("{0:F6}", zerosRatio);

        }

    }
}
