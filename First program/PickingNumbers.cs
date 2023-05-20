using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class PickingNumbers
    {
        public static int pickingNumbers(List<int> a)
        {

            //int maxLength = 0;
            //int currentLength = 0;
            //int min = a[0];
            //int max = a[0];

            //for (int i = 1; i < a.Count; i++)
            //{
            //    if (Math.Abs(a[i] - min) <= 1 && Math.Abs(a[i] - max) <= 1)
            //    {
            //        currentLength++;
            //        min = Math.Min(min, a[i]);
            //        max = Math.Max(max, a[i]);
            //    }
            //    else
            //    {
            //        maxLength = Math.Max(maxLength, currentLength);
            //        currentLength = 0;
            //        min = a[i];
            //        max = a[i];
            //    }
            //}

            //int maximum = Math.Max(maxLength, currentLength);
            //Console.WriteLine(maximum.ToString());
            //return maximum;

            //int maxLength = 0;
            //Dictionary<int, int> frequency = new Dictionary<int, int>();

            //foreach (int num in a)
            //{
            //    if (frequency.ContainsKey(num))
            //        frequency[num]++;
            //    else
            //        frequency[num] = 1;

            //    if (frequency.ContainsKey(num - 1))
            //        maxLength = Math.Max(maxLength, frequency[num] + frequency[num - 1]);

            //    if (frequency.ContainsKey(num + 1))
            //        maxLength = Math.Max(maxLength, frequency[num] + frequency[num + 1]);
            //}

            //Console.WriteLine(maxLength.ToString());
            //return maxLength;

            //int maxLength = 0;
            //Dictionary<int, int> frequency = new Dictionary<int, int>();

            //foreach (int num in a)
            //{
            //    if (frequency.ContainsKey(num))
            //        frequency[num]++;
            //    else
            //        frequency[num] = 1;

            //    if (frequency.ContainsKey(num - 1))
            //        maxLength = Math.Max(maxLength, frequency[num] + frequency[num - 1]);

            //    if (frequency.ContainsKey(num + 1))
            //        maxLength = Math.Max(maxLength, frequency[num] + frequency[num + 1]);
            //}

            //return maxLength;

            int maxLength = 0;
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (int num in a)
            {
                if (frequency.ContainsKey(num))
                    frequency[num]++;
                else
                    frequency[num] = 1;
            }

            foreach (var pair in frequency)
            {
                int currentLength = pair.Value;
                if (frequency.ContainsKey(pair.Key - 1))
                    currentLength += frequency[pair.Key - 1];

                maxLength = Math.Max(maxLength, currentLength);

                if (frequency.ContainsKey(pair.Key + 1))
                {
                    currentLength = pair.Value + frequency[pair.Key + 1];
                    maxLength = Math.Max(maxLength, currentLength);
                }
            }

            return maxLength;
        }

    }
}
