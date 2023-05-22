using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace First_program
{
    public class DesignerPDFViewer
    {
        public static int designerPdfViewer(List<int> h, string word)
        {
            int max = 0;int indexValue = 0;
            Dictionary<char, int> alphabetDictionary = new Dictionary<char, int>();
            // Add lowercase alphabets
            for (int i = 0; i < 26; i++)
            {
                char lowercaseLetter = (char)('a' + i);
                alphabetDictionary.Add(lowercaseLetter, h[i]);
            }

            foreach (char c in word)
            {
                Console.WriteLine(c);
                indexValue = alphabetDictionary[c];
                if (max<indexValue)
                {
                    max = indexValue;
                }
            }
            //int indexa = alphabetDictionary['a'];
           // Console.WriteLine("MaxValue " + max); // Output: 27

            int countWord = word.Length;
            Console.WriteLine("MaxValue " + max * countWord);
            return max * countWord;

          //  return 0;
        }
    }
}
