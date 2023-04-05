using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    internal class SortRomanToDecimals
    {
        public static List<string> sortRoman(List<string> names)
        {
            // Sorts a list of names by name and Roman numeral.
            Comparison<string> comparison = (name1, name2) =>
            {
                string[] name1Parts = name1.Split(' ');
                string[] name2Parts = name2.Split(' ');
                int nameComparison = name1Parts[0].CompareTo(name2Parts[0]);
                if (nameComparison != 0)
                {
                    return nameComparison;
                }
                int roman1Value = RomanToDecimal(name1Parts[1]);
                int roman2Value = RomanToDecimal(name2Parts[1]);
                return roman1Value.CompareTo(roman2Value);
            };
            names.Sort(comparison);
            return names;
        }

        static int RomanToDecimal(string roman)
        {
            // Converts a Roman numeral to a decimal value.
            var values = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
        };
            int decimalValue = 0;
            int prevValue = 0;
            for (int i = roman.Length - 1; i >= 0; i--)
            {
                int value = values[roman[i]];
                if (value < prevValue)
                {
                    decimalValue -= value;
                }
                else
                {
                    decimalValue += value;
                }
                prevValue = value;
            }
            return decimalValue;
        }
    }
}
