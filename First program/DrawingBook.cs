using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class DrawingBook
    {
       public static int pageCount(int n, int p)
        {
            int fromFront = p / 2; // Number of pages to turn from the front
            int fromBack = (n / 2) - fromFront; // Number of pages to turn from the back
            return Math.Min(fromFront, fromBack); // Return the minimum of the two
        }

    }
}
