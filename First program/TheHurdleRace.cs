using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class TheHurdleRace
    {
        public static int hurdleRace(int k, List<int> height)
        {
            int maxheight = 0;
            maxheight = height.Max();

            if (k >= maxheight)
            {
                return 0;
            }
            else
            {
                return maxheight - k;
            }

           // return 0;
        }
    }
}
