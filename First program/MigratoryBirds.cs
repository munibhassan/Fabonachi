using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class MigratoryBirds
    {
        public static int migratoryBirds(List<int> arr)
        {
            Dictionary<int, int> birds = new Dictionary<int, int>();
            int pairs = 0;

            foreach (int type in arr)
            {
                if (!birds.ContainsKey(type))
                {
                    birds[type] = 0;
                }

                birds[type]++;

                //if (birds[type] % 2 == 0)
                //{
                //    pairs++;
                //}
            }

            int highestKey = birds.OrderByDescending(x => x.Value).ThenBy(x => x.Key).FirstOrDefault().Key;

            return highestKey;
        }
    }
}
