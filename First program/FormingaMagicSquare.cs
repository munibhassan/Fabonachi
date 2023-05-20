using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    public class FormingaMagicSquare
    {
        public static int formingMagicSquare(List<List<int>> s)
        {
            int[][] magicSquares = new int[][]
                    {
                        new int[] { 8, 1, 6, 3, 5, 7, 4, 9, 2 },
                        new int[] { 6, 1, 8, 7, 5, 3, 2, 9, 4 },
                        new int[] { 4, 9, 2, 3, 5, 7, 8, 1, 6 },
                        new int[] { 2, 9, 4, 7, 5, 3, 6, 1, 8 },
                        new int[] { 8, 3, 4, 1, 5, 9, 6, 7, 2 },
                        new int[] { 4, 3, 8, 9, 5, 1, 2, 7, 6 },
                        new int[] { 6, 7, 2, 1, 5, 9, 8, 3, 4 },
                        new int[] { 2, 7, 6, 9, 5, 1, 4, 3, 8 }
                    };

            int minCost = int.MaxValue;

            foreach (int[] magicSquare in magicSquares)
            {
                int cost = 0;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        cost += Math.Abs(s[i][j] - magicSquare[i * 3 + j]);
                    }
                }

                minCost = Math.Min(minCost, cost);
            }

            return minCost;
        }
    }
}
