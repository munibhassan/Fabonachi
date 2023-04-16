using First_program;
using FirstProgram;
using System;
using System.Collections.Generic;
using System.Linq;

public class RandomStringInArraySample
{
    public string checkstring()
    {
        string[] authors = { "S", "O" };
        Random rand = new Random();

        int index = rand.Next(authors.Length);
        // Display the result.  
        //  Console.WriteLine(authors[index]);

        return authors[index];

    }
    public void method()
    {
        string[,] roomString = new string[4, 4];
        int count = 0;
        string rep = "";
        string[,] horiz = new string[4, 4];
        string[,] verticle = new string[4, 4];
        string[,] munnaarray = new string[8, 8];
        Console.WriteLine("Random  sequence is  ");
        int Eight_Row = 0;
        int Eight_Col = 0;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {

                roomString[i, j] = checkstring();
                Console.Write(roomString[i, j] + " ");

                munnaarray[Eight_Row, Eight_Col] = roomString[i, j];
                // Console.Write(munnaarray[Eight_Row, Eight_Col] + " ");
                Eight_Col++;
                if (Eight_Col == 8 && Eight_Row == 0)
                {
                    Eight_Col = 0;
                    Eight_Row = 1;
                }

            }

            Console.WriteLine();

        }
        Console.WriteLine();
        Console.WriteLine("Horizontal sequence is  ");
        // horiz=verticle;
        // Array.Resize(ref munnaarray,);
        Eight_Row = 2;
        Eight_Col = 0;

        int Print_Row = 0;
        int Print_Col = 0;

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {

                if (i < 4 && j < 4)
                {
                    munnaarray[Eight_Row, Eight_Col] = roomString[j, i];
                    Console.Write(munnaarray[Print_Row, Print_Col] + " ");
                    Eight_Col++;
                    Print_Col++;
                    if (Eight_Col == 8 && Eight_Row == 2)
                    {
                        Eight_Col = 0;
                        Eight_Row = 3;
                    }
                    if (Print_Col == 8)
                    {
                        Print_Col = 0;
                        Print_Row++;
                    }
                }

                if (i > 4 && j > 4)
                {
                    if (i == 5 && j == 5)
                    {
                        Console.WriteLine("Verticle sequence is  ");
                    }
                    Console.Write(munnaarray[Print_Row, Print_Col] + " ");
                    if (Print_Col == 3 || Print_Col == 7)
                    {
                        Console.WriteLine();
                    }
                    Print_Col++;
                    if (Print_Col == 8)
                    {
                        Print_Col = 0;
                        Print_Row++;
                    }
                }

            }

            if (i < 4)
            {
                Console.WriteLine();
            }

        }


        // Console.WriteLine("Verticle sequence is  ");

        Console.WriteLine();
        //  count = Matchstring(verticle, count);
        Console.WriteLine("Total count of SOS : " + count);
        //Console.WriteLine();

        //Console.WriteLine("Horizental sequence is  ");

        //Console.WriteLine();
        // horiz = "";
        // verticle = "";
    }
    public int Matchstring(string check, int count = 0)
    {
        string match = "SOS";


        if (check.Contains(match))
        {

            count++;

            Console.WriteLine(" SOS  Found " + count);



        }
        else
        { Console.WriteLine(" SOS not Found"); }
        return count;

    }

    public static void Main()
    {
        //RandomStringInArraySample p = new RandomStringInArraySample();
        //// p.checkstring();
        ////  p.method();
        //Random random = new Random();
        //int n = random.Next(1, 101); // generates a random integer between 1 and 100

        //for (int i = 0; i < 100; i++)
        //{
        //    n = random.Next(1, 101); // generates a random integer between 1 and 100
        //    Console.Write("Input " + n.ToString() + ": ");
        //    fizzBuzz(n);
        //}

        // SalesbyMatch.sockMerchant(4, new List<int> { 5,3,1, 2, 3, 4, 5, 4, 6, 3, 3, 8 });
        // List<List<int>> arr = new List<List<int>>();
        // DiagonalDifference.diagonalDifference(arr);


        // PlusMinus.plusMinus(new List<int> { -15, 3, -1, 2, 3, 0, 5, -4, 6, 3, 3, 18 });

        // Staircase.staircase(5);

        // Mini_MaxSum.miniMaxSum(new List<int> { 999999999, 100000000, 10000000, 999999998, 999999997 });

        //  BirthdayCakeCandles.birthdayCakeCandles(new List<int> { 5, 3, 1, 5, 3, 4 });
        //TimeConversion.timeConversion("07:05:45PM");

        // BricksGame.bricksGame(new List<int> { 999, 1, 1, 1, 0 });
        // BricksGame.bricksGame(new List<int> { 0, 1, 1, 1, 999 });

        #region
        //        BricksGame.bricksGame(new List<int> { 6885396,
        //3777681,
        //866081 ,
        //33313  ,
        //6706991,
        //1874325,
        //6224834,
        //8380922,
        //6858563,
        //5632814,
        //6064794,
        //2689467,
        //5457232,
        //449947 ,
        //3637929,
        //5052389,
        //3925918,
        //2659471,
        //7169619,
        //2002463,
        //226255 ,
        //1970295,
        //4185066,
        //1973901,
        //1299752,
        //8172862,
        //8866497,
        //9471062,
        //8464143,
        //6812190,
        //5716416,
        //5349539,
        //3106223,
        //9098849,
        //7899204,
        //2329566,
        //973174 ,
        //4124038,
        //3226840,
        //348089 ,
        //9756852,
        //9291634,
        //5553908,
        //5214084,
        //2257934,
        //9191838,
        //2782825,
        //8700204,
        //1851309,
        //2468796,
        //702667 ,
        //4593916,
        //4439092,
        //7404086,
        //6567818,
        //5738844,
        //5576948,
        //5434315,
        //5209906,
        //6557443,
        //4762857,
        //3442675,
        //4423334,
        //385432 ,
        //2541524,
        //2322539,
        //2714998,
        //6031051,
        //6446577,
        //8458191,
        //6379140,
        //8719782,
        //266177 ,
        //1933049,
        //6450218,
        //2524111,
        //3641239,
        //9233044,
        //3740668,
        //8008900 });
        #endregion

        // LongestIncreasingSubsequence.longestIncreasingSubsequence(new List<long> { 2, 5, 3, 7, 11, 8, 10, 13, 6 });

        //GradingStudents.gradingStudents(new List<int> { 73,67,38,33 });

        //  GradingStudents.gradingStudents(new List<int> { 60,64,24,68,14,53,49,45,99,55,24,59,67,8 ,76,37,24,24,73 });

        //  BasicProblemSolving.findSubstring("caberqiitefg", 5);
        //List<string> dictionary = new List<string> { "hack", "a", "rank", "khac", "ackh", "kran", "rankhacker", "a", "ab", "ba", "stairs", "raits" };
        //List<string> query = new List<string> { "a", "nark", "bs", "hack", "stair" };
        //StringAnnagrams.stringAnagram(dictionary, query);

        #region
        //string s = "caberqiitefg";
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

        //  Console.WriteLine("Longest substring that starts and ends with vowels: " + maxSubstring + ", length: " + maxLength);
        #endregion

        // AppleAndOrange.countApplesAndOranges(7, 10, 4, 12, new List<int> { 2, 3, -4 }, new List<int> { 3, -2, -4 });

        // int x1 = 0, v1 = 3, x2 = 4, v2 = 2;
        //int x1 = 43, v1 = 2, x2 = 70, v2 = 2;

        //string result = NumberLineJumps.kangaroo(x1, v1, x2, v2);
        //Console.WriteLine(result); // Output: YES

        // BetweenTwoSets.getTotalX(new List<int> { 2 ,4 }, new List<int> { 16, 32, 96 });//

        // BreakingtheRecords.breakingRecords(new List<int> { 10, 5, 20, 20, 4, 5, 2, 25, 1});

        // SubarrayDivision.birthday(new List<int> { 1, 2, 1, 3, 2 },3,2);
        //DivisibleSumPairs.divisibleSumPairs(6,5,new List<int> { 1, 2, 3, 4, 5, 6 });
        //DivisibleSumPairs.divisibleSumPairs(6, 5, new List<int> { 1, 3, 2, 6, 1, 2 });

        // MigratoryBirds.migratoryBirds(new List<int> { 1, 4, 4, 4, 5, 3 });

        DayoftheProgrammer.dayOfProgrammer(1800);



    }
    private static bool IsVowel(char c)
    {
        return "aeiou".IndexOf(Char.ToLower(c)) != -1;
    }
    public static void fizzBuzz(int n)
    {
        string name = n.ToString();
        if (n % 3 == 0 & n % 5 == 0)
        {
            name = "FizzBuzz";
        }
        else if (n % 3 == 0 & n % 5 != 0)
        {
            name = "Fizz";
        }
        else if (n % 3 != 0 & n % 5 == 0)
        {
            name = "Buzz";
        }
        else
        {
            name = n.ToString();
        }

        Console.WriteLine(name);
    }

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int alice = 0; int bob = 0;
        List<int> result = new List<int>(2);
        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
            {
                alice += 1;
            }
            else if (a[i] < b[i])
            {
                bob += 1;
            }
        }

        result.Add(alice);
        result.Add(bob);
        return result;
    }

}