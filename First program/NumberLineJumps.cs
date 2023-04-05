using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class NumberLineJumps
    {
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            // Check if the kangaroos start with the same position and speed
            if (x1 == x2 && v1 == v2)
            {
                return "YES";
            }
            // Check if the kangaroos start with the same position but different speeds
            if (x1 == x2)
            {
                return "NO";
            }
            // Calculate the number of jumps required to meet

            if (v1 - v2 != 0)
            {
                int jumps = (x2 - x1) / (v1 - v2);


                if (jumps >= 0 && x1 + jumps * v1 == x2 + jumps * v2)
                {
                    return "YES";
                }
            }

            return "NO";
        }

    }
}
