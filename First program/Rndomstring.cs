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
        string horiz = "   ";
        string verticle = "   ";
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {

                roomString[i, j] = checkstring();
                roomString[j, i] = checkstring();

                Console.Write(roomString[i, j] + " ");
                // Console.Write(roomString[j, i] + " ");

                // Console.WriteLine();


                horiz += roomString[i, j];
                verticle += roomString[j, i];


            }
            Console.WriteLine();

        }


        Console.WriteLine("Horizental sequence is " + horiz + " ");
        count = Matchstring(horiz, count);

        Console.WriteLine("Total count of SOS : " + count);

        Console.WriteLine("Verticle sequence is " + verticle + " ");
        count = Matchstring(verticle, count);

        Console.WriteLine("Total count of SOS : " + count);
         horiz = "";
        verticle = "";
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