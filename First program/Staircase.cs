using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class Staircase
    {
        public static void staircase(int n)
        {
            int four = n-1;
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < four; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                four--;
            }
        }

    }
}
