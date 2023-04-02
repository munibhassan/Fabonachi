using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class BasicProblemSolving
    {
        public static string findSubstring(string s, int k)

        {

            //int maxVowelsCount = 0;
            //int currentVowelsCount = 0;
            //string maxVowelsSubstring = "";
            //int i = 0;

            //// Count the vowels in the first substring
            //for (int j = 0; j < k; j++)
            //{
            //    if (IsVowel(s[j]))
            //    {
            //        currentVowelsCount++;
            //    }
            //}

            //// Slide the window and count the vowels in each substring
            //while (i + k <= s.Length)
            //{
            //    if (currentVowelsCount > maxVowelsCount)
            //    {
            //        maxVowelsCount = currentVowelsCount;
            //        maxVowelsSubstring = s.Substring(i, k);
            //    }

            //    // Move the window one character to the right
            //    if (i + k < s.Length && IsVowel(s[i]))
            //    {
            //        currentVowelsCount--;
            //    }
            //    if (IsVowel(s[i + k]))
            //    {
            //        currentVowelsCount++;
            //    }
            //    i++;
            //}

            //return maxVowelsSubstring;


            #region

            //char [] chars = s.ToCharArray();
            //int maxLen = 0;
            //int curLen = 0;
            //foreach (var item in chars)
            //{
            //    if (item =='a'|| item == 'e' || item == 'i' || item == 'o' || item == 'u' )
            //    {
            //        curLen++;
            //        if (i > 0 && IsVowel(s[i - 1]))
            //        {
            //            if (curLen > maxLen)
            //            {
            //                maxLen = curLen;
            //                maxSubstr = s.Substring(i - curLen + 1, curLen);
            //            }
            //        }
            //    }
            //    else
            //    {
            //        curLen = 0;
            //    }
            //}
            //}

            //return s.Substring(k);

            //int maxLen = 0;
            //int curLen = 0;
            //string maxSubstr = "";

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (IsVowel(s[i]))
            //    {
            //        curLen++;
            //        if (i > 0 && IsVowel(s[i - 1]))
            //        {
            //            if (curLen > maxLen)
            //            {
            //                maxLen = curLen;
            //                maxSubstr = s.Substring(i - curLen + 1, curLen);
            //            }
            //        }
            //    }
            //    else
            //    {
            //        curLen = 0;
            //    }
            //}

            //return maxSubstr;

            // string str = "caberqiitefg";
            //string str = s;
            //int maxLength = 0;
            //string maxSubstring = "";

            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (IsVowel(str[i]))
            //    {
            //        for (int j = str.Length - 1; j > i; j--)
            //        {
            //            if (IsVowel(str[j]))
            //            {
            //                string substring = str.Substring(i, j - i + 1);
            //                if (substring.Length > maxLength)
            //                {
            //                    maxLength = substring.Length;
            //                    maxSubstring = substring;
            //                }
            //                break;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine("Longest substring that starts and ends with vowels: " + maxSubstring);
            //Console.WriteLine("Length of longest substring: " + maxLength);
            //return maxSubstring;

            // string s = "caberqiitefg";
            //int maxLength = 0;
            //string maxSubstring = "";

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (IsVowel(s[i]))
            //    {
            //        for (int j = s.Length - 1; j > i; j--)
            //        {
            //            if (IsVowel(s[j]))
            //            {
            //                string substring = s.Substring(i, j - i + 1);
            //                if (substring.Length > maxLength)
            //                {
            //                    maxLength = substring.Length;
            //                    maxSubstring = substring;
            //                }
            //                break;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine("Longest substring that starts and ends with vowels: " + maxSubstring + ", length: " + maxLength);
            //return maxSubstring;


            //int maxVowelsCount = 0;
            //string maxVowelsSubstring = "";

            //for (int i = 0; i <= s.Length - k; i++)
            //{
            //    string substring = s.Substring(i, k);
            //    int vowelsCount = substring.Count(c => "aeiou".Contains(c));

            //    if (vowelsCount > maxVowelsCount)
            //    {
            //        maxVowelsCount = vowelsCount;
            //        maxVowelsSubstring = substring;
            //    }
            //}

            //return maxVowelsSubstring;

            //int maxVowelsCount = 0;
            //string maxVowelsSubstring = "";

            //for (int i = 0; i <= s.Length - k; i++)
            //{
            //    int vowelsCount = 0;

            //    for (int j = i; j < i + k; j++)
            //    {
            //        char c = s[j];
            //        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            //        {
            //            vowelsCount++;
            //        }
            //    }

            //    if (vowelsCount > maxVowelsCount)
            //    {
            //        maxVowelsCount = vowelsCount;
            //        maxVowelsSubstring = s.Substring(i, k);
            //    }
            //}

            //return maxVowelsSubstring;
            #endregion
            int maxVowelsCount = 0;
            string maxVowelsSubstring = "";

            for (int i = 0; i <= s.Length - k; i++)
            {
                int vowelsCount = 0;

                for (int j = i; j < i + k; j++)
                {
                    char c = s[j];
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        vowelsCount++;
                    }
                }

                if (vowelsCount > maxVowelsCount)
                {
                    maxVowelsCount = vowelsCount;
                    maxVowelsSubstring = s.Substring(i, k);
                }
            }

            return maxVowelsSubstring;

        }

    //    static bool IsVowel(char c)
    //{
    //    return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    //}

    //static bool IsVowel(char c)
    //    {
    //        return "aeiou".IndexOf(c) != -1;
       // }
        //private static bool IsVowel(char c)
        //{
        //    c = Char.ToLower(c);
        //    return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        //}
    }
}
