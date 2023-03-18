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
        //    Console.Write("Input " + n.ToString()+": ");
        //    fizzBuzz(n);
        //}

        // SalesbyMatch.sockMerchant(4, new List<int> { 5,3,1, 2, 3, 4, 5, 4, 6, 3, 3, 8 });
        // List<List<int>> arr = new List<List<int>>();
        // DiagonalDifference.diagonalDifference(arr);

        
        PlusMinus.plusMinus(new List<int> { -15, 3, -1, 2, 3, 0, 5, -4, 6, 3, 3, 18 });

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