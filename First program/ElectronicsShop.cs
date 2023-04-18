using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class ElectronicsShop
    {
       public static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {

            // int highestMoneySpent = 0;
            //// List<int> ListOfMoneySpent = new List<int>() { };


            // for (int i = 0; i < keyboards.Length; i++)
            // {
            //     for (int j = 0; j < drives.Length; j++)
            //     {
            //         if (keyboards[i] >= b || drives[j] >= b)
            //         {
            //             highestMoneySpent = -1;
            //             break;
            //         }
            //         else if (keyboards[i] + drives[j] <= b)
            //         {
            //             highestMoneySpent= keyboards[i] + drives[j];
            //             if (highestMoneySpent< keyboards[i] + drives[j])
            //             {
            //                 highestMoneySpent = keyboards[i] + drives[j];
            //             }
            //            // ListOfMoneySpent.Add(highestMoneySpent);
            //         }
            //     }

            // }
            // Console.WriteLine(highestMoneySpent.ToString());
            // return highestMoneySpent;
            int maxTotal = -1;
            foreach (int keyboard in keyboards)
            {
                foreach (int drive in drives)
                {
                    int total = keyboard + drive;
                    if (total <= b && total > maxTotal)
                    {
                        maxTotal = total;
                    }
                }
            }
            return maxTotal;
        }
    }
}
