using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class CountingValleys
    {
        public static int countingValleys(int steps, string path)
        {
            List<char> charList = path.ToList();
            steps = 0;
            int downvalley = 0;
            int pair = 0;


            foreach (char c in charList)
            {
                if (c == 'U')
                {
                    steps++;
                    if (steps == 0)
                    {
                        downvalley++;
                        if (downvalley % 2 == 0)
                        {
                            pair++;
                        }
                    }
                }
                else if (c == 'D')
                {
                  
                    if (steps == 0)
                    {
                        downvalley++;
                        //if (downvalley % 2 == 0)
                        //{

                        //}
                    }
                    steps--;
                }
            }

            Console.WriteLine(pair);
            return pair;
        }

    }
}
