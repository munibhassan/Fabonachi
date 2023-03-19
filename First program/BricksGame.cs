using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    internal class BricksGame
    {
        public static long bricksGame(List<int> arr)
        {
            #region PracticeCode
            //int n = arr.Count;
            //int[] dp = new int[n + 4];

            //for (int i = n - 1; i >= 0; i--)
            //{
            //    dp[i] = arr[i] + Math.Min(Math.Min(dp[i + 1], dp[i + 2]), dp[i + 3]);
            //}

            //return dp[0];

            //{ 0, 1, 1, 1, 999 }

            // int n = arr.Count;

            //if (n <= 3)
            //{
            //    return arr.Sum();
            //}

            //int[] dp = new int[n + 1];

            //dp[1] = arr[n - 1];
            //dp[2] = arr[n - 1] + arr[n - 2];
            //dp[3] = arr[n - 1] + arr[n - 2] + arr[n - 3];

            //for (int i = 4; i <= n; i++)
            //{
            //    int choice1 = arr[n - i] + arr[n - i + 1] + arr[n - i + 2] + arr[n - i + 3] - dp[i - 1];
            //    int choice2 = arr[n - i] + arr[n - i + 1] + arr[n - i + 2] + arr[n - i + 3]  - dp[i - 2];
            //   // int choice3 = arr[n - i] + arr[n - i + 1] + arr[n - i + 2] + arr[n - i + 3] + arr[n - i + 4]  - dp[i - 3];

            //    dp[i] = Math.Max(choice1, choice2);
            //}

            //return dp[n];

            // { 999, 1, 1, 1, 0 }

            //int n = arr.Count;
            //int[] s = new int[n + 1];
            //for (int i = 1; i <= n; i++)
            //{
            //    s[i] = s[i - 1] + arr[i - 1];
            //}

            //int[] f = new int[n + 1];
            //for (int i = 1; i <= n; i++)
            //{
            //    if (i == 1) f[i] = arr[i - 1];
            //    else if (i == 2) f[i] = arr[i - 1] + arr[i - 2];
            //    else if (i == 3) f[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];
            //    else
            //    {
            //        f[i] = s[i] - Math.Min(Math.Min(f[i - 1], f[i - 2]), f[i - 3]);
            //    }
            //}
            //Console.WriteLine(f[n]);
            //return f[n];
            #endregion

            // { 999, 1, 1, 1, 0 }

            // { 0, 1, 1, 1, 999} Rev
            List<long> revArr = arr.Select(i => (long)i).ToList();
            revArr.Reverse();
            List<long> process = new List<long>();
            List<long> sumArr = new List<long>();




            for (int i = 0; i < arr.Count; i++)
            {
                process.Add(0);
                sumArr.Add(0);
            }
            for (int i = 0; i < revArr.Count; i++)
            {
                if (i == 0)
                {
                    sumArr[0] = revArr[i];
                }
                else
                {
                    sumArr[i] = sumArr[i - 1] + revArr[i];
                }

                if (i < 3)
                {
                    process[i] = revArr.GetRange(0, i + 1).Sum();
                    Console.WriteLine(process[i]);
                }
                else
                {
                    long case1 = revArr[i] + (sumArr[i - 1] - process[i - 1]);
                    long case2 = revArr.GetRange(i - 1, 2).Sum() + (sumArr[i - 2] - process[i - 2]);
                    long case3 = revArr.GetRange(i - 2, 3).Sum() + (sumArr[i - 3] - process[i - 3]);

                    process[i] = Math.Max(case1, Math.Max(case2, case3));
                }
            }
            return process[process.Count - 1];
        }
    }
}
