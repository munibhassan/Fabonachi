using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class TripletCompare
    {
        //Alice and Bob each created one problem for HackerRank. A reviewer rates the two challenges,
        //awarding points on a scale from 1 to 100 for three categories: problem clarity, originality,
        //and difficulty.

        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int alice = 0; int bob = 0;
            List<int> result = new List<int>(2);
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    alice += 1;
                }
                else if (a[i] < b[i])
                {
                    bob += 1;
                }
            }

            result.Add(alice);
            result.Add(bob);
            return result;
        }
    }
}
