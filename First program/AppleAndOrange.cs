using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class AppleAndOrange
    {
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            apples = distance(a, apples);
            oranges = distance(b, oranges);
            range(s, t, apples);
            range(s, t, oranges);

        }

        public static List<int> distance(int point, List<int> items)
        {
            // int count = 0;
            List<int> distanceList = new List<int>() { };
            foreach (var item in items)
            {
                int distance = point + item;
                distanceList.Add(distance);
            }
            return distanceList;
        }

        public static void range(int minVal, int maxVal, List<int> items)
        {
            int count = 0;
            List<int> distanceList = new List<int>() { };
            foreach (var item in items)
            {
                if (item >= minVal && item <= maxVal)
                {
                    count++;

                }
              
            }
            Console.WriteLine(count);
        }


    }
}
