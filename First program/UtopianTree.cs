using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class UtopianTree
    {
        public static int utopianTree(int n)
        {
            //for (int period = 0; period < n; period++)
            //{
            //    //if (period % 2 == 0)
            //    //{
            //    //    int height= period / 2 + 1;
            //    //    Console.WriteLine("Period {0}: Height = {1}", period, height);
            //    //}
            //    //else
            //    //{
            //    //    int height= (int)Math.Pow(2, period / 2);
            //    //    Console.WriteLine("Period {0}: Height = {1}", period, height);
            //    //}

            //    if (period % 2 == 0)
            //    {
            //        int height = (int)Math.Pow(2, period / 2) - 1;
            //        Console.WriteLine("Period {0}: Height = {1}", period, height);
            //    }
            //    else
            //    {
            //        int height = (int)Math.Pow(2, (period + 1) / 2) - 2;
            //        Console.WriteLine("Period {0}: Height = {1}", period, height);
            //    }
            //}
            //return 0;
            int height = 1;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    // Double the height in spring
                    height *= 2;
                }
                else
                {
                    // Increase the height by 1 in summer
                    height += 1;
                }
            }
            Console.WriteLine("Height = {0}", height);
            return height;
        }
    }
}
