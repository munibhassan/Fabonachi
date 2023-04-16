using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class BillDivision
    {
        public static void bonAppetit(List<int> bill, int k, int b)
        {

            bill.RemoveAt(k);
            int sum = 0;

            foreach (int i in bill)
            {
                sum += i;
            }
            if (sum / 2 == b)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(b - (sum/2));
            }
        }
    }
}
