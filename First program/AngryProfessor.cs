using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class AngryProfessor
    {
        public static string angryProfessor(int k, List<int> a)
        {
            int frequency = 0;
            string returnVar = "";
            foreach (int i in a)
            {
                if (i <= 0)
                {
                    frequency++;
                }
                //else
                //{
                //    frequency--;
                //}

            }
            if (frequency < k)
            {
                returnVar = "Yes";
            }
            else
            {
                returnVar = "No";
            }

            Console.WriteLine(returnVar);
            return returnVar;
        }
    }
}
