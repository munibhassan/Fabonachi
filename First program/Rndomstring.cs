using FirstProgram;
using System;
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
        string check = "   ";
        string verticle = "   ";
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {

                roomString[i, j] = checkstring();
                Console.Write(roomString[i, j] + " ");


                check += roomString[i, j];

                //  verticle += roomString[j, i];

            }
            Console.WriteLine(" ");


        }
        count = Matchstring(check, count);

        count = Matchstring(verticle, count);
        Console.WriteLine("Total count of SOS : " + count);

        verticle = "";
        check = "";
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
        RandomStringInArraySample p = new RandomStringInArraySample();
        // p.checkstring();
        p.method();

    }
}