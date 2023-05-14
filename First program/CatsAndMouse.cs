using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class CatsAndMouse
    {
        public static string catAndMouse(int x, int y, int z)
        {
            string val = string.Empty;

            int catADistance = Math.Abs(x - z); // Distance between Cat A and the mouse
            int catBDistance = Math.Abs(y - z); // Distance between Cat B and the mouse

            if (catADistance < catBDistance)
            {
                val = "Cat A";
            }
            else if (catBDistance < catADistance)
            {
                val = "Cat B";
            }
            else
            {
                val = "Mouse C";
            }
            Console.WriteLine(val);
            return val;

        }
    }
}
