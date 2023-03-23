using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class GradingStudents
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> finalgrades = new List<int>();

            foreach (var item in grades)
            {
                int multipleOfFive = getMultipleOfFiveNo(item);

                if (item < 38)
                {
                    finalgrades.Add(item);
                    Console.WriteLine(item);
                }
                else if (item >= 38 & multipleOfFive - item < 3)
                {
                    finalgrades.Add(multipleOfFive);
                    Console.WriteLine(multipleOfFive);
                }
                else if (item >= 38 & multipleOfFive - item >= 3)
                {
                    finalgrades.Add(item);
                    Console.WriteLine(item);
                }

            }

            return finalgrades;
        }

        public static int getMultipleOfFiveNo(int number)
        {
            int multipleofFive = 0;

            if ((number % 5) == 0)
            {
                multipleofFive = number;
            }
            else
            {
                for (int i = 1; i < 5; i++)
                {
                    if ((number + i) % 5 == 0)
                    {
                        multipleofFive = number + i;
                        break;

                    }
                }
            }

            return multipleofFive;
        }
    }
}
