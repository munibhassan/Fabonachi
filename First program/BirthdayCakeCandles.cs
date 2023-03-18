using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class BirthdayCakeCandles
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            int birthdayCakeCandles = 0;
            Dictionary<int, int> max = new Dictionary<int, int>();
            foreach (var item in candles)
            {
                if (!max.ContainsKey(item))
                {
                    max[item] = 0;
                }

                max[item]++;
            }
            birthdayCakeCandles= max.Values.Max();
            return birthdayCakeCandles;
        }
    }
}
