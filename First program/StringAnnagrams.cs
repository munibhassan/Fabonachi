using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class StringAnnagrams
    {
        public static List<int> stringAnagram(List<string> dictionary, List<string> query)
        {
            List<int> result = new List<int>();

            foreach (string q in query)
            {
                int count = 0;

                foreach (string d in dictionary)
                {
                    if (q.Length == d.Length)
                    {
                        int[] freq = new int[26];

                        for (int i = 0; i < d.Length; i++)
                        {
                            freq[d[i] - 'a']++;
                            freq[q[i] - 'a']--;
                        }

                        bool isAnagram = true;

                        for (int i = 0; i < 26; i++)
                        {
                            if (freq[i] != 0)
                            {
                                isAnagram = false;
                                break;
                            }
                        }

                        if (isAnagram)
                        {
                            count++;
                        }
                    }
                }

                result.Add(count);
            }

            return result;
        }


        public static List<int> stringAnagramopt(List<string> dictionary, List<string> query)
        {
            // Create a dictionary to store the frequency of characters in each string in the dictionary list
            Dictionary<string, Dictionary<char, int>> dictFreq = new Dictionary<string, Dictionary<char, int>>();
            foreach (string word in dictionary)
            {
                Dictionary<char, int> charFreq = new Dictionary<char, int>();
                foreach (char c in word)
                {
                    if (charFreq.ContainsKey(c))
                        charFreq[c]++;
                    else
                        charFreq[c] = 1;
                }
                dictFreq[word] = charFreq;
            }

            // Create a list to store the number of anagrams for each query string
            List<int> result = new List<int>();
            foreach (string q in query)
            {
                // Calculate the frequency of characters in the query string
                Dictionary<char, int> queryFreq = new Dictionary<char, int>();
                foreach (char c in q)
                {
                    if (queryFreq.ContainsKey(c))
                        queryFreq[c]++;
                    else
                        queryFreq[c] = 1;
                }

                // Compare the frequency of characters in the query string with the frequency of characters in each string in the dictionary list
                int count = 0;
                foreach (KeyValuePair<string, Dictionary<char, int>> entry in dictFreq)
                {
                    if (entry.Value.Count != queryFreq.Count) continue;
                    bool isAnagram = true;
                    foreach (KeyValuePair<char, int> kvp in entry.Value)
                    {
                        if (!queryFreq.ContainsKey(kvp.Key) || queryFreq[kvp.Key] != kvp.Value)
                        {
                            isAnagram = false;
                            break;
                        }
                    }
                    if (isAnagram) count++;
                }
                result.Add(count);
            }

            return result;
        }

    }
}
