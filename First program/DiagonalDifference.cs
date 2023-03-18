using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class DiagonalDifference
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            //int difference = 0;
            // List<List<int>> arr1 = new List<List<int>>();

            // populate arr with some values
            arr.Add(new List<int>() { 1, 2, 3 });
            arr.Add(new List<int>() { 4, 5, 6 });
            arr.Add(new List<int>() { 7, 8, 9 });

            // arr = arr1;


            //return difference;

            int n = arr.Count;
            int sum1 = 0; // sum of the first diagonal
            int sum2 = 0; // sum of the second diagonal

            for (int i = 0; i < n; i++)
            {
                sum1 += arr[i][i]; // add the element on the first diagonal
                sum2 += arr[i][n - 1 - i]; // add the element on the second diagonal
                //if (arr[i][i] == arr[0][0] | arr[i][i] == arr[1][2] | arr[i][i] == arr[2][3])
                //{
                //    sum1 += arr[i][i];
                //}
                //else if (arr[i][i] == arr[0][2] | arr[i][i] == arr[1][2] | arr[i][i] == arr[2][1])
                //{
                //    sum2 += arr[i][i];
                //}
            }




            return Math.Abs(sum1 - sum2); // return the absolute difference between the sums
        }

    }
}
