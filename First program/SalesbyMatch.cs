using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class SalesbyMatch
    {
        public static int sockMerchant(int n, List<int> ar)
        {
            //int match = 0;

            //List<int> uniqueIntegers = ar.Distinct().ToList();


            //foreach (var item in ar)
            //{

            //}


            //return match;


           // List<int> ar1 = new List<int> { 1, 2, 3, 4, 5,4,6,3,3,8 };
           // ar = ar1;
            Dictionary<int, int> colors = new Dictionary<int, int>();
            int pairs = 0;

            foreach (int sock in ar)
            {
                if (!colors.ContainsKey(sock))
                {
                    colors[sock] = 0;
                }

                colors[sock]++;

                if (colors[sock] % 2 == 0)
                {
                    pairs++;
                }
            }

            return pairs;


        }

    }
}
