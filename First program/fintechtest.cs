using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace First_program
{
    public class fintechtest
    {
        public static List<string> checkAlmostEquivalent(List<string> s, List<string> t)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < s.Count; i++)
            {
                int[] sFreq = new int[26];
                int[] tFreq = new int[26];

                // Count the occurrences of each letter in s[i]
                foreach (char c in s[i])
                {
                    sFreq[c - 'a']++;
                }

                // Count the occurrences of each letter in t[i]
                foreach (char c in t[i])
                {
                    tFreq[c - 'a']++;
                }

                // Check if the occurrences of each letter differ by no more than 3
                bool isAlmostEquivalent = true;
                for (int j = 0; j < 26; j++)
                {
                    if (Math.Abs(sFreq[j] - tFreq[j]) > 3)
                    {
                        isAlmostEquivalent = false;
                        break;
                    }
                }

                // Add 'Yes' or 'No' to the result list
                result.Add(isAlmostEquivalent ? "Yes" : "No");
            }
            Console.WriteLine(result);
            return result;
        }

        public static int entryTime(string s, string keypad)
        {
            Dictionary<char, Tuple<int, int>> keypadMap = new Dictionary<char, Tuple<int, int>>();
            for (int i = 0; i < keypad.Length; i++)
            {
                int row = i / 3;
                int col = i % 3;
                keypadMap[keypad[i]] = Tuple.Create(row, col);
            }

            int totalTime = 0;
            int currentRow = 0;
            int currentCol = 0;


            int repeat = 0;
            char lastValue = '\0';
            foreach (char digit in s)
            {

                Tuple<int, int> digitCoords = keypadMap[digit];
                int targetRow = digitCoords.Item1;
                int targetCol = digitCoords.Item2;

                int rowMoves = Math.Abs(targetRow - currentRow);
                int colMoves = Math.Abs(targetCol - currentCol);

                int moves = Math.Min(rowMoves, colMoves) + Math.Abs(rowMoves - colMoves);

                if (repeat == 0 || lastValue == digit)
                {
                    moves = 0;
                    repeat = 1;
                }

                currentRow = targetRow;
                currentCol = targetCol;

                totalTime += moves;
            }

            return totalTime;
        }




        public static async Task<string> GetMovieData(string substr)
        {
            string apiUrl = $"https://jsonmock.hackerrank.com/api/moviesdata/search/?Title={substr}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    return result;
                }
                else
                {
                    throw new Exception($"Failed to retrieve movie data. Status code: {response.StatusCode}");
                }
            }
        }





    }
}
