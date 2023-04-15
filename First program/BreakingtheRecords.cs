using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class BreakingtheRecords
    {
        public static List<int> breakingRecords(List<int> scores)
        {
            List<int> MaxAndMix = new List<int>() { 0,0};

            Dictionary<string, int> record = new Dictionary<string, int>();
            int MaxRecord = 0;
            int MinRecord = 0;

            record["Max"] = scores[0];
            record["Min"] = scores[0];
            foreach (int score in scores)
            {

                if (score > record["Max"])
                {
                    record["Max"] = score;
                    MaxRecord++;
                }
                else if (score < record["Min"])
                {
                    record["Min"] = score;
                    MinRecord++;
                }

            }
            MaxAndMix[0] = MaxRecord;
            MaxAndMix[1] = MinRecord;
            return MaxAndMix;
        }
    }
}
